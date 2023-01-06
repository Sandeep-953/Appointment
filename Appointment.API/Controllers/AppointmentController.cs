using DataLayer.Repository;
using DomainLayer.Entity;
using DomainLayer.Interface_Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appointment.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AppointmentController : ControllerBase
	{
		//Appointment
		private IAppointment repo = new AppointmentRepositoy();
		[HttpGet]
		public IActionResult GetAllAppointment()
		{
			return Ok(repo.ViewAppointment());
		}

		//Appointment statics
		private IViewAppointmentStatistics iRepo = new AppointmentStatisticsRepo();

		[HttpGet]
		[Route("Total")]
		public int GetAllAppointments()
		{
			return iRepo.GetTotalAppointments();
		}

		[HttpGet]
		[Route("Confirmed")]
		public int GetConfirmedAppointments()
		{
			return iRepo.GetTotalConfirmedAppointments();
		}

		[HttpGet]
		[Route("Closed")]
		public int GetClosedAppointments()
		{
			return iRepo.GetTotalClosedAppointments();
		}

		[HttpGet]
		[Route("Cancelled")]
		public int GetCancelledAppointments()
		{
			return iRepo.GetTotalCancelledAppointments();
		}
		[HttpGet]
		[Route("All Appointments List")]
		public List<AppointmentStatistics> GetAllAppointmentsList()
		{
			return iRepo.GetAllAppointments();
		}



	}
}
