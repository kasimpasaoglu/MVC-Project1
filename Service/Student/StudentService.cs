using AutoMapper;
using DTO;

public class StudentService : IStudentService
{
    private IStudentRepo _repo;
    public StudentService(IStudentRepo repo)
    {
        _repo = repo;

    }
    public bool AddStudent(Student model)
    {

        return _repo.AddStudent(model);
    }

    public List<Student> GetAll()
    {
        throw new NotImplementedException();
    }
}

public interface IStudentService
{
    public bool AddStudent(Student model);
    public List<Student> GetAll();
}