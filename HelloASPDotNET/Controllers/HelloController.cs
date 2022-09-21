using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                  "<input type='text' name='name' />" +
                  "<select name='language'>" +
                  "<option value='english'>English</option>" +
                  "<option value='spanish'>Spanish</option>" +
                  "<option value='french'>French</option>" +
                  "<option value='german'>German</option>" +
                  "<option value='italian'>Italian</option> <select/>" +
                  "<input type='submit' value='Greet Me!' />" +
                  "</form>";

            return Content(html, "text/html");
        }


        [HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }


        public static string CreateMessage(string name, string language)
        {
            if (language == "spanish")
            {
                return $"Hola {name}!";
            }
            else if (language == "french")
            {
                return $"Bonjour {name}!";
            }
            else if (language == "german")
            {
                return $"Hallo {name}!";
            }
            else if (language == "italian")
            {
                return $"Ciao {name}!";
            }
            else
            {
                return $"Hello {name}!";
            }
        }

    }
}
