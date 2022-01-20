using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace firstWebApp.models
{
    public class calculatormodel
    {
        [Range(0,100)]
        public int assignment { get; set; }

        [Range(0, 100)]
        public int groupproject { get; set; }

        [Range(0, 100)]
        public int quizzes { get; set; }

        [Range(0, 100)]
        public int exams { get; set; }

        [Range(0, 100)]
        public int intex { get; set; }

      
    }
}
