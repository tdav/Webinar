using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plg.Test1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestAController : Controller
    {
        [HttpGet]
        public IEnumerable<T1ItemV1> Get()
        {
            return new[] { new T1ItemV1("Item 1", 1), new T1ItemV1("Item 2", 2), new T1ItemV1("Item 3", 3) };
        }
    }

    public class T1ItemV1
    {
        public string Title { get; set; }
        public int Position { get; set; }

        public T1ItemV1(string title, int position)
        {
            this.Title = title;
            this.Position = position;
        }
    }
}
