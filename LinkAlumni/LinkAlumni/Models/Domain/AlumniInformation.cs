namespace LinkAlumni.Models.Domain
{
    public class AlumniInformation
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public int GraduationYear { get; set; }
        public string DegreeReceived { get; set; }
        public string Major { get; set; }
        public string PostGraduateDegree { get; set; }
        public string Certificates { get; set; }
        public string Internships { get; set; }
        public string CurrentJobTitle { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string Notes { get; set; }
    }
}
