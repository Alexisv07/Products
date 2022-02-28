using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class VariablePriceProduct : Product
    {
        public int Measurement { get; set; }
     
        public float Quantity { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)Quantity * Price;
        } 


        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tVariablePriceProduct:{Price:C2} " +
                $"\n\tPticeTotal : {Price:C2}" +
                $"\n\tValue to Pay: {GetValueToPay}";
        }

        
    }
}
