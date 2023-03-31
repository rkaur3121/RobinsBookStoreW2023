﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RobinsBooks.DataAccess.Repository.IRepository
{
    interface UnitOfWork
    {
        ICategoryRepository Category { get; }

        ISP_Call SP_Call { get; }
    }
}