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
using Mai.Justin.Business;
namespace Mai.Justin.Business
{
    /// <summary>
    /// Abstract class Invoice
    /// </summary>
    public abstract class Invoice
    {
        /// <summary>
        /// Occurs when the provincial sales tax rate of the Invoice changes.
        /// </summary>
        public event EventHandler ProvincialSalesTaxRateChanged;

        /// <summary>
        ///  Occurs when the goods and services tax rate of the Invoice changes.
        /// </summary>
        public event EventHandler GoodsAndServicesTaxRateChanged;

        private decimal provincialSalesTaxRate;
        private decimal goodsAndServicesTaxRate; 

        /// <summary>
        ///  Gets and sets the provincial sales tax rate.
        /// </summary>
        public decimal ProvincialSalesTaxRate
        {
            get
            {
                return this.provincialSalesTaxRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "The value cannot be less than 0");
                }
                if (value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "The value cannot be greater than 1");
                }

                if(this.provincialSalesTaxRate != value)
                {
                    this.provincialSalesTaxRate = value;

                    OnProvincialSalesTaxRateChanged();
                }
            }
        }

        /// <summary>
        /// Gets and sets the goods and services tax rate.
        /// </summary>
        public decimal GoodsAndServicesTaxRate
        {
            get
            {
                return this.goodsAndServicesTaxRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "The value cannot be less than 0");
                }
                if (value > 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, "The value cannot be greater than 1");
                }

                if(this.goodsAndServicesTaxRate != value)
                {
                    this.goodsAndServicesTaxRate = value;

                    OnGoodsAndServicesTaxRateChanged();
                }
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer
        /// </summary>
        public abstract decimal ProvincialSalesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer 
        /// </summary>
        public abstract decimal GoodsAndServicesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the subtotal of the Invoice.
        /// </summary>
        public abstract decimal SubTotal
        {
            get;
        }

        /// <summary>
        /// Gets the total of the Invoice. The total is the sum of the subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get
            {
                return Math.Round(SubTotal + ProvincialSalesTaxCharged + GoodsAndServicesTaxCharged, 2);
            }
        }

        /// <summary>
        /// Initializes an instance of Invoice with a provincial and goods and services tax rates.
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        public Invoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
        {
            if (provincialSalesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(provincialSalesTaxRate), provincialSalesTaxRate,
                    "The argument cannot be less than 0");
            }
            if (provincialSalesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(provincialSalesTaxRate), provincialSalesTaxRate,
                    "The argument cannot be greater than 1");
            }
            if (goodsAndServicesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(goodsAndServicesTaxRate), goodsAndServicesTaxRate,
                    "The argument cannot be less than 0");
            }
            if (goodsAndServicesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(goodsAndServicesTaxRate), goodsAndServicesTaxRate,
                    "The argument cannot be greater than 1");
            }
            this.provincialSalesTaxRate = provincialSalesTaxRate;
            this.goodsAndServicesTaxRate = goodsAndServicesTaxRate;
        }

        /// <summary>
        /// Raises the ProvincialSalesTaxRateChanged event.
        /// </summary>
        protected virtual void OnProvincialSalesTaxRateChanged()
        {
            if(ProvincialSalesTaxRateChanged != null)
            {
                ProvincialSalesTaxRateChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the GoodsAndServicesTaxRateChanged event.
        /// </summary>
        protected virtual void OnGoodsAndServicesTaxRateChanged()
        {
            if (GoodsAndServicesTaxRateChanged != null)
            {
                GoodsAndServicesTaxRateChanged(this, new EventArgs());
            }
        }
    }
}