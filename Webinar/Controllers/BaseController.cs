using Arch.EntityFrameworkCore.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aptex.Controllers
{
    [Route("api/[controller]")]
    public class BaseController<T> : ControllerBase where T : class
    {
        private readonly IUnitOfWork uow;

        public BaseController(IUnitOfWork unitOfWork)
        {
            uow = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<T> Get()
        {
            var _storage = uow.GetRepository<T>();
            return _storage.GetAll();
        }

        [HttpGet("{id}")]
        public T Get(Guid id)
        {
            var _storage = uow.GetRepository<T>();
            return _storage.Find(id);
        }

        [HttpPost("{id}")]
        public void Post(Guid id, [FromBody]T value)
        {
            var _storage = uow.GetRepository<T>();
            _storage.Insert(value);
        }
    }
}
