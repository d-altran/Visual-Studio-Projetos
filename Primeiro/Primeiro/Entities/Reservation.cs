using System;
using System.Collections.Generic;
using System.Text;
using Primeiro.Entities.Exceptions;

namespace Primeiro.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Check-out date must be after chek-in date!");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {

            DateTime now = DateTime.Now;

            if (checkin < now || checkin < now)
            {
               throw new DomainException("Error in reservation: Reservation dates for update must be futures.");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Error in reservation: Check-out date must be after chek-in date!");
            }

            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Room "
            + RoomNumber
            + ", check-in: "
            + Checkin.ToString("dd/MM/yyyy")
            + ", check-out: "
            + Checkout.ToString("dd/MM/yyyy")
            + ", "
            + Duration()
            + " nights. ";

        }
    }
}
