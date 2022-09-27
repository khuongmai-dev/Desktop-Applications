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
    /// This static class contains functionality that includes financial functions.
    /// </summary>
    public static class Financial
    {
        /// <summary>
        /// Returns the payment amount for an annuity based on periodic, fixed payments and a fixed interest rate.
        /// </summary>
        /// <param name="rate"> the interest rate per period</param>
        /// <param name="numberOfPaymentPeriods">the total number of payment periods in the annuity</param>
        /// <param name="presentValue">the present value (or lump sum) that a series of payments to be paid in the future is worth now</param>
        /// <returns></returns>
        public static decimal GetPayment(decimal rate, int numberOfPaymentPeriods, decimal presentValue)
        {
            if (rate < 0)
                throw new ArgumentOutOfRangeException(nameof(rate), rate, "The argument cannot be less than 0");
            if (rate > 1)
                throw new ArgumentOutOfRangeException(nameof(rate), rate, "The argument cannot be greater than 1");
            if (numberOfPaymentPeriods <= 0)
                throw new ArgumentOutOfRangeException(nameof(numberOfPaymentPeriods), numberOfPaymentPeriods, "The argument cannot be less than or equal to 0");
            if (presentValue <= 0)
                throw new ArgumentOutOfRangeException(nameof(presentValue), presentValue, "The argument cannot be less than or equal to 0");
            decimal futureValue = 0;
            decimal type = 0;
            decimal payment = 0;
            if (rate == 0)
                payment = presentValue / numberOfPaymentPeriods;
            else
                payment = rate * (futureValue + presentValue * (decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods)) / (((decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods) - 1) * (1 + rate * type));

            return Math.Round(payment, 2);
        }
    }
}