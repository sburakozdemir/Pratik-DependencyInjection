using Microsoft.AspNetCore.Mvc;
using Pratik_DependencyInjection.Models;

namespace Pratik_DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly Classroom _classroom;

        // Constructor Injection ile Classroom nesnesi alınıyor
        public ClassRoomController(ITeacher teacher)
        {
            _classroom = new Classroom(teacher);
        }

        [HttpGet("teacher-info")]
        public IActionResult GetTeacherInfo()
        {
            // Öğretmenin bilgilerini API olarak döndür
            var info = _classroom.GetTeacherInfo();
            return Ok(info);
        }
    }
}
