namespace Real_Estate_MVC.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        public bool HasPool { get; set; }
    }
}
