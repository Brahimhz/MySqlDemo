using MySqlDemo.Models;

namespace MySqlDemo.AppServices.Dto
{
    public class CarOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BrandOutput Brand { get; set; }

        public ColorOutput Color { get; set; }
    }
}
