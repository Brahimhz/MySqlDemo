using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlDemo.AppService;

namespace MySqlDemo.Controllers
{
    [ApiController]
    public class CRUDController<T, TGetResource, TSetResource> : ControllerBase
        where T : class
    {
        private readonly IGenericAppService<T, TGetResource, TSetResource> _appService;

        public CRUDController(IGenericAppService<T, TGetResource, TSetResource> appService)
        {
            _appService = appService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var result = await _appService.GetById(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {

            var result = await _appService.GetAll();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(TSetResource input)
        {
            return Ok(await _appService.Add(input));
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _appService.GetById(id);

            if (result == null)
                return NotFound();

            return Ok(_appService.Remove(id));

        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id,TSetResource input)
        {
            return Ok(await _appService.Update(id, input));
        }
    }
}
