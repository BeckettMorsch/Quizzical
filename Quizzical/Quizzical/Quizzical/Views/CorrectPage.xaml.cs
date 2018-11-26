using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quizzical.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CorrectPage : ContentPage
	{
		public CorrectPage ()
		{
			InitializeComponent ();

            //await Task.Delay(10);
            //Bring to the next question after some delay
		}
	}
}