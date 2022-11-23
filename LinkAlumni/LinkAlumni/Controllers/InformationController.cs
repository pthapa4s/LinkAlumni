using Alumni.Data;
using LinkAlumni.Models.Domain;
using LinkAlumni.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using DocumentFormat.OpenXml.Spreadsheet;

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
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(PrivateViewModel model)
        {
            var currentUsername = "semoadmin";
            var currentPassword = "semopassword";

            if(currentUsername == model.UserName && currentPassword == model.Password)
            {
                var alumni = await mvcDemoDbContext.AlumniInformation.ToListAsync();
                return View("IndexAuthorized", alumni);
            }
            else
            {
                return View();
            }
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
            return RedirectToAction("Submit", "Information");

        }
        [HttpGet]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Csv()
        {
            var builder = new StringBuilder();
            List<AddAlumniViewModel> alumnis = (from alumni in this.mvcDemoDbContext.AlumniInformation.ToList()
                                    select new AddAlumniViewModel
                                    {
                                        FirstName = alumni.FirstName,
                                        LastName = alumni.LastName,
                                        City = alumni.City,
                                        PhoneNumber = alumni.PhoneNumber,
                                        Email =alumni.Email
                                    }).ToList<AddAlumniViewModel>();

            builder.AppendLine("First Name, Last Name, City, Phone Number, Email");

            foreach (var alumni in alumnis)
            {
                builder.AppendLine($"{alumni.FirstName}, {alumni.LastName},{alumni.City}, {alumni.PhoneNumber}, {alumni.Email}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "Alumni.csv");
        } 
        
        [HttpPost]
        public IActionResult CsvForEducation()
        {
            var builder = new StringBuilder();
            List<AddAlumniViewModel> alumnis = (from alumni in this.mvcDemoDbContext.AlumniInformation.ToList()
                                    select new AddAlumniViewModel
                                    {
                                        FirstName = alumni.FirstName,
                                        LastName = alumni.LastName,
                                        DegreeReceived = alumni.DegreeReceived,
                                        Major = alumni.Major,
                                        GraduationYear = alumni.GraduationYear,
                                        PostGraduateDegree = alumni.PostGraduateDegree,
                                        Certificates = alumni.Certificates
                                    }).ToList<AddAlumniViewModel>();

            builder.AppendLine("First Name, Last Name, Degree, Major,Graduation Year, Post Graduate Degrees, Certificates");

            foreach (var alumni in alumnis)
            {
                builder.AppendLine($"{alumni.FirstName}, {alumni.LastName}, {alumni.DegreeReceived},{alumni.Major}, {alumni.GraduationYear}, {alumni.PostGraduateDegree}, {alumni.Certificates}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "AlumniEducation.csv");
        }
        [HttpPost]
        public IActionResult CsvForJob()
        {
            var builder = new StringBuilder();
            List<AddAlumniViewModel> alumnis = (from alumni in this.mvcDemoDbContext.AlumniInformation.ToList()
                                    select new AddAlumniViewModel
                                    {
                                        FirstName = alumni.FirstName,
                                        LastName = alumni.LastName,
                                        CurrentJobTitle = alumni.CurrentJobTitle,
                                        CompanyName = alumni.CompanyName,
                                        CompanyAddress = alumni.CompanyAddress
                                    }).ToList<AddAlumniViewModel>();

            builder.AppendLine("First Name, Last Name, CurrentJob, Company Name, Company Address");

            foreach (var alumni in alumnis)
            {
                builder.AppendLine($"{alumni.FirstName}, {alumni.LastName}, {alumni.CurrentJobTitle},{alumni.CompanyName}, {alumni.CompanyAddress}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "AlumniJob.csv");
        }   
        [HttpPost]
        public IActionResult CsvForNews()
        {
            var builder = new StringBuilder();
            List<AddAlumniViewModel> alumnis = (from alumni in this.mvcDemoDbContext.AlumniInformation.ToList()
                                    select new AddAlumniViewModel
                                    {
                                        FirstName = alumni.FirstName,
                                        LastName = alumni.LastName,
                                        Notes = alumni.Notes
                                        
                                    }).ToList<AddAlumniViewModel>();

            builder.AppendLine("First Name, Last Name, News");

            foreach (var alumni in alumnis)
            {
                builder.AppendLine($"{alumni.FirstName}, {alumni.LastName}, {alumni.Notes}");
            }

            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "AlumniNews.csv");
        }

        


    }
}
