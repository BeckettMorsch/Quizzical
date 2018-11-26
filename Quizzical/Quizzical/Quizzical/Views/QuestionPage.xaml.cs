using Quizzical.ViewModels;
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
	public partial class QuestionPage : ContentPage
	{
        CategoriesViewModel viewModel;
        public QuestionPage ()
		{
			InitializeComponent ();

            BindingContext = viewModel = new CategoriesViewModel();
		}

        async private void Button1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CorrectPage()));
            //Bring to next question

        }

        async private void Button2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new IncorrectPage()));
        }

        async private void Button3Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new IncorrectPage()));
        }

        async private void Button4Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new IncorrectPage()));
        }
    }
}