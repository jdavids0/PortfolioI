// this is a service that brings in your MVC functionality
using Microsoft.AspNetCore.Mvc;
// be sure to use your own project's namespace!
namespace PortfolioI.Controllers;

    // class name must == file name
    public class HelloController: Controller
    {
        [HttpGet]
        [Route("")]

        public string Index()
        {
            return "This is my index!";
        }

        [HttpGet("projects")]

        public string Projects()
        {
            return "These are my projects:";
        }

        [HttpGet("contact")]

        public string Contact()
        {
            return "This is my contact:";
        }
    }