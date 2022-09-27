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
    /// A quote for the sale of a vehicle
    /// </summary>
    public class SalesQuote
    {
        /// <summary>
        /// Occurs when the price of the vehicle being quoted on changes.
        /// </summary>
        public event EventHandler VehiclePriceChanged;

        /// <summary>
        ///  Occurs when the amount for the trade in vehicle changes.
        /// </summary>
        public event EventHandler TradeInAmountChanged;

        /// <summary>
        /// Occurs when the chosen accessories change.
        /// </summary>
        public event EventHandler AccessoriesChosenChanged;

        /// <summary>
        ///  Occurs when the chosen exterior finish changes.
        /// </summary>
        public event EventHandler ExteriorFinishChosenChanged;

        private decimal vehicleSalePrice;
        private decimal tradeInAmount;
        private decimal salesTaxRate;
        private Accessories accessoriesChosen;
        private ExteriorFinish exteriorFinishChosen;

        /// <summary>
        /// Property of vehicleSalePrice
        /// <param name="value">Sets the sale price of the vehicle</param>
        /// </summary>
        /// <return>The selling price of the vehicle being sold in decimal</return>
        public decimal VehicleSalePrice
        {
            get
            {
                return this.vehicleSalePrice;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, "The value cannot be less than or equal to 0");
                if (this.vehicleSalePrice != value)
                {
                    this.vehicleSalePrice = value;

                    OnVehiclePriceChanged();
                }
            }
        }

        /// <summary>
        /// Property of tradeInAmount
        /// <param name="= value">The selling price of the vehicle</param>
        /// </summary>
        /// <return>The amount for the trade in of customer's vehicle in decimal</return>
        public decimal TradeInAmount
        {
            get
            {
                return this.tradeInAmount;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), value, "The value cannot be less than 0");

                if (this.tradeInAmount != value)
                {
                    this.tradeInAmount = value;

                    OnTradeInAmountChanged();
                }

            }
        }

        /// <summary>
        /// Property of the accessories chosen
        /// <param name="value">The chosen accessories</param>
        /// </summary>
        /// <return>The value of the chosen accessories</return>
        public Accessories AccessoriesChosen
        {
            get
            {
                return this.accessoriesChosen;
            }
            set
            {
                if (value < (Accessories)0 || value > (Accessories)7)
                {
                    throw new System.ComponentModel.InvalidEnumArgumentException("The value is an invalid enumeration value");
                }

                if(this.accessoriesChosen != value)
                {
                    this.accessoriesChosen = value;

                    OnAccessoriesChosenChanged();
                }
            }
        }

        /// <summary>
        /// Property of the exterior chosen
        /// <param name="value">The chosen exterior finish</param>
        /// </summary>
        /// <return>The value of the chosen exterior finish</return>
        public ExteriorFinish ExteriorFinishChosen
        {
            get
            {
                return this.exteriorFinishChosen;
            }
            set
            {
                if (value < (ExteriorFinish)0 || value > (ExteriorFinish)3)
                {
                    throw new System.ComponentModel.InvalidEnumArgumentException("The value is an invalid enumeration value");
                }

                if(this.exteriorFinishChosen != value)
                {
                    this.exteriorFinishChosen = value;

                    OnExteriorFinishChosenChanged();
                }
            }
        }

        /// <summary>
        /// Property of AccessoryCost
        /// </summary>
        /// <return>
        /// Stereo System - $505.05
        /// Leather Interior - $1010.10
        /// Computer Navigation - $1515.15
        /// StereoAndLeather - 1515.15
        /// StereoAndNavigation - 2020.20
        /// LeatherAndNavigation - 2525.25
        /// All - 3030.30
        /// None - 0
        /// </return>
        public decimal AccessoryCost
        {
            get
            {
                //using switch statement with expression is accessoriesChosen
                switch (accessoriesChosen)
                {
                    //accessoriesChosen = Accessories.StereoSystem, and then return the value to 505.05
                    case Accessories.StereoSystem:
                        return 505.05m;

                    //accessoriesChosen = Accessories.LeatherInterior, and then return the value to 1010.10
                    case Accessories.LeatherInterior:
                        return 1010.10m;

                    //accessoriesChosen = Accessories.ComputerNavigation, and then return the value of to 1515.15
                    case Accessories.ComputerNavigation:
                        return 1515.15m;

                    //accessoriesChosen = Accessories.StereoAndLeather, and then return the value of to
                    //the sum of Stereo and Leather = 505.05 + 1010.10
                    case Accessories.StereoAndLeather:
                        return 505.05m + 1010.10m;

                    //accessoriesChosen = Accessories.StereoNavigation, and then return the value of to
                    //the sum of Stereo and Navigation = 505.05 + 1515.15
                    case Accessories.StereoAndNavigation:
                        return 505.05m + 1515.15m;

                    //accessoriesChosen = Accessories.LeatherAndNavigation, and then return the value of to
                    //the sum of Leather and Navigation = 1010.10 + 1515.15
                    case Accessories.LeatherAndNavigation:
                        return 1010.10m + 1515.15m;

                    //accessoriesChosen = Accessories.All, and then return the value of to
                    //the sum of Leather, Stereo and Navigation = 505.05 + 1010.10 + 1515.15
                    case Accessories.All:
                        return 505.05m + 1010.10m + 1515.15m;

                    //None of Accessories is chosen, no case match, return the value to 0
                    default:
                        return 0;
                }
            }
        }

        /// <summary>
        /// Property of exterior finish chosen
        /// </summary>
        /// <returns>
        /// Standard - $202.02
        /// Pearlied - $404.04
        /// Custom - $606.06
        /// None - 0
        /// </returns>
        public decimal FinishCost
        {
            get
            {
                //using switch statement with expression is exteriorFinishChosen
                switch (exteriorFinishChosen)
                {
                    //exteriorFinishChosen = ExteriorFinish.Standard, and then return the value to 202.02
                    case ExteriorFinish.Standard:
                        return 202.02m;

                    //exteriorFinishChosen = ExteriorFinish.Pearlized, and then return the value to 404.04
                    case ExteriorFinish.Pearlized:
                        return 404.04m;

                    //exteriorFinishChosen = ExteriorFinish.Custom, and then return the value to 606.06
                    case ExteriorFinish.Custom:
                        return 606.06m;

                    //None of Exterior Finish is chosen, no case match, return the value to 0
                    default:
                        return 0;
                }
            }
        }
        /// <summary>
        /// The sum of Accessories and Exterior Finish costs
        /// Rounded to two decimal places
        /// </summary>
        /// <returns>Returns the sum of the cost of accessories chosen and the chose of the exterior finish chosen</returns>
        public decimal TotalOptions
        {
            get
            {
                return Math.Round(AccessoryCost + FinishCost, 2);
            }
        }

        /// <summary>
        /// Sum of the vehicle's sale prices, accessories and exterior finish costs
        /// Rounded to two decimal places
        /// </summary>
        /// <returns>Returns the sum of the vehicle's sale price, accessories and exterior finish costs</returns>
        public decimal SubTotal
        {
            get
            {
                return Math.Round(VehicleSalePrice + AccessoryCost + FinishCost, 2);
            }
        }

        /// <summary>
        /// The amount of tax to charge based on the subtotal
        /// Rounded to two decimal places
        /// <returns>Returns the amount of tax to charge</returns>
        /// </summary>
        public decimal SalesTax
        {
            get
            {
                return Math.Round(salesTaxRate * SubTotal, 2);
            }
        }

        /// <summary>
        /// The sum of the subtotal and taxes
        /// Rounded to two decimal places
        /// </summary>
        /// <returns>Returns the sum of the subtotal and taxes</returns>
        public decimal Total
        {
            get
            {
                return Math.Round(SubTotal + SalesTax, 2);
            }
        }

        /// <summary>
        /// The difference of the total and trade-in amount
        /// Rounded to two decimal places
        /// </summary>
        /// <returns> Returns the difference of the total and trade-in amount</returns>
        public decimal AmountDue
        {
            get
            {
                return Math.Round(Total - TradeInAmount, 2);
            }
        }

        /// <summary>
        /// Create a method to set values of vehicle Sale Price, Trade-in amount, sales Tax Rate, accessories chosen, exterior finish chosen
        /// This method to recall in constructors to avoid the duplications of the code
        /// </summary>
        /// <param name="vehicleSalePrice">The selling price of the vehicle being sold</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle</param>
        /// <param name="accessoriesChosen">The value of the chosen accessories</param>
        /// <param name="exteriorFinishChosen">The value of the chosen exterior finish</param>
        private void Initialize_Constructor(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)
        {
            if (vehicleSalePrice <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(vehicleSalePrice), vehicleSalePrice, "The argument cannot be less than or equal to 0");
            }
            if (tradeInAmount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(tradeInAmount), tradeInAmount, "The argument cannot be less than 0");
            }
            if (salesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(salesTaxRate), salesTaxRate, "The argument cannot be less than 0");
            }
            if (salesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(salesTaxRate), salesTaxRate, "The argument cannot be greater than 1");
            }
            if ((int)accessoriesChosen < (int)Accessories.StereoSystem || (int)accessoriesChosen > (int)Accessories.None)
            {
                throw new System.ComponentModel.InvalidEnumArgumentException("The argument is an invalid enumeration value");
            }
            if ((int)exteriorFinishChosen < (int)ExteriorFinish.Standard || (int)exteriorFinishChosen > (int)ExteriorFinish.None)
            {
                throw new System.ComponentModel.InvalidEnumArgumentException("The argument is an invalid enumeration value");
            }
            this.vehicleSalePrice = vehicleSalePrice;
            this.tradeInAmount = tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Initializes an instance of Sale Quote class with a specified vehicle sale price, Trade in amount,
        /// sale tax rate, accessories chosen and exterior finish by calling Initialize_Constructor method
        /// </summary>
        /// <param name="vehicleSalePrice">The selling price of the vehicle being sold</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle</param>
        /// <param name="accessoriesChosen">The value of the chosen accessories</param>
        /// <param name="exteriorFinishChosen">The value of the chosen exterior finish</param>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)
        {
            Initialize_Constructor(vehicleSalePrice, tradeInAmount, salesTaxRate, accessoriesChosen, exteriorFinishChosen);
        }

        /// <summary>
        /// Initializes an instance of Sale Quote class with a specified vehicle sale price, trade in amount,
        /// and the sale tax rate by calling the Initialize_Constructor method
        /// </summary>
        /// <param name="vehicleSalePrice">The selling price of the vehicle being sold</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle</param>
        /// <param name="accessoriesChosen">The value of the chosen accessories is set to 0</param>
        /// <param name="exteriorFinishChosen">The value of the chosen exterior finish is set to 0</param>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate)
        {
            Initialize_Constructor(vehicleSalePrice, tradeInAmount, salesTaxRate, Accessories.None, ExteriorFinish.None);
        }

        /// <summary>
        /// Raises the VehiclePriceChanged event.
        /// </summary>
        protected virtual void OnVehiclePriceChanged()
        {
            if(VehiclePriceChanged != null)
            {
                VehiclePriceChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the TradeInAmountChanged event.
        /// </summary>
        protected virtual void OnTradeInAmountChanged()
        {
            if(TradeInAmountChanged !=null)
            {
                TradeInAmountChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the AccessoriesChosenChanged event.
        /// </summary>
        protected virtual void OnAccessoriesChosenChanged()
        {
            if(AccessoriesChosenChanged != null)
            {
                AccessoriesChosenChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the ExteriorFinishChosenChanged event.
        /// </summary>
        protected virtual void OnExteriorFinishChosenChanged()
        {
            if(ExteriorFinishChosenChanged != null)
            {
                ExteriorFinishChosenChanged(this, new EventArgs());
            }
        }
    }
}