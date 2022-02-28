namespace Products
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal GetValueToPay()
        {
            decimal payroll = 0; 
            foreach (Product product in Products)
            {
                Console.Write(product);
                payroll += product.GetValueToPay();
                    
            }
            return payroll - (payroll * (decimal)Discount);
        }




        //public override string ToString()
        //{
        //    return $"{base.ToString()}" +
        //        $"\n\tComposedProduct:{Price:C2} " +
        //        $"\n\tDiscount : {Discount:P2}" +
        //        $"\n\tValue to Pay: {GetValueToPay}";
        //}



    }
}
