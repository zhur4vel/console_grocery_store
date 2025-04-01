namespace store_simulator
{
    public enum UnitType
    {
        PerItem,
        PerKg
    }

    public class Product
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public decimal Price { get; set; }

        public required string Category { get; set; }

        public UnitType Unit { get; set; }
    }
}
