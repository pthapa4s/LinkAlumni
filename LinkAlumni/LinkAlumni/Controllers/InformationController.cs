using Alumni.Data;
using LinkAlumni.Models.Domain;
using LinkAlumni.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LinkAlumni.Controllers
{
    public class InformationController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;

        public InformationController(MVCDemoDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var alumni = await mvcDemoDbContext.AlumniInformation.ToListAsync();
            return View(alumni);

        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddAlumniViewModel addAlumniRequest)
        {
            var alumni = new AlumniInformation()
            {
                Id = Guid.NewGuid(),
                FirstName = addAlumniRequest.FirstName,
                LastName = addAlumniRequest.LastName,
                City = addAlumniRequest.City,
                State = addAlumniRequest.State,
                PhoneNumber = addAlumniRequest.PhoneNumber,
                Email = addAlumniRequest.Email,
                GraduationYear = addAlumniRequest.GraduationYear,
                DegreeReceived = addAlumniRequest.DegreeReceived,
                Major = addAlumniRequest.Major,
                PostGraduateDegree = addAlumniRequest.PostGraduateDegree,
                Certificates = addAlumniRequest.Certificates,
                Internships = addAlumniRequest.Internships,
                CurrentJobTitle = addAlumniRequest.CurrentJobTitle,
                CompanyName = addAlumniRequest.CompanyName,
                CompanyAddress = addAlumniRequest.CompanyAddress,
                Notes = addAlumniRequest.Notes
            };
            await mvcDemoDbContext.AlumniInformation.AddAsync(alumni);
            await mvcDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Add");

        }
    }
}
