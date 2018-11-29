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
    public partial class EndPage : ContentPage
    {
        CategoriesViewModel vm;

        public EndPage()
        {
            InitializeComponent();

            this.BindingContext = vm = CategoriesViewModel.Current;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopToRootAsync();
            vm.ResetCorrect++;

        }
    }
}