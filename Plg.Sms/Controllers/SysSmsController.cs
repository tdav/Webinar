using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plg.Test1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SysSmsController : Controller
    {
        [HttpGet]
        public IEnumerable<T1ItemV2> Get()
        {
            return new[] { new T1ItemV2("Item 1", 1), new T1ItemV2("Item 2", 2), new T1ItemV2("Item 3", 3) };
        }
    }

    public class T1ItemV2
    {
        public string Title { get; set; }
        public int Position { get; set; }

        public T1ItemV2(string title, int position)
        {
            this.Title = title;
            this.Position = position;
        }
    }
}
