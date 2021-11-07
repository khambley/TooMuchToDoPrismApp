using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using TooMuchToDoPrismApp.Repositories;

namespace TooMuchToDoPrismApp.ViewModels
{
	public class ItemViewModel : ViewModelBase
	{
		private readonly TodoItemRepository _repository;
		public ItemViewModel(INavigationService navigationService, TodoItemRepository repository)
			: base(navigationService)
		{
			_repository = repository;
		}
	}
}
