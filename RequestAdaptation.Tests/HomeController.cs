using Microsoft.AspNetCore.Mvc;


namespace RequestAdaptation.Tests
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        
        // POST: api/Home
        [HttpPost]
        public string Post([FromBody] Home value)
        {
            if (value.Text == string.Empty ||
                value.Email == string.Empty ||
                value.Name == string.Empty ||
                value.Software == string.Empty)
                return "Одно или несколько полей не заполнены!";
            return "";
        }
    }
 

}
