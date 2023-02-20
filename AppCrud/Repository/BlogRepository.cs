using AppCrud.Connection;
using AppCrud.Interface;
using Dapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Domain.Blog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AppCrud.Repository
{
    public class BlogRepository : ConnectionDb, IBlogRepository
    {
        SqlConnection conn;
        public BlogRepository(IConfiguration config) : base(config)
        {
           
        }

        public async Task<List<Blogs>> FillAllBlogAsync()
        {
            string stored = "mgi_sp_FindAllBlog";
            using (conn = GetConnection())
            {
                var results = await conn.QueryAsync<Blogs>(stored, new
                {
                }, commandType: CommandType.StoredProcedure);

                return results.ToList();
            }
        }
    }
}
