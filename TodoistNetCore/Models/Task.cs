using System;
using System.Collections.Generic;

namespace TodoistNetCore.Models
{
	public class Task
	{
		public int Id { get; set; }
		public int ProjectId { get; set; }
		public string Content { get; set; }
		public bool Completed { get; set; }
		public List<int> LabelIds { get; set; }
		public int Order { get; set; }
		public int Indent { get; set; }
		public int Priority { get; set; }
		public DueObject Due { get; set; }
		public string Url { get; set; }
		public int CommentCount { get; set; }
		
	}
}