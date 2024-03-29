﻿using Microsoft.AspNetCore.Mvc;
using RequestAdaptation.Models;


namespace RequestAdaptation.Controllers
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
            return DBActions.RequestASP_Insert(value.Text, value.Software, value.Name, value.Email);
        }
    }
 

}
