﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzical.Models
{
    public class QuestionItem
    {
        public string Question { get; set; }
        public List<string> Answers = new List<string>();
    }
}