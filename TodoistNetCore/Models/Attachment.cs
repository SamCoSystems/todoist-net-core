using System;

namespace TodoistNetCore.Models
{
	public abstract class Attachment
	{
		public string FileName { get; set; }
		public string FileType { get; set; }
		public string FileURL { get; set; }
		public string ResourceType { get; set; }
	}
}