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
    public class HistoryViewModel
    {
        bool IsBusy = false;
        public bool Loaded { get; set; } = false;

        public ObservableCollection<Question> HistoryQuestions { get; set; }
        public Command LoadHistoryCommand { get; set; }


        public HistoryViewModel()
        {
            LoadHistoryCommand = new Command(async () => await ExecuteLoadHistoryCommand());
          
        }

        async Task ExecuteLoadHistoryCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {               
                HistoryQuestions.Add(new Question { QuestionNumber = 1, question = "What year did the United States of America declare its independence", Answer1 = "1776", Answer2 = "500", Answer3 = "1066", Answer4 = "1789", CorrectNumber = 1 });

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