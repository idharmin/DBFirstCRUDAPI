namespace DBFirstCRUDAPI.Services
{
    public class StudentService : IStudentService
    {
        SchoolContext _dbcontext;
        public StudentService(SchoolContext schoolContext)
        {
            _dbcontext = schoolContext;
        }
        public List<Student> Delete(int Sid)
        {
            var students = _dbcontext.Students.FromSqlRaw($"SP_insret_update_delete_students @action={"D"},@sid={Sid}").ToList();
            return students;
        }

        public List<Student> GetAllStudents()
        {
            var student = _dbcontext.Students.FromSqlRaw($"SP_get_students  @action = {"A"}").ToList();
            return student.ToList();
        }

        public List<Student> Save(Student student)
        {
            var students = _dbcontext.Students.FromSqlRaw($"SP_insret_update_delete_students @action={"I"},@SName={student.Sname},@Sstd={student.Sstd},@SStream={student.Sstream}").ToList();
            return students;
        }

        public List<Student> Update(Student student)
        {
            var students = _dbcontext.Students.FromSqlRaw($"SP_insret_update_delete_students @action={"U"},@SName={student.Sname},@Sstd={student.Sstd},@SStream={student.Sstream},@sid={student.Sid}").ToList();
            return students;
            //_dbcontext.Database.ExecuteSqlRaw($"SP_insret_update_delete_students @action={"U"},@SName={student.Sname},@Sstd={student.Sstd},@SStream={student.Sstream},@sid={student.Sid}");
            //var students = _dbcontext.Students.FromSqlRaw($"SP_get_students  @action = {"A"}").ToList();
            //return students;
        }


    }
}
