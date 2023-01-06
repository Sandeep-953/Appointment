namespace DomainLayer.Entity
{
	public class Appointments
	{
		public int Id { get; set; }
		public string PetName { get; set; }
		public DateTime Date { get; set; }
		//public TimeOnly Time { get; set; }
		public string Owner { get; set; }
		public string Gender { get; set; }
		public int Age { get; set; }
	}
}