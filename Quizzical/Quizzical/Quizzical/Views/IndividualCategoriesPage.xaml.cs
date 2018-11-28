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
	public partial class IndividualCategoriesPage : ContentPage
	{
        CategoriesViewModel viewModel;
		public IndividualCategoriesPage ()
		{
			InitializeComponent ();

            BindingContext = CategoriesViewModel.Current;
		}
	}
}