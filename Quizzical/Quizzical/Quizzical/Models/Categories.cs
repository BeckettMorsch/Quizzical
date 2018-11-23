using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Quizzical.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ObservableCollection<QuestionItem> Questions { get; set; } = new ObservableCollection<QuestionItem>();
    }
}
