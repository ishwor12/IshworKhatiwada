using System.Diagnostics;
using IshworPortfolioWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace IshworPortfolioWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var personalInfo = new
            {
                Name = "Ishwor Khatiwada",
                Title = "Software Developer (.NET C#)",
                Phone = "0224514583",
                Email = "me.ishworkhatiwada2016@gmail.com",
                Address = "51 Tranmere road fairfield, Hamilton",
                Summary = "Passionate .NET and Dynamics 365 Developer with 4+ years of experience delivering scalable, reliable business solutions using C#, ASP.NET Core, Web API, and SQL Server. Skilled in Agile teamwork, API integration, and continuous improvement. Currently pursuing a Master of Applied IT at Wintec, blending strong technical foundations with a people-centred, solution-focused mindset built through both software and New Zealand retail experience."
            };

            ViewBag.PersonalInfo = personalInfo;
            return View();
        }

        public IActionResult About()
        {
            var skills = new List<Skill>
        {
            new Skill
            {
                Category = "Technical Skills",
                Skills = new List<string>
                {
                    "C#", ".NET Core", "ASP.NET MVC", "Web API", "SQL Server",
                    "Entity Framework", "Azure", "Dynamics 365", "React", "jQuery",
                    "HTML5", "CSS3", "Bootstrap", "Git", "Azure DevOps"
                }
            },
            new Skill
            {
                Category = "Professional Skills",
                Skills = new List<string>
                {
                    "Customer & Communication", "Teamwork & Culture Fit",
                    "Initiative", "Honesty", "Punctual", "Agile Methodology",
                    "Problem Solving", "Mentoring"
                }
            }
        };

            return View(skills);
        }

        public IActionResult Experience()
        {
            var experiences = new List<Experience>
        {
            new Experience
            {
                Title = "Supermarket Assistant",
                Company = "New World, Terapa",
                Location = "Hamilton",
                Period = "July - Currently Working",
                Responsibilities = new List<string>
                {
                    "Supported daily operations including stock control, merchandising, and customer inquiries.",
                    "Recognised for teamwork and reliability across diverse shift teams.",
                    "Strengthened communication and problem-solving skills through daily customer interactions."
                },
                KeyLearnings = new List<string>
                {
                    "Strong interpersonal and teamwork skills developed in fast-paced, multicultural environments.",
                    "Practical understanding of NZ workplace expectations — punctuality, service quality, and collaboration."
                }
            },
            new Experience
            {
                Title = "Associate Software Developer (.NET)",
                Company = "Dogma Group",
                Location = "Kathmandu, Nepal",
                Period = "May 2024 - Feb 2025",
                Responsibilities = new List<string>
                {
                    "Developed and maintained scalable web applications using ASP.NET MVC and C#.",
                    "Designed and integrated RESTful APIs and relational databases (MS SQL).",
                    "Improved system reliability and maintainability through design-pattern-based architecture.",
                    "Mentored junior developers on code standards and Agile best practices."
                }
            },
            new Experience
            {
                Title = "Junior Software Developer",
                Company = "InfoDevelopers Pvt. Ltd",
                Location = "Lalitpur, Nepal",
                Period = "Aug 2022 - May 2024",
                Responsibilities = new List<string>
                {
                    "Built and optimised full-stack solutions using .NET Core and SQL Server.",
                    "Improved query performance through stored procedure and database optimisation.",
                    "Collaborated within cross-functional Agile teams to deliver enterprise web application.",
                    "Implemented REST APIs and integrated third-party services like Mobile payment gateways."
                }
            }
        };

            return View(experiences);
        }

        public IActionResult Projects()
        {
            var projects = new List<Project>
        {
            new Project
            {
                Name = "Wealth – Merchant Banking System",
                Role = "Junior Software Developer / Intern",
                Architecture = "Repository Design Pattern, Structure: MVC",
                Technologies = new List<string> { "C#", ".NET Core", "MS SQL", "Azure", "DevOps", "GitHub", "jQuery" },
                Contributions = new List<string>
                {
                    "Developed modules for client management, portfolio tracking, and compliance.",
                    "Implemented secure data access and scalability using Repository design pattern.",
                    "Collaborated in Agile sprints with cross-functional teams to ensure on-time delivery."
                }
            },
            new Project
            {
                Name = "Mutual Fund Management System",
                Role = "Junior Software Developer",
                Architecture = "Generic Repository, Onion, Web API",
                Technologies = new List<string> { "C#", ".NET Web API", "React", "MS SQL", "Swagger", "Postman", "AzureDevOps" },
                Contributions = new List<string>
                {
                    "Designed and implemented backend Web APIs and database layers using the Onion architecture.",
                    "Developed React-based interfaces for fund management and performance visualisation.",
                    "Integrated the solution into Agile delivery pipelines via Azure DevOps."
                }
            }
        };

            return View(projects);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
