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
        CategoriesViewModel vm;

        public QuestionPage()
        {
            InitializeComponent();

            this.BindingContext = vm = CategoriesViewModel.Current;
        }

        public void HandleAnswer(int answerNum)
        {
            vm.ShowQuestion = false;
            
            if (vm.Question.CorrectAnswer == answerNum)
            {
                // Correct
            }
            if (vm.CurrentQuestion < vm.Count-1)
            {
                vm.CurrentQuestion++;
            }
            else
            {
                // Game over
            }
            //await Navigation.PushModalAsync(new NavigationPage(new CorrectPage()));
        }

        private void Button1Clicked(object sender, EventArgs e)
        {
            //Bring to next question
            HandleAnswer(1);
        }

        private void Button2Clicked(object sender, EventArgs e)
        {
            HandleAnswer(2);
        }

        private void Button3Clicked(object sender, EventArgs e)
        {
            HandleAnswer(3);
        }

        private void Button4Clicked(object sender, EventArgs e)
        {
            HandleAnswer(4);
        }

        private void NextQuestion(object sender, EventArgs e)
        {
            vm.ShowQuestion = true;
        }
    }
}