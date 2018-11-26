using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quizzical.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quizzical.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CategoryPage : ContentPage
	{
		public CategoryPage ()
		{
			InitializeComponent ();
		}


        CategoriesViewModel viewModel;
        //HISTORY BUTTON CATEGORY
        async private void Button1Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PushModalAsync(new NavigationPage(new QuestionPage()));
            //Where do i put ExecuteLoadHistoryCommand
            //how do i link the question page with the history category
            //viewModel.LoadHistoryCommand.Execute(null); 
        }


        //SPORTS BUTTON CATERGORY
        private void Button2Clicked(object sender, EventArgs e)
        {
            
        }


        //SCIENCE BUTTON CATEGORY
        private void Button3Clicked(object sender, EventArgs e)
        {
            
        }
        

        //ENTERTAINMENT BUTTON CATEGORY
        private void Button4Clicked(object sender, EventArgs e)
        {
            
        }
    }
}