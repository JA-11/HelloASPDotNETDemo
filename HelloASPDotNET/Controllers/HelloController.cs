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
            string html = "<form method='post' action='/helloworld/form'>" +
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

        [HttpPost]
        [Route("form")]
        public IActionResult Display(string name = "World", string language = "english")
        {
            return Content(CreateMessage(name,language));
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
