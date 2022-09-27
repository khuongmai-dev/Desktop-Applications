
namespace Mai.Justin.RRCAGApp
{
    partial class RRCAutomotiveGroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuAutomotiveGroup = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusalesQuoteForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCarWashForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleDataForm = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutomotiveGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAutomotiveGroup
            // 
            this.mnuAutomotiveGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.dataMenu,
            this.helpMenu});
            this.mnuAutomotiveGroup.Location = new System.Drawing.Point(0, 0);
            this.mnuAutomotiveGroup.Name = "mnuAutomotiveGroup";
            this.mnuAutomotiveGroup.Size = new System.Drawing.Size(718, 24);
            this.mnuAutomotiveGroup.TabIndex = 1;
            this.mnuAutomotiveGroup.Text = "menuStrip2";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.toolStripSeparator1,
            this.mnuExit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnusalesQuoteForm,
            this.mnuCarWashForm});
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuOpen.Text = "&Open";
            // 
            // mnusalesQuoteForm
            // 
            this.mnusalesQuoteForm.Name = "mnusalesQuoteForm";
            this.mnusalesQuoteForm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnusalesQuoteForm.Size = new System.Drawing.Size(180, 22);
            this.mnusalesQuoteForm.Text = "&Sales Quote";
            // 
            // mnuCarWashForm
            // 
            this.mnuCarWashForm.Name = "mnuCarWashForm";
            this.mnuCarWashForm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnuCarWashForm.Size = new System.Drawing.Size(180, 22);
            this.mnuCarWashForm.Text = "&Car Wash";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "&Exit";
            // 
            // dataMenu
            // 
            this.dataMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleDataForm});
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.Size = new System.Drawing.Size(43, 20);
            this.dataMenu.Text = "&Data";
            // 
            // mnuVehicleDataForm
            // 
            this.mnuVehicleDataForm.Name = "mnuVehicleDataForm";
            this.mnuVehicleDataForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.mnuVehicleDataForm.Size = new System.Drawing.Size(189, 22);
            this.mnuVehicleDataForm.Text = "&Vehicles";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuAbout.Text = "&About...";
            // 
            // RRCAutomotiveGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 526);
            this.Controls.Add(this.mnuAutomotiveGroup);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuAutomotiveGroup;
            this.MaximizeBox = false;
            this.Name = "RRCAutomotiveGroupForm";
            this.Text = "RRC Automotive Group";
            this.mnuAutomotiveGroup.ResumeLayout(false);
            this.mnuAutomotiveGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MnuAboutForm_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuAutomotiveGroup;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem dataMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnusalesQuoteForm;
        private System.Windows.Forms.ToolStripMenuItem mnuCarWashForm;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleDataForm;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

