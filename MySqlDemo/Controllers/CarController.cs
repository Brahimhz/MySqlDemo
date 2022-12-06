using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlDemo.AppService;
using MySqlDemo.AppServices.Dto;
using MySqlDemo.Models;

namespace MySqlDemo.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class CarController : CRUDController<Car, CarOutput, CarInput>
    {
        public CarController(IGenericAppService<Car, CarOutput, CarInput> appService) : base(appService)
        {
        }
    }
}
