using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooMuchToDoPrismApp.Repositories;

namespace TooMuchToDoPrismApp.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		private readonly TodoItemRepository _repository;
		public MainPageViewModel(INavigationService navigationService, TodoItemRepository repository)
			: base(navigationService)
		{
			_repository = repository;
			Title = "Main Page";
		}
		private async Task LoadData()
		{

		}
	}
}
