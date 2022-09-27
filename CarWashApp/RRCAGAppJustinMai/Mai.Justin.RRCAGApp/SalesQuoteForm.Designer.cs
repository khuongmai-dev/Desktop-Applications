
namespace Mai.Justin.RRCAGApp
{
    partial class SalesQuoteForm
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
            this.components = new System.ComponentModel.Container();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.lblVehicleSalePrice_Summary = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.lblTradein_Display = new System.Windows.Forms.Label();
            this.lblTotal_Display = new System.Windows.Forms.Label();
            this.lblSalesTax_Display = new System.Windows.Forms.Label();
            this.lblSubTotal_Display = new System.Windows.Forms.Label();
            this.lblOptions_Display = new System.Windows.Forms.Label();
            this.lblVehicleSalePrice_SummaryDisplay = new System.Windows.Forms.Label();
            this.lblAmountDue_Display = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradein = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotals = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkComputerNavigation = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.financeGroupBox = new System.Windows.Forms.GroupBox();
            this.lblMonthlyPayment_Display = new System.Windows.Forms.Label();
            this.nudAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.nudNoOfYears = new System.Windows.Forms.NumericUpDown();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblNoOfYears = new System.Windows.Forms.Label();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.txtVehicleSalesPrice = new System.Windows.Forms.TextBox();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.lblTradeinValue = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.summaryGroupBox.SuspendLayout();
            this.grpAccessories.SuspendLayout();
            this.financeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).BeginInit();
            this.grpExteriorFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.AutoSize = true;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(34, 27);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(100, 13);
            this.lblVehicleSalePrice.TabIndex = 10;
            this.lblVehicleSalePrice.Text = "Vehicle\'sSale Price:";
            // 
            // lblVehicleSalePrice_Summary
            // 
            this.lblVehicleSalePrice_Summary.AutoSize = true;
            this.lblVehicleSalePrice_Summary.Location = new System.Drawing.Point(51, 32);
            this.lblVehicleSalePrice_Summary.Name = "lblVehicleSalePrice_Summary";
            this.lblVehicleSalePrice_Summary.Size = new System.Drawing.Size(100, 13);
            this.lblVehicleSalePrice_Summary.TabIndex = 15;
            this.lblVehicleSalePrice_Summary.Text = "Vehicle\'sSale Price:";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.lblTradein_Display);
            this.summaryGroupBox.Controls.Add(this.lblTotal_Display);
            this.summaryGroupBox.Controls.Add(this.lblSalesTax_Display);
            this.summaryGroupBox.Controls.Add(this.lblSubTotal_Display);
            this.summaryGroupBox.Controls.Add(this.lblOptions_Display);
            this.summaryGroupBox.Controls.Add(this.lblVehicleSalePrice_SummaryDisplay);
            this.summaryGroupBox.Controls.Add(this.lblAmountDue_Display);
            this.summaryGroupBox.Controls.Add(this.lblAmountDue);
            this.summaryGroupBox.Controls.Add(this.lblTradein);
            this.summaryGroupBox.Controls.Add(this.lblTotal);
            this.summaryGroupBox.Controls.Add(this.lblSalesTax);
            this.summaryGroupBox.Controls.Add(this.lblSubtotals);
            this.summaryGroupBox.Controls.Add(this.lblOptions);
            this.summaryGroupBox.Controls.Add(this.lblVehicleSalePrice_Summary);
            this.summaryGroupBox.Location = new System.Drawing.Point(303, 21);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(315, 259);
            this.summaryGroupBox.TabIndex = 12;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // lblTradein_Display
            // 
            this.lblTradein_Display.BackColor = System.Drawing.SystemColors.Control;
            this.lblTradein_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradein_Display.Location = new System.Drawing.Point(162, 188);
            this.lblTradein_Display.MaximumSize = new System.Drawing.Size(200, 30);
            this.lblTradein_Display.Name = "lblTradein_Display";
            this.lblTradein_Display.Size = new System.Drawing.Size(120, 20);
            this.lblTradein_Display.TabIndex = 26;
            // 
            // lblTotal_Display
            // 
            this.lblTotal_Display.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal_Display.Location = new System.Drawing.Point(162, 155);
            this.lblTotal_Display.MaximumSize = new System.Drawing.Size(200, 30);
            this.lblTotal_Display.Name = "lblTotal_Display";
            this.lblTotal_Display.Size = new System.Drawing.Size(120, 20);
            this.lblTotal_Display.TabIndex = 24;
            // 
            // lblSalesTax_Display
            // 
            this.lblSalesTax_Display.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalesTax_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTax_Display.Location = new System.Drawing.Point(162, 122);
            this.lblSalesTax_Display.MaximumSize = new System.Drawing.Size(200, 30);
            this.lblSalesTax_Display.Name = "lblSalesTax_Display";
            this.lblSalesTax_Display.Size = new System.Drawing.Size(120, 20);
            this.lblSalesTax_Display.TabIndex = 22;
            // 
            // lblSubTotal_Display
            // 
            this.lblSubTotal_Display.BackColor = System.Drawing.SystemColors.Control;
            this.lblSubTotal_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal_Display.Location = new System.Drawing.Point(162, 89);
            this.lblSubTotal_Display.MaximumSize = new System.Drawing.Size(200, 30);
            this.lblSubTotal_Display.Name = "lblSubTotal_Display";
            this.lblSubTotal_Display.Size = new System.Drawing.Size(120, 20);
            this.lblSubTotal_Display.TabIndex = 20;
            // 
            // lblOptions_Display
            // 
            this.lblOptions_Display.BackColor = System.Drawing.SystemColors.Control;
            this.lblOptions_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptions_Display.Location = new System.Drawing.Point(162, 55);
            this.lblOptions_Display.MaximumSize = new System.Drawing.Size(200, 30);
            this.lblOptions_Display.Name = "lblOptions_Display";
            this.lblOptions_Display.Size = new System.Drawing.Size(120, 20);
            this.lblOptions_Display.TabIndex = 18;
            // 
            // lblVehicleSalePrice_SummaryDisplay
            // 
            this.lblVehicleSalePrice_SummaryDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.lblVehicleSalePrice_SummaryDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalePrice_SummaryDisplay.Location = new System.Drawing.Point(162, 28);
            this.lblVehicleSalePrice_SummaryDisplay.MaximumSize = new System.Drawing.Size(200, 30);
            this.lblVehicleSalePrice_SummaryDisplay.Name = "lblVehicleSalePrice_SummaryDisplay";
            this.lblVehicleSalePrice_SummaryDisplay.Size = new System.Drawing.Size(120, 20);
            this.lblVehicleSalePrice_SummaryDisplay.TabIndex = 16;
            // 
            // lblAmountDue_Display
            // 
            this.lblAmountDue_Display.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAmountDue_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDue_Display.Location = new System.Drawing.Point(162, 221);
            this.lblAmountDue_Display.MaximumSize = new System.Drawing.Size(200, 30);
            this.lblAmountDue_Display.Name = "lblAmountDue_Display";
            this.lblAmountDue_Display.Size = new System.Drawing.Size(120, 20);
            this.lblAmountDue_Display.TabIndex = 28;
            this.lblAmountDue_Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(82, 225);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(69, 13);
            this.lblAmountDue.TabIndex = 27;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // lblTradein
            // 
            this.lblTradein.AutoSize = true;
            this.lblTradein.Location = new System.Drawing.Point(102, 192);
            this.lblTradein.Name = "lblTradein";
            this.lblTradein.Size = new System.Drawing.Size(49, 13);
            this.lblTradein.TabIndex = 25;
            this.lblTradein.Text = "Trade-in:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(117, 159);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Total:";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(65, 129);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(86, 13);
            this.lblSalesTax.TabIndex = 21;
            this.lblSalesTax.Text = "Sales Tax (12%):";
            // 
            // lblSubtotals
            // 
            this.lblSubtotals.AutoSize = true;
            this.lblSubtotals.Location = new System.Drawing.Point(102, 93);
            this.lblSubtotals.Name = "lblSubtotals";
            this.lblSubtotals.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotals.TabIndex = 19;
            this.lblSubtotals.Text = "Subtotal:";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(105, 59);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(46, 13);
            this.lblOptions.TabIndex = 17;
            this.lblOptions.Text = "Options:";
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(34, 102);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(223, 120);
            this.grpAccessories.TabIndex = 3;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkComputerNavigation
            // 
            this.chkComputerNavigation.AutoSize = true;
            this.chkComputerNavigation.Location = new System.Drawing.Point(27, 85);
            this.chkComputerNavigation.Name = "chkComputerNavigation";
            this.chkComputerNavigation.Size = new System.Drawing.Size(125, 17);
            this.chkComputerNavigation.TabIndex = 4;
            this.chkComputerNavigation.Text = "Computer Navigation";
            this.chkComputerNavigation.UseVisualStyleBackColor = true;
            
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(27, 58);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.chkLeatherInterior.TabIndex = 3;
            this.chkLeatherInterior.Text = "Leather Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Checked = true;
            this.chkStereoSystem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStereoSystem.Location = new System.Drawing.Point(27, 30);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(94, 17);
            this.chkStereoSystem.TabIndex = 2;
            this.chkStereoSystem.Text = "Stereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            // 
            // financeGroupBox
            // 
            this.financeGroupBox.Controls.Add(this.lblMonthlyPayment_Display);
            this.financeGroupBox.Controls.Add(this.nudAnnualInterestRate);
            this.financeGroupBox.Controls.Add(this.nudNoOfYears);
            this.financeGroupBox.Controls.Add(this.lblMonthlyPayment);
            this.financeGroupBox.Controls.Add(this.lblAnnualInterestRate);
            this.financeGroupBox.Controls.Add(this.lblNoOfYears);
            this.financeGroupBox.Location = new System.Drawing.Point(303, 286);
            this.financeGroupBox.Name = "financeGroupBox";
            this.financeGroupBox.Size = new System.Drawing.Size(315, 90);
            this.financeGroupBox.TabIndex = 6;
            this.financeGroupBox.TabStop = false;
            this.financeGroupBox.Text = "Finance";
            // 
            // lblMonthlyPayment_Display
            // 
            this.lblMonthlyPayment_Display.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPayment_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment_Display.Location = new System.Drawing.Point(215, 58);
            this.lblMonthlyPayment_Display.MaximumSize = new System.Drawing.Size(200, 30);
            this.lblMonthlyPayment_Display.Name = "lblMonthlyPayment_Display";
            this.lblMonthlyPayment_Display.Size = new System.Drawing.Size(85, 20);
            this.lblMonthlyPayment_Display.TabIndex = 33;
            this.lblMonthlyPayment_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAnnualInterestRate
            // 
            this.nudAnnualInterestRate.DecimalPlaces = 2;
            this.nudAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAnnualInterestRate.Location = new System.Drawing.Point(120, 58);
            this.nudAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAnnualInterestRate.Name = "nudAnnualInterestRate";
            this.nudAnnualInterestRate.Size = new System.Drawing.Size(75, 20);
            this.nudAnnualInterestRate.TabIndex = 7;
            // 
            // nudNoOfYears
            // 
            this.nudNoOfYears.Location = new System.Drawing.Point(20, 58);
            this.nudNoOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNoOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfYears.Name = "nudNoOfYears";
            this.nudNoOfYears.Size = new System.Drawing.Size(72, 20);
            this.nudNoOfYears.TabIndex = 6;
            this.nudNoOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(212, 21);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(88, 13);
            this.lblMonthlyPayment.TabIndex = 32;
            this.lblMonthlyPayment.Text = "Monthly Payment";
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.AutoSize = true;
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(117, 19);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(68, 26);
            this.lblAnnualInterestRate.TabIndex = 31;
            this.lblAnnualInterestRate.Text = "Annual\r\nInterest Rate";
            // 
            // lblNoOfYears
            // 
            this.lblNoOfYears.AutoSize = true;
            this.lblNoOfYears.Location = new System.Drawing.Point(17, 31);
            this.lblNoOfYears.Name = "lblNoOfYears";
            this.lblNoOfYears.Size = new System.Drawing.Size(66, 13);
            this.lblNoOfYears.TabIndex = 30;
            this.lblNoOfYears.Text = "No. of Years";
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.radCustomizedDetailing);
            this.grpExteriorFinish.Controls.Add(this.radPearlized);
            this.grpExteriorFinish.Controls.Add(this.radStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(34, 246);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Size = new System.Drawing.Size(223, 130);
            this.grpExteriorFinish.TabIndex = 5;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // radCustomizedDetailing
            // 
            this.radCustomizedDetailing.AutoSize = true;
            this.radCustomizedDetailing.Location = new System.Drawing.Point(24, 93);
            this.radCustomizedDetailing.Name = "radCustomizedDetailing";
            this.radCustomizedDetailing.Size = new System.Drawing.Size(123, 17);
            this.radCustomizedDetailing.TabIndex = 5;
            this.radCustomizedDetailing.Text = "Customized Detailing";
            this.radCustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(24, 62);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(68, 17);
            this.radPearlized.TabIndex = 5;
            this.radPearlized.Text = "Pearlized";
            this.radPearlized.UseVisualStyleBackColor = true;
            
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Location = new System.Drawing.Point(24, 30);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 5;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // txtVehicleSalesPrice
            // 
            this.errorProvider.SetIconPadding(this.txtVehicleSalesPrice, 3);
            this.txtVehicleSalesPrice.Location = new System.Drawing.Point(137, 21);
            this.txtVehicleSalesPrice.Name = "txtVehicleSalesPrice";
            this.txtVehicleSalesPrice.Size = new System.Drawing.Size(120, 20);
            this.txtVehicleSalesPrice.TabIndex = 0;
            this.txtVehicleSalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;          
            // 
            // txtTradeInValue
            // 
            this.errorProvider.SetIconPadding(this.txtTradeInValue, 3);
            this.txtTradeInValue.Location = new System.Drawing.Point(137, 54);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(120, 20);
            this.txtTradeInValue.TabIndex = 1;
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            
            // 
            // lblTradeinValue
            // 
            this.lblTradeinValue.AutoSize = true;
            this.lblTradeinValue.Location = new System.Drawing.Point(53, 60);
            this.lblTradeinValue.Name = "lblTradeinValue";
            this.lblTradeinValue.Size = new System.Drawing.Size(79, 13);
            this.lblTradeinValue.TabIndex = 11;
            this.lblTradeinValue.Text = "Trade-in Value:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(34, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 28);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(508, 395);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(110, 28);
            this.btnCalculateQuote.TabIndex = 8;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
           
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SalesQuoteForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(650, 433);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTradeinValue);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.txtVehicleSalesPrice);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.financeGroupBox);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.lblVehicleSalePrice);
            this.Name = "SalesQuoteForm";
            this.Padding = new System.Windows.Forms.Padding(3);          
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.financeGroupBox.ResumeLayout(false);
            this.financeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfYears)).EndInit();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.Label lblVehicleSalePrice_Summary;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.GroupBox financeGroupBox;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.TextBox txtVehicleSalesPrice;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.Label lblTradeinValue;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblTradein;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblSubtotals;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.CheckBox chkComputerNavigation;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.Label lblNoOfYears;
        private System.Windows.Forms.RadioButton radCustomizedDetailing;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.NumericUpDown nudAnnualInterestRate;
        private System.Windows.Forms.NumericUpDown nudNoOfYears;

        private System.Windows.Forms.Label lblAmountDue_Display;
        private System.Windows.Forms.Label lblMonthlyPayment_Display;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblTradein_Display;
        private System.Windows.Forms.Label lblTotal_Display;
        private System.Windows.Forms.Label lblSalesTax_Display;
        private System.Windows.Forms.Label lblSubTotal_Display;
        private System.Windows.Forms.Label lblOptions_Display;
        private System.Windows.Forms.Label lblVehicleSalePrice_SummaryDisplay;
    }
}