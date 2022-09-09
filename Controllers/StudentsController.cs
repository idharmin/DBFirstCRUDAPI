namespace DBFirstCRUDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return _studentService.GetAllStudents();
        }
        [HttpPost]
        public List<Student> SaveStudent(Student student)
        {
            return _studentService.Save(student);
        }
        [HttpPut]
        public List<Student> UpdateStudent(Student student)
        {
            return _studentService.Update(student);
        }
        [HttpDelete]
        public List<Student> DeleteStudent(int Sid)
        {
            return _studentService.Delete(Sid);
        }
    }
}
