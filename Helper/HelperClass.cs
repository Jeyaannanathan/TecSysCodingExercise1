using CodingExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static CodingExercise.WinTipToysBusinessLogic;

namespace CodingExercise.Helper
{
    public class HelperClass
    {
        public static List<WingTipToysModel> DisplayData(string productSearch)
        {
            if (String.IsNullOrEmpty(productSearch))
            {
                //return db.Products.Where(x => x.ProductName.Contains(productSearch) || x.Description.Contains(productSearch)).ToList();
                var cars = LoadWinTipToys("Cars");
                List<WingTipToysModel> productCars = ProductList(cars);
                return productCars;
            }
            else
            {
                //return db.Products.Where(x => x.Category.CategoryName.Contains("Cars")).ToList();

                var cars = ProductSearch(productSearch);
                List<WingTipToysModel> productCars = ProductList(cars);
                return productCars;
            }
        }


        private static List<WingTipToysModel> ProductList(List<WinTipTopDbModel> products)
        {
            List<WingTipToysModel> productCars = new List<WingTipToysModel>();
            foreach (var item in products)
            {
                productCars.Add(new WingTipToysModel
                {
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    UnitPrice = item.UnitPrice,
                    Description = item.Description,
                    ImagePath = item.ImagePath,
                    CategoryId = item.CategoryId
                }); ;
            }

            return productCars;
        }
    }
}