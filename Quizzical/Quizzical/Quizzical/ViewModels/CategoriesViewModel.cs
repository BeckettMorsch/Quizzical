using Quizzical.Models;
using Quizzical.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Quizzical.ViewModels 
{
    public class CategoriesViewModel
    {

        public ObservableCollection<Categories> Category { get; set; }
        public ObservableCollection<QuestionItem>  Questions { get; set; }

        public CategoriesViewModel()
        {
            Category = new ObservableCollection<Categories>();
            Questions = new ObservableCollection<QuestionItem>();
            //LoadCommand = new Command(async () => await ExecuteLoadItemsCommand());
            //LoadCommand = new Command(async () => await ExecuteLoadPlayerCommand());
        }
    }
}
