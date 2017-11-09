using Business.Business.StockModelRepo;
using Data.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Presentation.DTO;
using System;
using System.Collections.Generic;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    public class StockModelController : Controller
    {
        private readonly IStockModel _repository;

        public StockModelController(IStockModel repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<StockModel> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public StockModel Get(Guid id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]CreateStock s)
        {
            var entity = StockModel.Create(s.Name, s.Code, s.StockRecords);
            _repository.Add(entity);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]UpdateStock s)
        {
            var entity = _repository.GetById(id);
            entity.Update(s.Name, s.Code, s.StockRecords);
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