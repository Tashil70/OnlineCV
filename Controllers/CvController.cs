using Microsoft.AspNetCore.Mvc;
using OnlineCV.Models;
using System.Collections.Generic;

namespace OnlineCV.Controllers
{
    public class CvController : Controller
    {
        public IActionResult Index()
        {
            var model = new CvModel
            {
                Name = "Tashil Koseelan",
                Address = "Unit 2, Villa Marie, 59 Wilson Street, Fairland, Johannesburg",
                IDNumber = "0201095248088",
                DOB = "9 January 2002",
                ContactInfo = "063 684 1829",
                Email = "tashilkoseelan@gmail.com",
                Summary = "I am a driven and growth-minded 22-year-old with excellent practical skills. "
                        + "I am a licensed driver with my own car. I enjoy gym, music, travel, puzzles, and problem-solving. "
                        + "I am looking for part-time or vacation work while completing my university studies.",

                Education = new List<Education>
                {
                    new Education
                    {
                        Degree = "Matric",
                        Institution = "Trinityhouse High School",
                        YearCompleted = 2020,
                        Description = "Excelled in IT, Mathematics, and English."
                    },
                    new Education
                    {
                        Degree = "BSc Information & Knowledge Systems (Undergraduate)",
                        Institution = "University of Pretoria",
                        YearCompleted = 2022,
                        Description = "Studied briefly before switching to Varsity College."
                    },
                    new Education
                    {
                        Degree = "BSc Computer Science & Application Development (Undergraduate)",
                        Institution = "Varsity College",
                        YearCompleted = 2025,
                        Description = "Currently in my final year (third year), studying part-time with plans to pursue a Master's in Computer Science."
                    }
                },

                WorkExperience = new List<WorkExperience>
                {
                    new WorkExperience
                    {
                        Role = "Amanuensis",
                        Company = "Grantley College",
                        Duration = "Feb 2021 – Present",
                        Description = "Assisting students with exam accommodations and support."
                    },
                    new WorkExperience
                    {
                        Role = "Private Tutor",
                        Company = "Self-Employed",
                        Duration = "July 2021 – Present",
                        Description = "Tutoring IT and Mathematics students one-on-one. Available outside lessons via calls and WhatsApp to help students resolve issues quickly."
                    }
                },

                Skills = new List<string>
                {
                    "Adapt quickly to any environment",
                    "Enjoy challenges",
                    "Fast Learner",
                    "Problem-Solving",
                    "Works well under pressure",
                    "Java, Python, C++, HTML, SQL (Databases)",
                    "Computer literate (Microsoft Office, etc.)"
                },

                Projects = new List<Project>
                {
                    new Project
                    {
                        Name = "GitHub Repositories",
                        Description = "Collection of personal and academic projects demonstrating skills in Java, Python, and C++.",
                        Technologies = "Java, Python, C++, SQL",
                        Link = "https://github.com/Tashil70?tab=repositories"
                    }
                },

                Interests = new List<string>
                {
                    "Indoor Soccer",
                    "Gym",
                    "Rock Climbing",
                    "Yoga",
                    "Puzzles",
                    "Films"
                },

                References = new List<Reference>
                {
                    new Reference
                    {
                        Name = "Mrs. Thembelihle Precious",
                        Position = "Amanuensis - Grantley College",
                        Contact = "082 876 1024"
                    },
                    new Reference
                    {
                        Name = "Mr. Farone Eckstein",
                        Position = "Principal - Trinityhouse Randpark Ridge",
                        Contact = "011 794 4799"
                    }
                }
            };

            return View(model);
        }
    }
}
