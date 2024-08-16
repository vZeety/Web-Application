using Microsoft.AspNetCore.Mvc;
using Resume.Models;
using System.Diagnostics;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetInfo()
        {
            List<Info> aListOfInfo;
            IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

            DBGateway aGateway = new DBGateway(configuration);

            aListOfInfo = aGateway.GetInfo();
            ViewBag.ListOfInfo = aListOfInfo;

            return View();
        }


        public IActionResult GetEducation()
        {
            List<Education> aListOfEducation;
            IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

            DBGateway aGateway = new DBGateway(configuration);

            aListOfEducation = aGateway.GetEducation();
            ViewBag.ListOfEducation = aListOfEducation;

            return View();
        }

        public IActionResult GetSkills()
        {
            List<Skills> aListOfSkill;
            IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

            DBGateway aGateway = new DBGateway(configuration);

            aListOfSkill = aGateway.GetSkills();
            ViewBag.ListOfSkill = aListOfSkill;

            return View();
        }


        public IActionResult GetExperience()
        {
            List<Experience> aListOfExperience;
            IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

            DBGateway aGateway = new DBGateway(configuration);

            aListOfExperience = aGateway.GetExperience();
            ViewBag.ListOfExperience = aListOfExperience;

            return View();
        }




    }
}
