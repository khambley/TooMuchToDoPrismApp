using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TooMuchToDoPrismApp.Converters
{
	public class StatusColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			//these values are accessed in the Resources dictionary in App.xaml file
			return (bool)value ? (Color)Application.Current.Resources["CompletedColor"] : (Color)Application.Current.Resources["ActiveColor"];
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return null;
		}
	}
}
