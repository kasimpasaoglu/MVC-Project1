using AutoMapper;
using Database;
using DMO;
public class StudentRepo : IStudentRepo
{
    private Db _context;
    private IMapper _mapper;
    public StudentRepo(IMapper mapper, Db context)
    {
        _context = context;
        _mapper = mapper;
    }
    public bool AddStudent(DTO.Student model)
    {
        var dmoModel = _mapper.Map<Student>(model);
        _context.Add(dmoModel);
        int result = _context.SaveChanges();
        if (result > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<Student> GetAll()
    {
        throw new NotImplementedException();
    }
}

public interface IStudentRepo
{
    public bool AddStudent(DTO.Student model);
    public List<Student> GetAll();
}