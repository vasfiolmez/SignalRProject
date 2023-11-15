﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalRApi.Entitylayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
        var values=_bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail=createBookingDto.Mail,
                Date=createBookingDto.Date,
                Name=createBookingDto.Name,
                PersonCpunt=createBookingDto.PersonCpunt,
                Phone=createBookingDto.Phone
            };
            _bookingService.TAdd(booking);
            return Ok("Rezervasyon Yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id) 
        {
            var values= _bookingService.TGetByID(id);
            _bookingService.TDelete(values);
            return Ok("Rezarvasyon Silindi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking update = new Booking()
            {

                Mail = updateBookingDto.Mail,
                Date = updateBookingDto.Date,
                Name = updateBookingDto.Name,
                PersonCpunt = updateBookingDto.PersonCpunt,
                Phone = updateBookingDto.Phone

            };
            _bookingService.TUpdate(update);
            return Ok("Rezarvasyon Güncellendi");
        }
        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id) 
        { 
        var value=_bookingService.TGetByID(id);
            return Ok(value);
        }
    }
}
