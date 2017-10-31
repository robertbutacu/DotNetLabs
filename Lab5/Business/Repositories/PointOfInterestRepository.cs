using Data.Context;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Repositories
{
    public class PointOfInterestRepository : IPointOfInterestRepository
    {
        private readonly IDatabaseService _databaseService;

        public PointOfInterestRepository(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public void Add(PointOfInterest pointOfInterest)
        {
            _databaseService.PointsOfInterest.Add(pointOfInterest);
            _databaseService.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var pof = GetById(id);
            _databaseService.PointsOfInterest.Remove(pof);
            _databaseService.SaveChanges();
        }

        public void Edit(PointOfInterest pointOfInterest)
        {
            _databaseService.PointsOfInterest.Update(pointOfInterest);
            _databaseService.SaveChanges();

        }

        public IReadOnlyList<PointOfInterest> GetAll()
        {
            return _databaseService.PointsOfInterest.ToList();
        }

        public PointOfInterest GetById(Guid id)
        {
            return _databaseService.PointsOfInterest.FirstOrDefault(e => e.Id == id);
        }
    }
}
