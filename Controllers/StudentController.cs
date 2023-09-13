using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyWebApp.Models;
using System.Net;
using System.Xml.Linq;

namespace MyWebApp.Controllers
{
    [Route ("Admin/Student")]
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();   
        public StudentController()
        { 
        //Tạo DS sv với 4 dữ liệu mẫu
            listStudents = new List<Student>()
            {
                new Student(){Id = 101, Name = "Văn Nghĩa",Branch = Branch.IT,
                    Gender = Gender.Male, IsRegular = true,
                    Address = "A1-2016", Email = "vn@g.com"},
                new Student(){Id = 102, Name = "Tiến Dương",Branch = Branch.BE,
                    Gender = Gender.Male, IsRegular = true,
                    Address = "A21-2017", Email = "td@g.com"},
                new Student(){Id = 103, Name = "Ngọc Anh",Branch = Branch.CE,
                    Gender = Gender.Female, IsRegular = false,
                    Address = "A41-2018", Email = "na@g.com"},
                new Student(){Id = 104, Name = "Hà Lan",Branch = Branch.IT,
                    Gender = Gender.Female, IsRegular = true,
                    Address = "A91-2019", Email = "hl@g.com"},
                new Student(){Id = 105, Name = "Vân Anh",Branch = Branch.EE,
                    Gender = Gender.Female, IsRegular = true,
                    Address = "A71-2020", Email = "va@g.com"}
            };
        }
        [HttpGet("List")]
        public IActionResult Index()
        {
            // trả về View Index.cshtml cùng Model là ds sv listStudents
            return View(listStudents);
        }
        [HttpGet("Add")]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            { 
                new SelectListItem {Text  = "IT",Value = "1"},
                new SelectListItem {Text  = "BE",Value = "2"},
                new SelectListItem {Text  = "CE",Value = "3"},
                new SelectListItem {Text  = "EE",Value = "4"},

            };
            return View();
        }
        [HttpPost("Add")]
        public IActionResult Create(Student s)
        {
            s.Id = listStudents.Last<Student>().Id+1;
            listStudents.Add(s);
            return View("Index",listStudents);
        }
    }
}
