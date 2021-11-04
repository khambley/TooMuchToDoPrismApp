using System;
using System.Collections.Generic;
using System.Text;

namespace TooMuchToDoPrismApp.Models
{
	public class TodoItem
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public bool Completed { get; set; }
		public DateTime DueDate { get; set; }

	}
}
