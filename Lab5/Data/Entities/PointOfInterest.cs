using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class PointOfInterest
    {
        private PointOfInterest()
        {

        }

        public Guid Id { get; private set; }

        public String Description { get; private set; }

        public String Location { get; private set; }

        public String Name { get; private set; }

        public static PointOfInterest Create(String description, String location, String name)
        {
            var instance = new PointOfInterest { Id = Guid.NewGuid() };
            instance.Update(description, location, name);
            return instance;
        }

        public void Update(string description, String location, string name)
        {
            this.Description = description;
            this.Location = location;
            this.Name = name;
        }
    }
}
