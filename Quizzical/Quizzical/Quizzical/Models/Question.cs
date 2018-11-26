using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzical.Models
{
    public enum CategoryType
    {
        HISTORY,
        SPORTS,
        SCIENCE,
        ENTERTAINMENT
    }

    public class Question
    {
        
        public CategoryType category { get; set; }
        public int QuestionNumber { get; set; }
        public string question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int CorrectNumber { get; set; }

    }
}
