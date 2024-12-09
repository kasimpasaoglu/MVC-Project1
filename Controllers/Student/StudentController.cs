using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VM;

public class StudentController : Controller
{
    private IMapper _mapper;
    private IStudentService _service;
    public StudentController(IMapper mapper, IStudentService service)
    {
        _mapper = mapper;
        _service = service;
    }

    [ServiceFilter(typeof(StudentActionFilter))]
    public IActionResult Add()
    {
        return View(new Student() { BirthDate = DateOnly.Parse("01.01.2000") });
    }
    [HttpPost]
    public IActionResult Add(Student model)
    {
        bool isAdded = _service.AddStudent(_mapper.Map<DTO.Student>(model));
        if (isAdded)
        {
            model.IsAdded = true;
        }
        else
        {
            model.IsAdded = false;
        }
        return View(model);
    }
    public IActionResult LoginRequired()
    {
        return View();
    }

    public IActionResult AdminRequired()
    {
        return View();
    }

    [ServiceFilter(typeof(StudentShowActionFilter))]
    public IActionResult Show()
    {
        return View();
    }
}