using AutoMapper;
using WebData.Business;
using WebData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Profiles
{
    public class BookMyShowProfiles: Profile
    {
        public BookMyShowProfiles()
        {
            CreateMap<Movie, MovieDb>();
            CreateMap<MovieDb, Movie>();
            CreateMap<Slot, SlotDb>();
            CreateMap<SlotDb, Slot>();
            CreateMap<Booking, BookingDb>();
            CreateMap<BookingDb, Booking>();
        }
    }
}
