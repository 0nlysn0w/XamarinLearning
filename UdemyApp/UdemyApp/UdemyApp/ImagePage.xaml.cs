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
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

			//var imageSource = new UriImageSource { Uri = new Uri("http://placekitten.com/1080/1920") };
			//imageSource.CachingEnabled = false;
			//image.Source = imageSource;
			//image.Aspect = Aspect.AspectFill;

			image.Source = ImageSource.FromResource("UdemyApp.Images.background.jpg");
		}
	}
}