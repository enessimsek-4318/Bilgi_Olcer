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
        public ActionResult<List<Question>> GetQuestions()
        {
            return _adminService.GetAll();
        }
        [HttpGet("{id}")]
        public ActionResult<Question> GetQuestion(int id)
        {
            return _adminService.Get(id);
        }
        //[HttpPost]
        //public async Task<ActionResult<Question>> AddQuestion(CreateModel model)
        //{
        //    Question question = new Question();

        //    return _adminService.Create(model);
        //}
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteQuestion(string id)
        //{
        //    return _adminService.Delete(id);
        //}
        //[HttpPut("{id}")]
        //public async Task<IActionResult> EditQuestion(string id, EditModel model)
        //{

        //}
        [HttpPut("{id}")]
        public ActionResult EditQuestion(string id, Question model)
        {
            if (id != model.Id.ToString())
            {
                return BadRequest();
            }
            var question = _adminService.Get(Convert.ToInt32(id));
            if (question != null)
            {
                question = model;
                _adminService.Edit(question);
                return Ok(question);
            }
            else
            {
                //Soru bulunamadı.
                return NotFound();
            }

        }
        [HttpPost]
        public ActionResult AddQuestion(Question model)
        {
            try
            {
                _adminService.Create(model);
            }
            catch (Exception)
            {

                return NotFound();
            }
            return Ok();
        }

    }
}
