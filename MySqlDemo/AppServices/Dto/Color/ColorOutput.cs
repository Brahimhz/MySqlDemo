using MySqlDemo.Models;

namespace MySqlDemo.AppServices.Dto
{
    public class ColorOutput
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public string ColorHex { get; set; }
    }
}
