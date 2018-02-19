using System;

namespace TodoistNetCore.Models
{
	public class Comment
	{
		public int Id { get; set; }
		public int TaskId { get; set; }
		public Task Task { get; set; }
		public int ProjectId { get; set; }
		public Project Project { get; set; }
		public DateTime Posted { get; set; }
		public string Content { get; set; }
		public Attachment Attachment { get; set; }
	}
}