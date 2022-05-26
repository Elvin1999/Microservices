using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByNumber(int number)
        {
            return new ReservationDTO
            {
                Number = number,
                Amount = (new Random()).Next(1000),
                CheckInDate = DateTime.Now,
                CheckOutDate = DateTime.Now.AddDays(10),
                Id = (new Random()).Next(100)    ,
                 OrderDate = DateTime.Now.AddDays(-5),
            };
        }
    }
}
