using Business.Business.StockRecordRepo;
using Data.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Presentation.DTO;
using System;
using System.Collections.Generic;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    public class StockRecordController : Controller
    {
        private readonly IStockRecord _repository;

        public StockRecordController(IStockRecord repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<StockRecord> Get()
        { 
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public StockRecord Get(Guid id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]CreateStockRecord s)
        {
            var entity = StockRecord.Create(s.Date, s.StartPrice, s.EndPrice, s.Owner);
            _repository.Add(entity);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]UpdateStockRecord s)
        {
            var entity = _repository.GetById(id);
            entity.Update(s.Date, s.StartPrice, s.EndPrice, s.Owner);
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