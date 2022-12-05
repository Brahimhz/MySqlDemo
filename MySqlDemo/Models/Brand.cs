using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySqlDemo.Models
{
    [Table("Brands")]
    public class Brand
    {
        public Brand()
        {
            Cars = new Collection<Car>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
