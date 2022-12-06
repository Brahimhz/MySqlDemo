using Microsoft.EntityFrameworkCore;

namespace MySqlDemo.Models
{
    [Keyless]
    public class CarsColors
    {
        public string Model { get; set; }
        public string ModelColor { get; set; }
    }
}
