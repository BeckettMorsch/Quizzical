using Quizzical.Models;
using Quizzical.ViewModels;
using Quizzical.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quizzical.ViewModels
{
    class SportsViewModel
    {

        bool IsBusy = false;
        public bool Loaded { get; set; } = false;

        public ObservableCollection<Question> SportsQuestions { get; set; }
        public Command LoadSportsCommand { get; set; }


        public SportsViewModel()
        {
            LoadSportsCommand = new Command(async () => await ExecuteLoadSportsCommand());

        }

        async Task ExecuteLoadSportsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                SportsQuestions.Add(new Question { QuestionNumber = 1, question = "What team is the best?", Answer1 = "TSM", Answer2 = "100T", Answer3 = "G2", Answer4 = "SKT T1", CorrectNumber = 1 });

            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }

            Loaded = true;
        }




    
    }
}
