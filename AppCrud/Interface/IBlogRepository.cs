﻿using Domain.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCrud.Interface
{
   public interface IBlogRepository
    {
        public Task<List<Blogs>> FillAllBlogAsync();
    }
}
