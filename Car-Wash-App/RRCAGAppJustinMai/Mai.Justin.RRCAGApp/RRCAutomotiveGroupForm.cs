using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mai.Justin.RRCAGApp
{
    /// <summary>
    /// Represent the RRCautomotiveGroup Form
    /// </summary>
    public partial class RRCAutomotiveGroupForm : Form
    {
        //Initializes an instance of the RRCAutomotiveGroupForm class with the design and event subscription
        public RRCAutomotiveGroupForm()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.RRCAutomotiveGroupForm_Load);
            this.mnusalesQuoteForm.Click += new System.EventHandler(this.SalesQuoteMenu_Click);
            this.mnuCarWashForm.Click += new System.EventHandler(this.carWashMenu_Click);
            this.mnuVehicleDataForm.Click += new System.EventHandler(this.mnuVehicleDataForm_Click);
            this.mnuAbout.Click += new System.EventHandler(this.mnuAboutForm_Click);
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
        }

        /// <summary>
        /// Handles the load event of the RRCAutomotiveGroupForm 
        /// </summary>
        private void RRCAutomotiveGroupForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.mnuAutomotiveGroup.Dock = DockStyle.Top;
            this.Text = "RRC Automotive Group";
            this.MaximizeBox = true;
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Handles the click event of the Sales Quote menu item
        /// </summary>
        private void SalesQuoteMenu_Click(object sender, EventArgs e)
        {                    
                //initiate a salesQuoteForm instance
                SalesQuoteForm salesQuoteForm = new SalesQuoteForm();
                salesQuoteForm.MdiParent = this;
                salesQuoteForm.Show();           

        }

        /// <summary>
        /// Handles the event of the car Wash Menu item
        /// </summary>
        private void carWashMenu_Click(object sender, EventArgs e)
        {       
            string fragrances = "fragrances.txt";
            if(File.Exists(fragrances))
            {
                CarWashForm carWashForm = new CarWashForm();
                carWashForm.MdiParent = this;
                carWashForm.Show();
            }
            else 
            {
                string message = "Fragrances data file not found.";
                string caption = "Data File Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, caption, buttons, icon, MessageBoxDefaultButton.Button1);
            }
            
           
        }

        //Declare an instance of VehicleDataForm
        private VehicleDataForm vehicleDataForm;

        /// <summary>
        /// Handles the event of the Vehicle Data menu item
        /// </summary>
        private void mnuVehicleDataForm_Click(object sender, EventArgs e)
        {
            if (vehicleDataForm == null || vehicleDataForm.Text == "")
            {
                //initiate a vehicleDataForm instance
                vehicleDataForm = new VehicleDataForm();
                vehicleDataForm.MdiParent = this;
                vehicleDataForm.Show();
            }

            else
            {
                //vehicleDataForm.WindowState = FormWindowState.Normal;
                vehicleDataForm.Focus();
            }
        }

        /// <summary>
        /// Handles the event of the About menu item
        /// </summary>
        private void mnuAboutForm_Click(object sender, EventArgs e)
        {
            //Initiate an instance of child form.
            AboutForm aboutForm = new AboutForm();
            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the event of the exit menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}