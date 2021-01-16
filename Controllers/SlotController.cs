using AutoMapper;
using WebData.Models;
using WebData.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using WebService.Services;

namespace BookMyShow.Controllers
{
    [Route("api/slots")]
    [ApiController]
    public class SlotController : ControllerBase
    {
        private readonly ISlotService Slots;
        public SlotController(ISlotService slots)
        {
            Slots = slots;
        }

        [HttpGet("{id}")]
        public List<Slot> GetSlots(int id)
        {

            var slots = Slots.GetSlotsById(id);
            return slots;
        }
    }
}
