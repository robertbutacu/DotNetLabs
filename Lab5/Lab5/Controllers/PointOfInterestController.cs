using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Repositories;
using Data.Entities;
using Lab5.DATATRANSFEROBJECT;

namespace Lab5.Controllers
{
    [Route("api/[controller]")]
    public class PointOfInterestController : Controller
    {
        private readonly IPointOfInterestRepository _repository;

        public PointOfInterestController(IPointOfInterestRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<PointOfInterest> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public PointOfInterest Get(Guid id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]CreatePointOfInterest pof)
        {
            var entity = PointOfInterest.Create(pof.Description, pof.Location, pof.Name);
            _repository.Add(entity);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]UpdatePointOfInterest pof)
        {
            var entity = _repository.GetById(id);
            entity.Update(pof.Description, pof.Location, pof.Name);
            // magic
            _repository.Edit(entity);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }
    }
}