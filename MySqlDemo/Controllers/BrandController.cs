using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlDemo.AppService;
using MySqlDemo.AppServices.Dto;
using MySqlDemo.Models;

namespace MySqlDemo.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class BrandController : CRUDController<Brand, BrandOutput, BrandInput>
    {
        public BrandController(IGenericAppService<Brand, BrandOutput, BrandInput> appService) : base(appService)
        {
        }
    }
}
