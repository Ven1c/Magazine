namespace Magazine.Domain
{
    public class Product
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ImageSrc { get; set;}
    }
}