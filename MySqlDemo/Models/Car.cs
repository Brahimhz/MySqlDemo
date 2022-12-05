using System.ComponentModel.DataAnnotations.Schema;

namespace MySqlDemo.Models
{
    [Table("Cars")]
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }

        public Color Color { get; set; }
        public int ColorId { get; set; }



    }
}
