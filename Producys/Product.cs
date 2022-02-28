namespace Products
{
    public abstract class Product : IPay
    {
        public string Description { get; set; }


        public int Id { get; set; }

        public decimal Price { get; set; }

        public int Tax { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {Description} - {Price} - {Tax}";
        }

        
    }
}
