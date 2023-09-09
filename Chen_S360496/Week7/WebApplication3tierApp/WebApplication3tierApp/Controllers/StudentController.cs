using _2DataAccessLayer.Services;
using _3BusinessLogicLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3tierApp.Models;

namespace WebApplication3tierApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class DepartmentController : BaseController
    {

        private readonly IDepartmentService _DepartmentService;
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(IDepartmentService DepartmentService, ILogger<DepartmentController> logger)
        {
            _DepartmentService = DepartmentService;
            _logger = logger;
        }

        [HttpGet("", Name = "GetAllDepartments")]
        public async Task<List<DepartmentDto>> GetAll()
        {
            var result = await _DepartmentService.GetAll();
            return result.Select(x => x.ToDepartmentDto()).ToList();
        }

        [HttpGet("{DepartmentId}", Name = "GetDepartment")]
        public async Task<DepartmentDto?> Get(int DepartmentId)
        {
            var result = await _DepartmentService.GetById(DepartmentId);
            return result?.ToDepartmentDto();
        }

        [HttpPost, Route("")]
        public async Task<int> Create([FromBody] DepartmentDto requestDto)
        {
            var DepartmentModel = requestDto.ToDepartmentModel();
            return await _DepartmentService.CreateDepartment(DepartmentModel);
        }

        [HttpPut, Route("update")]
        public async Task<IActionResult> Update([FromBody] DepartmentDto requestDto)
        {
            await _DepartmentService.UpdateDepartment(requestDto.ToDepartmentModel());
            return Ok();
        }

        [HttpDelete, Route("{DepartmentId}")]
        public async Task<IActionResult> Delete(int DepartmentId)
        {
            await _DepartmentService.DeleteDepartment(DepartmentId);
            return Ok();
        }
    }
}
