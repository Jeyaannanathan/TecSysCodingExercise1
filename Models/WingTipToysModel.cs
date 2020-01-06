using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodingExercise.Models
{
    public class WingTipToysModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int ProductCategoryId { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Please enter a string that has at least 2 characters")]
        public string ProductSearch { get; set; }

    }
}