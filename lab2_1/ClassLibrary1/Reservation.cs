using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Reservation
    {
        public Guid Id { get; private set; }

        public TimeSpan StartDate { get; private set; } 

        public TimeSpan EndDate { get; private set; }

        public int NrOfPeople { get; private set; }

        public Reservation(TimeSpan startDate, TimeSpan endDate, int nrOfPeople)
        {
            if (isValid())
            {
                Id = Guid.NewGuid();
                StartDate = StartDate;
                EndDate = endDate;
                NrOfPeople = nrOfPeople;
            }
            else
                throw new BusinessException("Invalid start date or end date!");
        }

        private Boolean isValid()
        {
            return (StartDate.Hours >= 10 && StartDate.Hours <= 22)
                &&
                (EndDate.Hours >= 10 && EndDate.Hours <= 22);
        }
    }
}
