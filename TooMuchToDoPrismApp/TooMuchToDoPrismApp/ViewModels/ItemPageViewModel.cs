using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TooMuchToDoPrismApp.Models;
using TooMuchToDoPrismApp.Repositories;

namespace TooMuchToDoPrismApp.ViewModels
{
	public class ItemPageViewModel : ViewModelBase
	{
		private readonly TodoItemRepository _repository;
		private TodoItem _item;
		public TodoItem Item
		{
			get => _item;
			set => SetProperty(ref _item, value);
		}

		public DelegateCommand SaveCommand { get; set;
		}
		public ItemPageViewModel(INavigationService navigationService, TodoItemRepository repository)
			: base(navigationService)
		{
			_repository = repository;
			Title = "Too Much To Do!";
			Item = new TodoItem() { DueDate = DateTime.Now.AddDays(1) };
			SaveCommand = new DelegateCommand(SaveAsync);
		}

		private async void SaveAsync()
		{
			await _repository.AddOrUpdate(Item);
			await NavigationService.GoBackAsync();
		}
	}
}
