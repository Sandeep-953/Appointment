using DataLayer.DataAccess;
using DomainLayer.Entity;
using DomainLayer.Interface_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
	public class AppointmentStatisticsRepo : IViewAppointmentStatistics
	{
		private AppointmentDbContext db = new AppointmentDbContext();

		//Return Total appointments
		public int GetTotalAppointments()
		{
			return db.appointmentStatistics.Count();

		}

		//Return Total Cancelled appointemnts
		public int GetTotalCancelledAppointments()
		{
			return (from cancelledAppointments in db.appointmentStatistics
					where cancelledAppointments.appointmentStatus.Equals("Cancelled")
					select cancelledAppointments).Count();
		}

		//Return total closed appointments
		public int GetTotalClosedAppointments()
		{
			return (from ClosedAppointments in db.appointmentStatistics
					where ClosedAppointments.appointmentStatus.Equals("Closed")
					select ClosedAppointments).Count();
		}

		//return total confirmed appointments
		public int GetTotalConfirmedAppointments()
		{
			return (from confirmedAppointments in db.appointmentStatistics
					where confirmedAppointments.appointmentStatus.Equals("Confirmed")
					select confirmedAppointments).Count();
		}

		public List<AppointmentStatistics> GetAllAppointments()
		{
			return db.appointmentStatistics.ToList();
		}

	}
}
