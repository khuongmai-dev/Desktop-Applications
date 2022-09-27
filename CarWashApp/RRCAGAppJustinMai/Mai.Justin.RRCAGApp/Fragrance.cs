using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mai.Justin.RRCAGApp
{
    public class Fragrance
    {
        public enum FieldIndex
        {
            Description,
            Price
        }
        public string Description
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }
        public Fragrance()
        {
        }
        public Fragrance(string description, decimal price)
        {
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Description, Price);
        }
    }
}
