using DomainLayer.Entity;

namespace AppointmentTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Appointments appointments = new Appointments();
			int actual = appointments.Id;
			int expected = appointments.Id;
			Assert.AreEqual(expected, actual);
		}
	}
}