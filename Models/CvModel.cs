namespace OnlineCV.Models
{
    public class CvModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string IDNumber { get; set; }
        public string DOB { get; set; }
        public string ContactInfo { get; set; }
        public string Email { get; set; }
        public string Summary { get; set; }
        public List<Education> Education { get; set; }
        public List<WorkExperience> WorkExperience { get; set; }
        public List<string> Skills { get; set; }
        public List<Project> Projects { get; set; }
        public List<string> Interests { get; set; }
        public List<Reference> References { get; set; }
    }

    public class Education
    {
        public string Degree { get; set; }
        public string Institution { get; set; }
        public int YearCompleted { get; set; }
        public string Description { get; set; }
    }

    public class WorkExperience
    {
        public string Role { get; set; }
        public string Company { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }

    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Technologies { get; set; }
        public string Link { get; set; }
    }

    public class Reference
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Contact { get; set; }
    }
}
