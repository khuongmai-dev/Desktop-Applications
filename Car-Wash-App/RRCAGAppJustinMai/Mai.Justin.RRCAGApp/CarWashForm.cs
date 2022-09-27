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
using ACE.BIT.ADEV.CarWash;

namespace Mai.Justin.RRCAGApp
{
    public partial class CarWashForm : ACE.BIT.ADEV.Forms.CarWashForm
    {
        private BindingList<Package> packages;
        //private Package selectedPackage;
        private List<Fragrance> fragrances;
        private BindingSource bindingSource;
        private BindingSource fragranceSource;

        private string selectedFragrance;
        public CarWashForm()
        {
            InitializeComponent();
            InitialStateForm();

            //Subcribe to events
            populateFragrance();

            populatePackagesData();

            lstInterior.Items.Clear();
            
            this.Load += CarWashForm_Load;
        }     

        private void InitialStateForm()
        {         
            this.Text = "Car Wash";
            this.mnuToolsGenerateInvoice.Enabled = false;
            this.Width = 412;
            this.Height = 468;
            this.cboFragrance.Sorted = true;
        }

        private void populatePackagesData()
        {
            //selectedFragrance = this.fragranceSource.Current.ToString();

            string[] tokens = this.fragranceSource.Current.ToString().Split(',');
            selectedFragrance = "Fragrance -" + tokens[0];

            this.packages = new BindingList<Package>();

            this.packages.Add(new Package()
            {
                Description = "Standard",
                Price = 7.50m,
                InteriorServices = new List<string>() { selectedFragrance },
                ExteriorSerivces = new List<string>() { "Hand Wash" }
            });

            this.packages.Add(new Package()
            {
                Description = "Deluxe",
                Price = 15.00m,
                InteriorServices = new List<string>() { selectedFragrance, "Shampoo Carpets" },
                ExteriorSerivces = new List<string>() { "Hand Wash", "Hand Wax" }
            });

            this.packages.Add(new Package()
            {
                Description = "Executive",
                Price = 35.00m,
                InteriorServices = new List<string>() { selectedFragrance, "Shampoo Carpets", "Shampoo Upholstery" },
                ExteriorSerivces = new List<string>() { "Hand Wash", "Hand Wax", "Wheel Polish" }
            });

            this.packages.Add(new Package()
            {
                Description = "Luxury",
                Price = 55.00m,
                InteriorServices = new List<string>() { selectedFragrance, "Shampoo Carpets", "Shampoo Upholstery", "Interior Protection Coat" },
                ExteriorSerivces = new List<string>() { "Hand Wash", "Hand Wax", "Wheel Polish", "Detail Engine Compartment" }
            });

            this.bindingSource = new BindingSource();
            this.bindingSource.DataSource = this.packages;
        }

        private void populateFragrance()
        {
            string filepath = "fragrances.txt";

            FileStream fileStream;
            fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);

            StreamReader fileReader;
            fileReader = new StreamReader(fileStream);

            this.fragrances = new List<Fragrance>();
            try
            {
                Fragrance fragrance;
                while (fileReader.Peek() != -1)
                {
                    string record = fileReader.ReadLine();
                    char[] delimiters = { ',' };
                    string[] fields = record.Split(delimiters);

                    string description = fields[((int)Fragrance.FieldIndex.Description)];
                    decimal price = decimal.Parse(fields[(int)Fragrance.FieldIndex.Price]);

                    fragrance = new Fragrance(description, price);
                    fragrances.Add(fragrance);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("There was an error reading from {0}.", filepath);
            }

            this.fragranceSource = new BindingSource();
            this.fragranceSource.DataSource = this.fragrances;

            fileReader.Close();
        }

        private void BindControl()
        {
            this.cboPackage.DataSource = this.bindingSource;
            this.cboPackage.DisplayMember = "Description";

            Binding InteriorBind = new Binding("DataSource", this.bindingSource, "InteriorServices");
            this.lstInterior.DataBindings.Add(InteriorBind);

            Binding exteriorBind = new Binding("DataSource", this.bindingSource, "ExteriorSerivces");
            this.lstExterior.DataBindings.Add(exteriorBind);

            this.cboFragrance.DataSource = this.fragranceSource;
            this.cboFragrance.DisplayMember = "Description";
            this.cboFragrance.Text = selectedFragrance;

            Binding labelSubtotal = new Binding("Text", this.bindingSource, "Price");
            this.lblSubtotal.DataBindings.Add(labelSubtotal);
            string[] tokens = this.fragranceSource.Current.ToString().Split(',');
            decimal subtotal = decimal.Parse(lblSubtotal.Text) + decimal.Parse(tokens[1]);
            decimal pst = 0m;
            decimal gst = subtotal * 0.05m;
            decimal total = subtotal + pst + gst;
            this.lblGoodsAndServicesTax.Text = gst.ToString();
            this.lblProvincialSalesTax.Text = pst.ToString();
            this.lblTotal.Text = total.ToString();
        }

        private void CarWashForm_Load(object sender, EventArgs e)
        {
            //this.lstInterior.Items.Clear();
            BindControl();
            this.cboPackage.SelectedIndex = -1;
            this.cboFragrance.SelectedIndex = 4;
        }
    }
}
