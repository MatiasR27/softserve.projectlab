namespace API.Models;

    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public Guid CategoryId { get; set; }
        public string Description { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public decimal Price { get; set; }
        public int Stock { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

}