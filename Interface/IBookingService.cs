﻿using GASSBOOKING_WEBSITE.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GASSBOOKING_WEBSITE.Interface
{
    public interface IBookingService
    {
        Task<bool> AddBookingAsync(Booking booking);
        Task<IEnumerable<Booking>> GetBookingHistoryAsync(string username);
        List<Booking> GetAllBookings();
        Task<bool> AcceptBookingAsync(int bookingId, int staffRegId);
        Task<IEnumerable<Booking>> GetAcceptedBookingsByStaffAsync(int staffRegId);
        Task<bool> MarkBookingAsDeliveredAsync(int bookingId, int staffRegId);

    }
}