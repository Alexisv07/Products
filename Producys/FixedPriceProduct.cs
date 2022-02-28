namespace Products
{
    public class FixedPriceProduct : Product
    {
        public decimal Price { get; set; }
        public override decimal GetValueToPay()
        {
            return Price;
        }

        public override string ToString()
        {
            return $"base.ToString()\n\tValue to Pay: {GetValueToPay}:C2";
        }
    }
}
