using Microsoft.EntityFrameworkCore;
using ReservationsAPI.Models;
using System.Collections.Generic;

namespace ReservationsAPI.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Reservation> Employees { get; set; }
	}
}
