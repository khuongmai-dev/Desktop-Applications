/*
 * Name: Justin Mai
 * Program: Business Information Technology
 * Course: ADEV-2008 Programing 2
 * Created: 2022-01-25
 * Updated: 2022-01-30
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mai.Justin.Business
{
    /// <summary>
    /// The CarWashInvoice class derives from the Invoice class
    /// </summary>
    public class CarWashInvoice : Invoice
    {
        /// <summary>
        /// Occurs when the package cost changes.
        /// </summary>
        public event EventHandler PackageCostChanged;

        /// <summary>
        /// Occurs when the fragrance cost changes.
        /// </summary>
        public event EventHandler FragranceCostChanged;

        private decimal packageCost;
        private decimal fragranceCost;

        /// <summary>
        /// Gets and sets the amount charged for the chosen package.
        /// </summary>
        public decimal PackageCost
        {
            get
            {
                return this.packageCost;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, "The value cannot be less than 0");

                if(this.packageCost != value)
                {
                    this.packageCost = value;

                    OnPackageCostChanged();
                }
            }
        }

        /// <summary>
        /// Gets and sets the amount charged for the chosen fragrance.
        /// </summary>
        public decimal FragranceCost
        {
            get
            {
                return this.fragranceCost;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, "The value cannot be less than 0");

                if(this.fragranceCost != value)
                {
                    this.fragranceCost = value;

                    OnFragranceCostChanged();
                }    
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer. No provincial sales tax is charged for a car wash.
        /// </summary>
        public override decimal ProvincialSalesTaxCharged
        {
            get
            {
                return base.ProvincialSalesTaxRate = 0m;
            }
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer
        /// </summary>
        public override decimal GoodsAndServicesTaxCharged
        {
            get
            {
                return base.GoodsAndServicesTaxRate * SubTotal;
            }
        }

        /// <summary>
        /// Gets the subtotal of the Invoice. The subtotal is the sum of the package and fragrance cost.
        /// </summary>
        public override decimal SubTotal
        {
            get
            {
                return PackageCost + FragranceCost;
            }
        }

        /// <summary>
        /// Create a method to set values of vehicle packageCost, fragranceCost
        /// </summary>
        /// <param name="packageCost">The amount charged for the chosen package.</param>
        /// <param name="fragranceCost">The amount charged for the chosen fragrance.</param>
        private void Initialize_Constructor(decimal packageCost, decimal fragranceCost)
        {
            if (packageCost < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(packageCost), packageCost, "The argument cannot be less than to 0");
            }

            if (fragranceCost < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(fragranceCost), fragranceCost, "The argument cannot be less than to 0");
            }
            this.packageCost = packageCost;
            this.fragranceCost = fragranceCost;
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods and services tax rates
        /// </summary>
        /// <param name="provincialSalesTaxRate"></param>
        /// <param name="goodsAndServicesTaxRate"></param>
        /// <param name="packageCost">The amount charged for the chosen package = 0</param>
        /// <param name="fragranceCost">The amount charged for the chosen fragrance = 0</param>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate) : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            Initialize_Constructor(0m, 0m);
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods, services tax rate, package cost and fragrance cost
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">he rate of goods and services tax charged to a customer.</param>
        /// <param name="packageCost">The cost of the chosen package.</param>
        /// <param name="fragranceCost">The cost of the chosen fragrance.</param>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate, decimal packageCost, decimal fragranceCost) : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            Initialize_Constructor(packageCost, fragranceCost);
        }

        /// <summary>
        /// Raises the PackageCostChanged event.
        /// </summary>
        protected virtual void OnPackageCostChanged()
        {
            if(PackageCostChanged != null)
            {
                PackageCostChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the FragranceCostChanged event.
        /// </summary>
        protected virtual void OnFragranceCostChanged()
        {
            if(FragranceCostChanged != null)
            {
                FragranceCostChanged(this, new EventArgs());
            }
        }
    }
}