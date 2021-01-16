using AutoMapper;
using WebData.Business;
using WebData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebService.Services;

namespace BookMyShow.Controllers
{
    [Route("api/bookings")]
    [ApiController]
    public class BookingController : ControllerBase
    {

        private readonly IBookingService Bookings;
        
        public BookingController(IBookingService bookings)
        {
            Bookings = bookings;
        }

        [HttpGet]
        public List<Booking> GetBookings()
        {
            var bookings = Bookings.GetAllBookings();
            return bookings;
        }

        [HttpPost]
        public void AddBooking(BookingDb booking)
        {
            Bookings.AddBooking(booking);
        }
    }
}
