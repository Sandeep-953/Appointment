using DomainLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataAccess
{
	public class AppointmentDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Appointmentapp;Integrated Security=True;Pooling=False");
		}

		// tables
		public DbSet<Appointments> appointmentP { get; set; }
		public DbSet<AppointmentStatistics> appointmentStatistics { get; set; }
	}
}
