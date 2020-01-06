using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise
{
    public class WinTipTopDbModel
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
    }
}
