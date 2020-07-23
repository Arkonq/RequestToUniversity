using System;

namespace Domain.Model
{
	public class Application /*(Заявка)*/
	{
		public int Id { get; set; }
		public string IIN { get; set; }
		public int Score { get; set; }
		public Profile Profile1 { get; set; }
		public Profile Profile2 { get; set; }
		public University University { get; set; }
	}
}
