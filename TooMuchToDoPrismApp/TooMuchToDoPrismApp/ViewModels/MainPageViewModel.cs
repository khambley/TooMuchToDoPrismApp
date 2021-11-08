using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TooMuchToDoPrismApp.Repositories;
using TooMuchToDoPrismApp.Views;

namespace TooMuchToDoPrismApp.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		private readonly TodoItemRepository _repository;

		public DelegateCommand AddItem { get; set; }
		public MainPageViewModel(INavigationService navigationService, TodoItemRepository repository)
			: base(navigationService)
		{
			_repository = repository;
			Title = "Too Much To Do!";
			AddItem = new DelegateCommand(async () => await NavigationService.NavigateAsync(nameof(ItemPage)));
		}
		
		private async Task LoadData()
		{

		}
		private async Task NavigateToItemView()
		{
			await NavigationService.NavigateAsync(nameof(ItemPage));
		}
	}
}
