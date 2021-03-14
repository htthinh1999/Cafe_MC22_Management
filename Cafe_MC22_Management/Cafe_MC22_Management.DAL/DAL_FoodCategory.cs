using Cafe_MC22_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_MC22_Management.DAL
{
    public class DAL_FoodCategory
    {
        static DAL_FoodCategory instance;
        public static DAL_FoodCategory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_FoodCategory();
                }
                return instance;
            }
            private set { instance = value; }
        }

        public DAL_FoodCategory() { }

        public List<FoodCategory> LoadFoodCategoryList()
        {
            List<FoodCategory> foodCategoryList = new List<FoodCategory>();
            string query = "USP_LoadFoodCategoryList";
            DataTable dataTable = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                FoodCategory foodCategory = new FoodCategory(row);
                foodCategoryList.Add(foodCategory);
            }

            return foodCategoryList;
        }

        public bool ExistCategory(string categoryName)
        {
            string query = "USP_ExistCategory";
            return DataProvider.ExecuteQuery(query, new object[] { categoryName }).Rows.Count > 0;
        }

        public void AddFoodCategory(string categoryName)
        {
            string query = "USP_AddFoodCategory";
            DataProvider.ExecuteQuery(query, new object[] { categoryName });
        }

        public void UpdateFoodCategory(string id, string categoryName)
        {
            string query = "USP_UpdateFoodCategory";
            DataProvider.ExecuteQuery(query, new object[] { id, categoryName });
        }

        public void DeleteFoodCategory(string id)
        {
            string query = "USP_DeleteFoodCategory";
            DataProvider.ExecuteQuery(query, new object[] { id });
        }
    }
}
