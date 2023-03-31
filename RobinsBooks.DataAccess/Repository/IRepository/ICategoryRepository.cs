using RobinsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobinsBooks.DataAccess.Repository.IRepository
{
    interface ICategoryRepository :IRepository<Category>
    {
        void Update(Category category);
    }
}
