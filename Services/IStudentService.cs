namespace DBFirstCRUDAPI.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        List<Student> Save(Student student);
        List<Student> Update(Student student);
        List<Student> Delete(int Sid);
    }
}
