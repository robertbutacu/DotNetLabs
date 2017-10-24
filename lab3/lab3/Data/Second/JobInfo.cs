using System;
using System.Collections.Generic;
using System.Text;

namespace lab3.Data._2
{
    class JobInfo
    {
        public Guid Id { get; set; }
        public String Title { get; private set; }
        public int MinimumYearsOfExperience { get; private set; }
        public String Requirements { get; private set; }
        public Double Salary {get; private set; }

        public JobInfo(String title, int minYearsOfReq, String req, double salary)
        {
            if (minYearsOfReq < 0 || salary < 0)
                throw new ArgumentException("Invalid arguments");

            this.Id = Guid.NewGuid();
            this.Title = title;
            this.MinimumYearsOfExperience = minYearsOfReq;
            this.Requirements = req;
            this.Salary = salary;
        }
    }
}
