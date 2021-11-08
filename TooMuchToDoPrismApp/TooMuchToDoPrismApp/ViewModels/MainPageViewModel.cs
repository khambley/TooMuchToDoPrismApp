using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooMuchToDoPrismApp.Repositories;
using TooMuchToDoPrismApp.Views;
using TooMuchToDoPrismApp.Models;

namespace TooMuchToDoPrismApp.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		private readonly TodoItemRepository _repository;

		public ObservableCollection<TodoItemViewModel> Items { get; set; }

		public DelegateCommand AddItem { get; set; }
		public MainPageViewModel(INavigationService navigationService, TodoItemRepository repository)
			: base(navigationService)
		{
			_repository = repository;
			Title = "Too Much To Do!";
			AddItem = new DelegateCommand(async () => await NavigationService.NavigateAsync(nameof(ItemPage)));

			//when item is added to repository, MainPage will add it to items list (observable collection), list is reloaded.
			repository.OnItemAdded += (sender, item) => Items.Add(CreateTodoItemViewModel(item));
			repository.OnItemUpdated += (sender, item) => Task.Run(async () => await LoadData());
		}
		
		private async Task LoadData()
		{
			var items = await _repository.GetItems();
			var itemViewModels = items.Select(i => CreateTodoItemViewModel(i));
			Items = new ObservableCollection<TodoItemViewModel>(itemViewModels);
		}
		private async Task NavigateToItemView()
		{
			await NavigationService.NavigateAsync(nameof(ItemPage));
		}

		private TodoItemViewModel CreateTodoItemViewModel(TodoItem item)
		{
			var itemViewModel = new TodoItemViewModel(item);
			itemViewModel.ItemStatusChanged += ItemStatusChanged;
			return itemViewModel;

		}
		private void ItemStatusChanged(object sender, EventArgs e) { }
	}
}
