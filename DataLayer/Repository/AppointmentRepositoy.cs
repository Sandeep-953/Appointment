using DataLayer.DataAccess;
using DomainLayer.Entity;
using DomainLayer.Interface_Repository;

namespace DataLayer.Repository
{
	public class AppointmentRepositoy : IAppointment

	{
		private AppointmentDbContext db = new AppointmentDbContext();

		public List<Appointments> ViewAppointment()

        {
            return db.appointmentP.ToList();
            
        }
}
}