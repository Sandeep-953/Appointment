using DomainLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interface_Repository
{
	public interface IViewAppointmentStatistics
	{
		int GetTotalAppointments();
		int GetTotalConfirmedAppointments();
		int GetTotalClosedAppointments();
		int GetTotalCancelledAppointments();

		List<AppointmentStatistics> GetAllAppointments();

	}
}
