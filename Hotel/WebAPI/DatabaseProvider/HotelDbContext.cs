using Microsoft.EntityFrameworkCore;
using WebAPI.Domain.Entities;

namespace WebAPI.DatabaseProvider;

public class HotelDbContext : DbContext
{
    public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
    {
    }    
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
}