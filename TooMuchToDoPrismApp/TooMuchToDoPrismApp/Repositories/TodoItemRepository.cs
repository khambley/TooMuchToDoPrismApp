using System;
using System.Collections.Generic;
using System.Text;
using TooMuchToDoPrismApp.Models;
using System.Threading.Tasks;

namespace TooMuchToDoPrismApp.Repositories
{
	public class TodoItemRepository : ITodoItemRepository
	{
		// used to notify subscribers of a list that items have been added or updated.
		public event EventHandler<TodoItem> OnItemAdded;
		public event EventHandler<TodoItem> OnItemUpdated;

		public async Task<List<TodoItem>> GetItems()
		{
			return null; // Just to get it to build for now.
		}

		public async Task AddItem(TodoItem item)
		{

		}
		public async Task UpdateItem(TodoItem item)
		{

		}

		public async Task AddOrUpdate(TodoItem item)
		{
			if(item.Id == 0)
			{
				await AddItem(item);
			}
			else
			{
				await UpdateItem(item);
			}
		}

	}
}
