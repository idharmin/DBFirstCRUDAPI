namespace DBFirstCRUDAPI.Services
{
    public interface ITeacherService
    {
        List<Student> GetAllTeachers();
        List<Student> Save(Student student);
        List<Student> Update(Student student);
        List<Student> Delete(int Sid);
    }
}
