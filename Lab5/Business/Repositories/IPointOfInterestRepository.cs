using Data.Entities;
using System;
using System.Collections.Generic;

namespace Business.Repositories
{
    public interface IPointOfInterestRepository
    {
        IReadOnlyList<PointOfInterest> GetAll();
        PointOfInterest GetById(Guid id);
        void Add(PointOfInterest todo);
        void Edit(PointOfInterest todo);
        void Delete(Guid id);
    }
}
