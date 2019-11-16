using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestAdaptation.Models;

namespace RequestAdaptation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : Controller
    {
        [HttpPost]
        public string Post([FromBody] Feedback value)
        {
            if (value.Text == string.Empty ||
                value.Email == string.Empty ||
                value.Name == string.Empty ||
                value.Software == string.Empty)
                return "Одно или несколько полей не заполнены!";
            else
            {

                return DBActions.Feedback_Insert(value.Text, value.Software, value.Name, value.Email);
            }
        }
    }
}