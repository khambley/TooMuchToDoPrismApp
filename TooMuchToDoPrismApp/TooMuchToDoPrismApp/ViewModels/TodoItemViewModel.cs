using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using TooMuchToDoPrismApp.Models;

namespace TooMuchToDoPrismApp.ViewModels
{
	// this class represents each item in the to-do list on the MainPage
	// it does not have an entire view of its own.
	// used to render an item in a template in a Listview
	public class TodoItemViewModel : BindableBase
	{
		public event EventHandler ItemStatusChanged;
		public TodoItem Item { get; private set; }
		public string _statusText => Item.Completed ? "Reactivate" : "Completed";
		
		public TodoItemViewModel(TodoItem item)
		{
			Item = item;
		}
	}
}
