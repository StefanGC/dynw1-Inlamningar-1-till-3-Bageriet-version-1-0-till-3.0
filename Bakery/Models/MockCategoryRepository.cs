﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="White breads", Description="All-fruity pies"},
                new Category{CategoryId=2, CategoryName="Dark breads", Description="Cheesy all the way"},
                new Category{CategoryId=3, CategoryName="Coffee breads", Description="Get in the mood for a seasonal pie"}
            };
    }
}
