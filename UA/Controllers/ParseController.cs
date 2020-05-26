using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UA.Models;

namespace UA.Controllers
{
    [Route("parse")]
    public class ParseController : Controller
    {
        [HttpGet("ua")]
        public ParsedUA ParseUa(string ua) 
        {
            ParsedUA parsed = new ParsedUA();
            // парсинг ua

            return parsed;
        }
    }
}
