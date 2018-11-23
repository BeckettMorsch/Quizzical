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
    public partial class SampleQuestionPage : ContentPage
    {
        public SampleQuestionPage()
        {
            InitializeComponent();
        }

        private void Button1Clicked(object sender, EventArgs e)
        {
            //Bring to CORRECT Page
            //Bring to next question

        }

        private void Button2Clicked(object sender, EventArgs e)
        {
            //Bring to INCORRECT Page
        }

        private void Button3Clicked(object sender, EventArgs e)
        {
            //Bring to INCORRECT Page
        }

        private void Button4Clicked(object sender, EventArgs e)
        {
            //Bring to INCORRECT Page
        }
    }
}