using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject1
{
    class ReservationTests
    {
        [Fact]
        public void ShouldCreateReservation()
        {
            var validReservation = new Reservation(new TimeSpan(10, 5, 0), new TimeSpan(11,0, 5), 3);

            
        }

        [Fact]
        public void ShoultNotCreateReservation()
        {
            var invalidReservation = new Reservation(new TimeSpan(5, 5, 5), new TimeSpan(10, 10, 10), 10);

        }
    }
}
