﻿using Microsoft.EntityFrameworkCore;

namespace GameEventLog.Models
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        { }

        public DbSet<Event> Events { get; set; }
    }
}
