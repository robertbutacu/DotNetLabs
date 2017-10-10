using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    class TableTests
    {
        [Fact]
        public void ShouldCreateReservation()
        {
            var table = new Table(10);

        }

        [Fact]
        public void ShouldNotCreateReservation()
        {
            var table = new Table(-1);
            

        }

        [Fact]
        public void ShouldAddReservation()
        {
            var table = new Table(10);
            var validReservation = new Reservation(new TimeSpan(10, 5, 0), new TimeSpan(11, 0, 5), 3);

            table.AddReservation(validReservation);
        }


        [Fact]
        public void ShouldNotAddReservationNotEnoughCapacity()
        {
            var table = new Table(2);
            var validReservation = new Reservation(new TimeSpan(10, 5, 0), new TimeSpan(11, 0, 5), 3);
        }

        [Fact]
        public void ShouldNotAddReservationOverlappingTimetables()
        {
            var table = new Table(10);
            var validReservation = new Reservation(new TimeSpan(10, 5, 0), new TimeSpan(11, 0, 5), 3);
            var validReservation2 = new Reservation(new TimeSpan(10, 5, 0), new TimeSpan(11, 0, 5), 3);

            table.AddReservation(validReservation);

            table.AddReservation(validReservation2);

        }
    }
}
