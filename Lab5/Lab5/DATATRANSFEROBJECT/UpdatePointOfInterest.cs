using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.DATATRANSFEROBJECT
{
    public class UpdatePointOfInterest
    {
        public Guid Id { get; private set; }

        public String Description { get; private set; }

        public String Location { get; private set; }

        public String Name { get; private set; }
    }
}
