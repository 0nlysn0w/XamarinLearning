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
	public partial class QuotesPage : ContentPage
	{
		private static int _index;
		private string[] _quotes = new string[] {
			"It’s not a bug. It’s an undocumented feature!",
			"“Software Developer” – An organism that turns caffeine into software.",
			"A user interface is like a joke. If you have to explain it, it’s not that good."
		};

		public QuotesPage()
		{
			InitializeComponent();
			currentQuote.Text = _quotes[_index];
		}

		void Clicked_Next(object sender, EventArgs e)
		{
			_index++;
			if (_index >= _quotes.Length)
			{
				_index = 0;
			}
			currentQuote.Text = _quotes[_index];
		}
	}
}