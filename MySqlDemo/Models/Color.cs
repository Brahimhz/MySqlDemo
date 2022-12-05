using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySqlDemo.Models
{
    [Table("Colors")]

    public class Color
    {
        public Color()
        {
            Cars = new Collection<Car>();
        }
        public int Id { get; set; }
        public string ColorName { get; set; }
        public string ColorHex { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
