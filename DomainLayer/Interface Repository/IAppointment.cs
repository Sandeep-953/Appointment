using DomainLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interface_Repository
{
	public interface IAppointment
	{
		List<Appointments> ViewAppointment();
	}
}
