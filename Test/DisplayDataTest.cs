using CodingExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CodingExercise.Test
{
    [TestClass]
    public class DisplayDataTest
    {
        [TestMethod]
        public void DisplayDataShould()
        {
            var expected = new List<WingTipToysModel>();
            expected.Add(new WingTipToysModel
            {
                ProductId = 8,
                ProductName = "Paper Plane",
                ImagePath = "planepaper.png",
                UnitPrice = 2.95,
                CategoryId = 2,
                Description = "This paper plane is like no other paper plane. Some folding required."
            });

            List<WingTipToysModel> actual = Helper.HelperClass.DisplayData("Paper Plane");
            CollectionAssert.AreEquivalent(expected, actual);

        }
    }
}