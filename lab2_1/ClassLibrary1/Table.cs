using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Table
    {
        public Guid ID { get; private set; }

        public int Capacity { get; set; }

        public List<Reservation> Reservations { get; private set; }

        public Table(int capacity)
        {
            if (capacity > 0)
                this.Capacity = capacity;
            else
                throw new BusinessException("Invalid capacity!");
        }

        public void AddReservation(Reservation reservation)
        {
            if (isValidReservation(reservation))
                this.Reservations.Add(reservation);
            else
                throw new BusinessException("Table already has a reservation in that time table!");
        }

        public List<Reservation> GetReservationsInTimespan(TimeSpan start, TimeSpan end)
        {
            return this.Reservations.FindAll(r => 
            r.StartDate.CompareTo(start) >= 0 && r.EndDate.CompareTo(end) <= 0);
        }

        public Boolean isValidReservation(Reservation reservation)
        {
            return Reservations.TrueForAll(r => isValid(r, reservation)) 
                && (this.Capacity >= reservation.NrOfPeople);
        }

        private Boolean isValid(Reservation thiss, Reservation that)
        {
            return (thiss.StartDate.CompareTo(that.EndDate) >= 0) ||
                (thiss.EndDate.CompareTo(that.StartDate) <= 0);
        }
    }
}
