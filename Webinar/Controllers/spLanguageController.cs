using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Webinar.Models;
using System;

namespace Aptex.Controllers
{
    public class spLanguageController : BaseController<spLanguage>
    {
        public spLanguageController(IUnitOfWork unitOfWork) : base(unitOfWork) { }


        [HttpGet("calc/{id}")]
        public string Calc(string id)
        {
            return id + DateTime.Now.ToString();
        }
    }
}
