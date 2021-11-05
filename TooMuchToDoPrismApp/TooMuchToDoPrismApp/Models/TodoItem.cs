using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TooMuchToDoPrismApp.Models
{
	public class TodoItem
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Title { get; set; }
		public bool Completed { get; set; }
		public DateTime DueDate { get; set; }

	}
}
