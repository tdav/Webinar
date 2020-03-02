using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using Microsoft.EntityFrameworkCore;
using Webinar.Models;

namespace Webinar.Controllers
{
    /// <summary>
    /// Test
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILogger<ValuesController> _logger;

        // 1. IRepositoryFactory used for readonly scenario;
        // 2. IUnitOfWork used for read/write scenario;
        // 3. IUnitOfWork<TContext> used for multiple databases scenario;
        public ValuesController(IUnitOfWork unitOfWork, ILogger<ValuesController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        // GET api/values
        [HttpGet]
        public Task<List<tbWebinar>> GetAsync()
        {
            return _unitOfWork.GetRepository<tbWebinar>().GetAll().ToListAsync();
        }


        // GET api/values/Page/5/10
        [HttpGet("Page/{pageIndex}/{pageSize}")]
        public Task<IPagedList<tbWebinar>> Get(int pageIndex, int pageSize)
        {
            // projection
            var items = _unitOfWork.GetRepository<tbWebinar>().GetPagedList();

            return _unitOfWork.GetRepository<tbWebinar>().GetPagedListAsync(pageIndex: pageIndex, pageSize: pageSize);
        }
 
        // GET api/values/4
        [HttpGet("{id}")]
        public ValueTask<tbWebinar> Get(int id)
        { 
            _logger.LogInformation("demo about first or default with include");
            return _unitOfWork.GetRepository<tbWebinar>().FindAsync(id);
        }

        // POST api/values
        [HttpPost]
        public Task Post([FromBody]tbWebinar value)
        {
            var repo = _unitOfWork.GetRepository<tbWebinar>();
            repo.Insert(value);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
