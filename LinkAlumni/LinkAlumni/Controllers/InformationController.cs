using Alumni.Data;
using LinkAlumni.Models.Domain;
using LinkAlumni.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

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
            return RedirectToAction("Submit", "Information");

        }
        [HttpGet]
        public IActionResult Submit()
        {
            return View();
        }
        //[HttpGet]
        //public FileResult Export()
        //{
        //    string[] columnNames = new string[]
        //    {
        //        "First Name","Last Name", "City", "State", "Phone Number", "Email", "Graduation Year",
        //        "Degree Received", "Major", "Post Graduate Degrees", "Certificates", "Internships",
        //        "Current Job Ttitle", "Company Name", "Company Address", "Notes"

        //    };
        //    var alumnis = new AlumniList().EmpList;
        //    string csv = string.Empty;

        //    foreach (string columnName in columnNames){
        //        csv += columnName + ',';
        //    }
        //    csv += "\r\n";

        //    foreach (var alumni in alumnis)
        //    {
        //        csv += alumni.FirstName.Replace(",", ";") + ',';
        //        csv += alumni.LastName.Replace(",", ";") + ',';
        //        csv += alumni.City.Replace(",", ";") + ',';
        //        csv += alumni.State.Replace(",", ";") + ',';
        //        csv += alumni.PhoneNumber.Replace(",", ";") + ',';
        //        csv += alumni.Email.Replace(",", ";") + ',';
        //        csv += alumni.GraduationYear.Replace(",", ";") + ',';
        //        csv += alumni.DegreeReceived.Replace(",", ";") + ',';
        //        csv += alumni.Major.Replace(",", ";") + ',';
        //        csv += alumni.PostGrduateDegrees.Replace(",", ";") + ',';
        //        csv += alumni.Certificates.Replace(",", ";") + ',';
        //        csv += alumni.Internships.Replace(",", ";") + ',';
        //        csv += alumni.CurrentJobTitle.Replace(",", ";") + ',';
        //        csv += alumni.CompanyName.Replace(",", ";") + ',';
        //        csv += alumni.CopanyAddress.Replace(",", ";") + ',';
        //        csv += alumni.Notes.Replace(",", ";") + ',';

        //        csv += "\r\n";
        //    }
        //    byte[] bytes = Encoding.ASCII.GetBytes(csv);
        //    return File(bytes, "text/csv", "Alumni.csv");
        //}
    }
}
