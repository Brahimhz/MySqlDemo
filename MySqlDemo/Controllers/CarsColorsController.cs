using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlDemo.Models;
using MySqlDemo.Persistence.Repository;

namespace MySqlDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsColorsController : ControllerBase
    {
        private readonly IGenericRepository<CarsColors> _repository;

        public CarsColorsController(IGenericRepository<CarsColors> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetView()
        {
            return Ok(await _repository.GetAll());
        }
    }
}
