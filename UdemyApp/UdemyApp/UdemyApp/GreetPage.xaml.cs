using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{ 
		public GreetPage ()
		{
			InitializeComponent ();

			slider.Value = 0.5;

	
			////Generic
			//Padding = Device.OnPlatform(
			//	iOS: new Thickness(0, 20, 0, 0),
			//	Android: new Thickness(0, 30, 0, 0),
			//	WinPhone: new Thickness(0, 40, 0, 0)
			//);

			////Non-Generic
			//Device.OnPlatform(
			//	iOS: () =>				{
			//		Padding = new Thickness(0, 20, 0, 0);
			//	},
			//	Android: () => {
			//	});
		}


	}
}