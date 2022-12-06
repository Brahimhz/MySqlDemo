using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlDemo.AppService;
using MySqlDemo.AppServices.Dto;
using MySqlDemo.Models;

namespace MySqlDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : CRUDController<Color, ColorOutput, ColorInput>
    {
        public ColorController(IGenericAppService<Color, ColorOutput, ColorInput> appService) : base(appService)
        {
        }
    }
}
