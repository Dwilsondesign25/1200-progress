﻿using LSC.RestaurauntTableBookingApp.Core;
using Microsoft.EntityFrameworkCore;

namespace LSC.ResterauntTableBookingApp.Data
{
    public class RestaurantTableBookingDbContext:DbContext
    {
        public RestaurantTableBookingDbContext(DbContextOptions<RestaurantTableBookingDbContext> options) : base(options)
        { }
            public DbSet<Restaurant> Restaurant { get; set; }
            public DbSet<DiningTable> DiningTable { get; set; }
            public DbSet<Reservation> Reservation { get; set; }
            public DbSet<RestaurantBranch> RestaurantBranch { get; set; }
            public DbSet<TimeSlot> TimeSlot { get; set; }
            public DbSet<User> User { get; set; }


    }
    }

