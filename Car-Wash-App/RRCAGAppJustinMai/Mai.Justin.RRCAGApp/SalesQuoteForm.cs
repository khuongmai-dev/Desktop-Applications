using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACE.BIT.ADEV;
using Mai.Justin.Business;

namespace Mai.Justin.RRCAGApp
{
    /// <summary>
    /// Represent the SalesQuote form 
    /// </summary>
    public partial class SalesQuoteForm : Form
    {
        //Initializes an instance of the SalesQuoteForm class with the design and event subscription
        public SalesQuoteForm()
        {
            InitializeComponent();

            this.btnCalculateQuote.Click += new System.EventHandler(this.btnCalculateQuote_Click);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.txtVehicleSalesPrice.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            this.txtTradeInValue.TextChanged += new System.EventHandler(this.TextBoxes_TextChanged);
            this.chkComputerNavigation.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);

            this.chkLeatherInterior.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);
            this.chkStereoSystem.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);
            this.radPearlized.CheckedChanged += new System.EventHandler(this.CheckStateChanged);
            this.radCustomizedDetailing.CheckedChanged += new System.EventHandler(this.CheckStateChanged);
            this.radStandard.CheckedChanged += new System.EventHandler(this.CheckStateChanged);
            this.nudNoOfYears.ValueChanged += new System.EventHandler(this.CheckStateChanged);
            this.nudAnnualInterestRate.ValueChanged += new System.EventHandler(this.CheckStateChanged);

            InitialStateForm();
        }

        // Declare a variable of SalesQuote to store value of a SalesQuote object
        private SalesQuote salesQuoteValue;

        private void InitialStateForm()
        {
            //The title of the form is “Vehicle Sales Quote”.
            this.Text = "Vehicle Sales Quote";

            //The form cannot be maximized.
            this.MaximizeBox = false;

            //The form (window) cannot be resized by the user.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //The vehicle sales price Text box has no input (blank) and has focus.
            this.txtVehicleSalesPrice.Text = "";
            this.txtVehicleSalesPrice.Focus();

            //The trade in value Text box is input is set to 0 (zero).
            this.txtTradeInValue.Text = "0";

            //No accessories are chosen.
            this.chkComputerNavigation.Checked = false;
            this.chkLeatherInterior.Checked = false;
            this.chkStereoSystem.Checked = false;

            //Standard exterior finish is chosen.
            this.radStandard.Checked = true;

            //The summary output labels are blank, and the text is middle-right aligned.
            this.lblVehicleSalePrice_SummaryDisplay.TextAlign = ContentAlignment.MiddleRight;
            this.lblVehicleSalePrice_SummaryDisplay.Text = "";
            this.lblOptions_Display.TextAlign = ContentAlignment.MiddleRight;
            this.lblOptions_Display.Text = "";
            this.lblSubTotal_Display.TextAlign = ContentAlignment.MiddleRight;
            this.lblSubTotal_Display.Text = "";
            this.lblSalesTax_Display.TextAlign = ContentAlignment.MiddleRight;
            this.lblSalesTax_Display.Text = "";
            this.lblTotal_Display.TextAlign = ContentAlignment.MiddleRight;
            this.lblTotal_Display.Text = "";
            this.lblTradein_Display.TextAlign = ContentAlignment.MiddleRight;
            this.lblTradein_Display.Text = "";
            this.lblAmountDue_Display.TextAlign = ContentAlignment.MiddleRight;
            this.lblAmountDue_Display.Text = "";

            //The Sales Tax Label shows the current sales tax rate.
            this.lblSalesTax.Text = "Sales Tax (12%):";

            //The number of financing years is set to 1.
            this.nudNoOfYears.Value = 1;

            //The annual interest rate is set to 5%.
            this.nudAnnualInterestRate.Value = 5;

            //The monthly payment label is blank, and the text is middle - center aligned.
            this.lblMonthlyPayment_Display.TextAlign = ContentAlignment.MiddleCenter;
            this.lblMonthlyPayment_Display.Text = "";

            //Error icons are not visible.
            this.errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            //The Calculate Quote button is the accept (default) button for the form.
            this.AcceptButton = this.btnCalculateQuote;

            //An instance of the SalesQuote class is not in memory.
            salesQuoteValue = null;
        }
        
        /// <summary>
        /// Handles the click event of the Calculate Quote Button
        /// </summary>
        private void btnCalculateQuote_Click(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.txtVehicleSalesPrice, "");
            this.errorProvider.SetError(this.txtTradeInValue, "");

            TextBox[] textBoxes = {this.txtVehicleSalesPrice, this.txtTradeInValue };

            //The error messages
            string[] errorMessages = { "Vehicle price is a required field."
                                    , "Vehicle price cannot contain letters or special characters."
                                    ,"Vehicle price cannot be less than or equal to 0."
                                    ,"Trade-in value is a required field."
                                    ,"Trade-in value cannot contain letters or special characters."
                                    ,"Trade-in value cannot be less than 0."
                                    ,"Trade-in value cannot be exceed the vehicle sale price."};
            decimal vehicleSalePrice = 0,
                    tradeInAmount = 0,
                    salesTaxrate = 0.12m,
                    monthlyRate = 0,
                    presentValue = 0;
            int numberOfPaymentPeriods = 0;

            //try and catch for txtVehicleSalesPrice
            try
            {
                //Error message when there is no input
                if (String.IsNullOrEmpty(txtVehicleSalesPrice.Text))
                {
                    throw new ArgumentNullException();
                }
                
                //Convert value from Text box to the decimal value
                vehicleSalePrice = Decimal.Parse(this.txtVehicleSalesPrice.Text);

                //Error message when the input is less than or equal to zero
                if (vehicleSalePrice <= 0)
                {
                    this.errorProvider.SetError(this.txtVehicleSalesPrice, errorMessages[2]);
                }
            }
            catch (FormatException)
            {
                //Error message when the input is not numeric
                this.errorProvider.SetError(textBoxes[0], errorMessages[1]);
            }
            catch (ArgumentNullException)
            {
                //Show error by SetError in errorProvider
                this.errorProvider.SetError(this.txtVehicleSalesPrice, errorMessages[0]);
            }

            //try and catch for txtTradeInValue
            try
            {
                //Error message when there is no input
                if (String.IsNullOrEmpty(txtTradeInValue.Text))
                {
                    throw new ArgumentNullException();
                }

                tradeInAmount = Decimal.Parse(this.txtTradeInValue.Text);

                //Error message when the input is less than zero
                if (tradeInAmount < 0)
                {
                    this.errorProvider.SetError(textBoxes[1], errorMessages[5]);
                }
            }
            catch(FormatException)
            {
                //Error message when the input is not numeric
                this.errorProvider.SetError(textBoxes[1], errorMessages[4]);
            }
            catch (ArgumentNullException)
            {
                //Error message when there is no input
                this.errorProvider.SetError(textBoxes[1], errorMessages[3]);
            }

            //If all inputs are free of errors
            if (this.errorProvider.GetError(this.txtVehicleSalesPrice).Equals(string.Empty) 
                && this.errorProvider.GetError(this.txtTradeInValue).Equals(string.Empty))
            {
                if(tradeInAmount > vehicleSalePrice)
                {
                    //Error message when the input is greater than the vehicle sale price
                    this.errorProvider.SetError(textBoxes[1], errorMessages[6]);
                }

                else
                {
                    // Initialize a salesQuote instance
                    SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxrate);

                    //Assign value of created SalesQuote object to SalesQuoteValue
                    salesQuoteValue = salesQuote;

                    //Set the value of AccessoriesChosen based on the state of check boxes in Accessories Panel
                    if ((this.chkStereoSystem.CheckState == CheckState.Checked) 
                        && (this.chkLeatherInterior.CheckState == CheckState.Unchecked) 
                        && (this.chkComputerNavigation.CheckState == CheckState.Unchecked))
                    {
                        salesQuote.AccessoriesChosen = Accessories.StereoSystem;
                    }
                        
                    if ((this.chkStereoSystem.CheckState == CheckState.Unchecked)
                        && (this.chkLeatherInterior.CheckState == CheckState.Checked)
                        && (this.chkComputerNavigation.CheckState == CheckState.Unchecked))
                    {
                        salesQuote.AccessoriesChosen = Accessories.LeatherInterior;
                    }
                        
                    if ((this.chkStereoSystem.CheckState == CheckState.Unchecked)
                        && (this.chkLeatherInterior.CheckState == CheckState.Unchecked)
                        && (this.chkComputerNavigation.CheckState == CheckState.Checked))
                    {
                        salesQuote.AccessoriesChosen = Accessories.ComputerNavigation;
                    }
                        
                    if ((this.chkStereoSystem.CheckState == CheckState.Checked)
                        && (this.chkLeatherInterior.CheckState == CheckState.Checked)
                        && (this.chkComputerNavigation.CheckState == CheckState.Unchecked))
                    {
                        salesQuote.AccessoriesChosen = Accessories.StereoAndLeather;
                    }
                        
                    if ((this.chkStereoSystem.CheckState == CheckState.Checked)
                        && (this.chkLeatherInterior.CheckState == CheckState.Unchecked)
                        && (this.chkComputerNavigation.CheckState == CheckState.Checked))
                    {
                        salesQuote.AccessoriesChosen = Accessories.StereoAndNavigation;
                    }
                        
                    if ((this.chkStereoSystem.CheckState == CheckState.Unchecked)
                        && (this.chkLeatherInterior.CheckState == CheckState.Checked)
                        && (this.chkComputerNavigation.CheckState == CheckState.Checked))
                    {
                        salesQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;
                    }
                        
                    if ((this.chkStereoSystem.CheckState == CheckState.Checked)
                        && (this.chkLeatherInterior.CheckState == CheckState.Checked)
                        && (this.chkComputerNavigation.CheckState == CheckState.Checked))
                    {
                        salesQuote.AccessoriesChosen = Accessories.All;
                    }
                        
                    if ((this.chkStereoSystem.CheckState == CheckState.Unchecked)
                        && (this.chkLeatherInterior.CheckState == CheckState.Unchecked)
                        && (this.chkComputerNavigation.CheckState == CheckState.Unchecked))
                    {
                        salesQuote.AccessoriesChosen = Accessories.None;
                    }

                    //Set the value of ExteriorFinishChosen based on the state of radio buttons in Exterior Finish Panel
                    if (this.radStandard.Checked)
                        salesQuote.ExteriorFinishChosen = ExteriorFinish.Standard;
                    if (this.radPearlized.Checked)
                        salesQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;
                    if (this.radCustomizedDetailing.Checked)
                        salesQuote.ExteriorFinishChosen = ExteriorFinish.Custom;

                    //The Summary and Finance output will be formatted
                    //Vehicle Sale Price (Currency)
                    this.lblVehicleSalePrice_SummaryDisplay.Text = salesQuote.VehicleSalePrice.ToString("C2");

                    //Options (Number)
                    this.lblOptions_Display.Text = salesQuote.TotalOptions.ToString();

                    //Subtotal(Currency)
                    this.lblSubTotal_Display.Text = salesQuote.SubTotal.ToString("C2");

                    //Sales Tax Amount (Number)
                    this.lblSalesTax_Display.Text = salesQuote.SalesTax.ToString();

                    //Total (Currency)
                    this.lblTotal_Display.Text = salesQuote.Total.ToString("C2");

                    //Trade-in: (Negative Number)
                    this.lblTradein_Display.Text = (-salesQuote.TradeInAmount).ToString("N2");

                    //Amount Due: (Currency)
                    this.lblAmountDue_Display.Text = salesQuote.AmountDue.ToString("C2");

                    //Display label of Sales Tax
                    this.lblSalesTax.Text = String.Format("Sales Tax ({0:0}%):", salesTaxrate * 100);

                    //Parameter of Financial class

                    // The interest rate per period, monthly payments means the rate period of annual per 12
                    monthlyRate = (this.nudAnnualInterestRate.Value / 100) / 12;

                    //The total number of payment periods in the annuity. For example: 2 years = 2 * 12 (payment periods)
                    numberOfPaymentPeriods = Decimal.ToInt32(this.nudNoOfYears.Value) * 12;

                    //Present value = the value need to be paid in the future. 
                    //An example is a customer finances a car, the loan amount is the present value
                    presentValue = salesQuote.AmountDue;

                    //Monthly Payment (Currency)
                    this.lblMonthlyPayment_Display.Text = Financial.GetPayment(monthlyRate, numberOfPaymentPeriods, presentValue).ToString("C2");
                }
            }
            
        }

        /// <summary>
        /// Handles the click event of the Reset button
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            string message = "Do you want to reset the form?";
            string caption = "Reset Form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, icon, MessageBoxDefaultButton.Button2);

            switch (result)
            {
                case DialogResult.Yes:
                    InitialStateForm();
                    this.errorProvider.SetError(this.txtVehicleSalesPrice, "");
                    this.errorProvider.SetError(this.txtTradeInValue, "");
                    break;
                default:
                    this.txtVehicleSalesPrice.Focus();
                    break;
            }
        }

        /// <summary>
        /// Handles the Text changed event of txtVehicleSalePrice and txtTradeinValue
        /// </summary>
        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            //Clear the output labels in the Summary section of the form.
            this.lblVehicleSalePrice_SummaryDisplay.Text = "";
            this.lblOptions_Display.Text = "";
            this.lblSubTotal_Display.Text = "";
            this.lblSalesTax_Display.Text = "";
            this.lblTotal_Display.Text = "";
            this.lblTradein_Display.Text = "";
            this.lblAmountDue_Display.Text = "";

            //Clear the Monthly Payment Label in the Finance section of the form.
            this.lblMonthlyPayment_Display.Text = "";

            //The created Sales Quote is removed from memory.
            salesQuoteValue = null;         
        }
        
        /// <summary>
        /// Handles the CheckStateChanged event of check boxes, radio buttons, 
        /// numeric up down control
        /// </summary>
        private void CheckStateChanged(object sender, EventArgs e)
        {
            //If sales quote has been created, the summary
            //and monthly payment output will be updated to reflect the input change.
            if (salesQuoteValue != null)
            {
                this.btnCalculateQuote.PerformClick();
            }
        }
    }
}