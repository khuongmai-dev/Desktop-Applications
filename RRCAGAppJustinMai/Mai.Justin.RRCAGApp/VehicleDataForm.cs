using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACE.BIT.ADEV.Forms;
using ACE.BIT.ADEV.CarWash;
using System.Data.OleDb;

namespace Mai.Justin.RRCAGApp
{
    public partial class VehicleDataForm : ACE.BIT.ADEV.Forms.VehicleDataForm
    {
        private OleDbConnection connection;
        private OleDbDataAdapter adapter;
        private DataSet dataset;
        private BindingSource bindingSource;

        public VehicleDataForm()
        {
            try
            {
                InitializeComponent();

                this.bindingSource = new BindingSource();

                this.mnuFileSave.Click += new EventHandler(FileSave_Click);
                this.mnuFileClose.Click += new EventHandler(FileClose_Click);
                this.mnuEditDelete.Click += new EventHandler(FileDelete_Click);
                this.dgvVehicles.SelectionChanged += new EventHandler(dgvVehicle_SelectionChanged);

                this.dgvVehicles.CellValueChanged += new DataGridViewCellEventHandler(dgvVehicles_CellValueChanged);

                //Save menu item disabled
                mnuFileSave.Enabled = false;

                //Delete menu item disabled
                mnuEditDelete.Enabled = false;

                //Title of the form is Vehicle Data.
                this.Text = "Vehicle Data";

                //The Form is maximized within the MDI container.
                this.WindowState = FormWindowState.Maximized;

                //Disable the ability for users to delete rows.
                dgvVehicles.AllowUserToDeleteRows = false;

                //Disable the ability for users to resize rows.
                dgvVehicles.AllowUserToResizeRows = false;

                //Auto size columns using Fill mode.
                dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //Disable the ability for users to select multiple rows.
                dgvVehicles.MultiSelect = false;

                //Populated with all the vehicle data from the database.
                connection = new OleDbConnection();
                connection.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = AMDatabase.mdb";
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM VehicleStock";

                this.adapter = new OleDbDataAdapter();
                adapter.SelectCommand = command;

                this.dataset = new DataSet();
                this.adapter.Fill(this.dataset, "VehicleStock");

                OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder();
                commandBuilder.DataAdapter = this.adapter;

                //prevent concurrency exceptions
                commandBuilder.ConflictOption = ConflictOption.OverwriteChanges;

                adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
                adapter.InsertCommand = commandBuilder.GetInsertCommand();

                BindControls();
            }
            catch (Exception)
            {
                string message = "Unable to load vehicle data.";
                string caption = "Data Load Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, icon, MessageBoxDefaultButton.Button1);

            };
        }

        /// <summary>
        /// Binds the controls on the form.
        /// </summary>
        private void BindControls()
        {
            bindingSource.DataSource = dataset.Tables["VehicleStock"];
            dgvVehicles.DataSource = bindingSource;

           dgvVehicles.Columns["ID"].Visible = false;
            dgvVehicles.Columns["SoldBy"].Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the Save menu item.
        /// When the Save menu item is clicked, all data changes are saved to the database. 
        /// After a successful save, the Save menu item is disabled.
        /// </summary>
        private void FileSave_Click(object sender, EventArgs e)
        {
            adapter.Update(dataset, "VehicleStock");
        }

        /// <summary>
        /// When the Close menu item is clicked, close the Form.
        /// </summary>
        private void FileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// When the Delete menu item is clicked, 
        /// the selected row is removed from the DataGridView and deleted from the database.
        /// </summary>
        private void FileDelete_Click(object sender, EventArgs e)
        {
            string stockNumber = dgvVehicles.CurrentRow.Cells[1].Value.ToString();
            string message = String.Format("Are you sure you want to permanently delete stock item {0}?", stockNumber);
            string caption = "Delete Stock Item";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, icon, MessageBoxDefaultButton.Button2);

            switch (result)
            {
                case DialogResult.Yes:
                    try
                    {
                        foreach (DataGridViewRow item in this.dgvVehicles.SelectedRows)
                        {
                            dgvVehicles.Rows.RemoveAt(item.Index);
                        }
                        adapter.Update(dataset, "VehicleStock");
                    }
                    catch(Exception)
                    {
                        string errorMessage = "An error occurred while deleting the selected vehicle.";
                        string errorCaption = "Deletion Error";
                        MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                        MessageBoxIcon errorIcon = MessageBoxIcon.Error;
                        DialogResult errorResult;
                        MessageBox.Show(errorMessage, errorCaption, errorButtons, errorIcon, MessageBoxDefaultButton.Button1);
                    }                  
                    break;
                case DialogResult.No:                  
                    break;
            }
        }

        /// <summary>
        /// Handles the Click event of the selection changed in datagridview
        /// </summary>
        void dgvVehicle_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvVehicles.CurrentRow.IsNewRow.ToString());
            if (dgvVehicles.CurrentRow.Selected && !dgvVehicles.CurrentRow.IsNewRow)
            {
                this.mnuEditDelete.Enabled = true;
            }
            else if(!dgvVehicles.CurrentRow.Selected || dgvVehicles.CurrentRow.IsNewRow)
            {
                this.mnuEditDelete.Enabled = false;
            }       
        }

        /// <summary>
        /// Handles the Click event of the cell value changed in dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvVehicles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.Text = "*Vehicle Data";
            this.mnuFileSave.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of form closing
        /// </summary>
        private void VehicleDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataset.HasChanges())
            {
                string message = "Do you wish to save the changes?";
                string caption = "Save";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                MessageBoxIcon icon = MessageBoxIcon.Warning;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, icon, MessageBoxDefaultButton.Button3);

                switch (result)
                {
                    case DialogResult.Yes:
                        
                        try
                        {
                            adapter.Update(dataset, "VehicleStock");
                        }
                        catch(Exception)
                        {
                            string message1 = "An error occurred while saving the changes. Do you still wish to close this window?";
                            string caption1 = "Save Error";
                            MessageBoxButtons buttons1 = MessageBoxButtons.YesNo;
                            MessageBoxIcon icon1 = MessageBoxIcon.Error;
                            DialogResult result1;

                            result1 = MessageBox.Show(message1, caption1, buttons1, icon1, MessageBoxDefaultButton.Button2);

                            switch(result1)
                            {
                                case DialogResult.Yes:
                                    break;
                                case DialogResult.No:
                                    e.Cancel = true;
                                    break;
                            }
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
    }
}
