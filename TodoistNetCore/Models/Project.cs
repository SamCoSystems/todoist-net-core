using System;

namespace TodoistNetCore.Models
{
	public class Project
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Order { get; private set; }
		public int Indent { get; private set; }
		public int CommentCount { get; set; }
	}
}