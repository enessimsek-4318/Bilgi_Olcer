using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bilgi_Olcer_BLL.Absract;
using Entities;
using Bilgi_Olcer_WebAPI.Models;

namespace Bilgi_Olcer_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Question>>> GetQuestions()
        {
            return _adminService.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> GetQuestion(string id)
        {
            return _adminService.Get(id);
        }
        [HttpPost]
        public async Task<ActionResult<Question>> AddQuestion(CreateModel model)
        {
            Question question = new Question();
            
            return _adminService.Create(model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestion(string id)
        {
            return _adminService.Delete(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> EditQuestion(string id, EditModel model)
        {

        }

    }
}
