using System.Diagnostics;
using AutoMapper;
using Database;
using DMO;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Project1.Controllers;

public class HomeController : Controller
{

    private IMapper _mapper;
    public HomeController(IMapper mapper)
    {

        _mapper = mapper;
    }
    public IActionResult Index()
    {
        return View();
    }
}
