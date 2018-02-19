using System;

namespace TodoistNetCore.Models
{
	public class DueObject
	{
		public DateTime Date { get; set; }
		public bool Recurring { get; set; }
		public DateTime DateTime { get; set; }
		public string String { get; set; }
		public string Timezone { get; set; }
	}
}