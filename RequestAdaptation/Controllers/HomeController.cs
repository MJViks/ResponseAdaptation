using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace RequestAdaptation.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        
        // POST: api/Home
        [HttpPost]
        public string Post([FromBody] Home value)
        {
            if (value.Text == string.Empty || value.Email == string.Empty || value.Name == string.Empty || value.Software == string.Empty)
                return "Одно или несколько полей не заполнены!";
            else
                return "Заявка успешно зарегестрированна!";
        }
    }
    public class Home
    {
        public string Name { get; set; }
        public string Software { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
    }
}
