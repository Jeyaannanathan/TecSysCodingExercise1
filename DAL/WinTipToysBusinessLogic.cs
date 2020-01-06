using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CodingExercise
{
    public static class WinTipToysBusinessLogic
    {
        public static List<WinTipTopDbModel> LoadWinTipToys(string cartegory)
        {
            string sql = $@"select * from Products p
                            inner join Categories c on p.CategoryID = c.CategoryID
                            where c.CategoryName = '{cartegory}';";

            return SqlDataAccess.LoadData<WinTipTopDbModel>(sql);
        }

        public static List<WinTipTopDbModel> ProductSearch(string search)
        {
            string sql = $@"select * from Products p
                            inner join Categories c on p.CategoryID = c.CategoryID
                            where p.ProductName like '%{search}%' or p.Description like '%{search}%';";

            return SqlDataAccess.LoadData<WinTipTopDbModel>(sql);
        }
    }
}
