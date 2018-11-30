using Quizzical.ViewModels;
using Quizzical.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quizzical
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CategoriesViewModel.Current.Reset();

            BackgroundImage = "Wishie.jpg";
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new QuestionPage());
        }

        async private void TOS_Button(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new TOSPage());
        }
    }
}
