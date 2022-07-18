using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("pizza")]
public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public double Price { get; set; }
        //public Pizza(string Name, string Img, string Description, double price)
        //{
        //    this.Name = Name;
        //    this.Img = Img;
        //    this.Description = Description;
        //    Price = price;
        //}
    }

