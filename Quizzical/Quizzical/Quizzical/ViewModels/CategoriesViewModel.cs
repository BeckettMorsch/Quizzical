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
    public class CategoriesViewModel
    {
        bool IsBusy = false;
        public bool Loaded { get; set; } = false;

        // public ObservableCollection<Categories> Category { get; set; }
        // public ObservableCollection<QuestionItem>  Questions { get; set; }
        public ObservableCollection<Question> HistoryQuestions { get; set; }
        public Command LoadHistoryCommand { get; set; }

        
        public CategoriesViewModel()
        {
           // Category = new ObservableCollection<Categories>();
           // Questions = new ObservableCollection<QuestionItem>();
            LoadHistoryCommand = new Command(async () => await ExecuteLoadHistoryCommand());
            //LoadCommand = new Command(async () => await ExecuteLoadPlayerCommand());

            
        }

        async  Task ExecuteLoadHistoryCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                // question , a1 , a2 , a3 , a4
                //Players.Add(new Player { Id = 1, Name = "Bob", Rating = 1000 });
                HistoryQuestions.Add(new Question { QuestionNumber = 1, question = "What year did the United States of America declare its independence", Answer1 = "1776", Answer2 = "500", Answer3 = "1066", Answer4 = "1789", CorrectNumber = 1});


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
