namespace Products
{
    public class Invoice : IPay
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public float Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal GetValueToPay()
        {
            return Price * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"{Id} - {Description}" +
                $"\n\tQuantity.......: {Quantity:N2}" +
                $"\n\tPrice.......: {Price:N2}" +
                $"\n\tValue.......: {GetValueToPay:N2}";

        }

        internal void AddProduct(Product product)
        {
            return Description += Quantity += Price; 
        }
    }
}
