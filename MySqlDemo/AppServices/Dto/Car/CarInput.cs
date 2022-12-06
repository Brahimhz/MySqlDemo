using MySqlDemo.Models;

namespace MySqlDemo.AppServices.Dto
{
    public class CarInput
    {
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
    }
}
