using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions<MyContext> option): base(option)
        {

        }

        public DbSet<Users> Users { get; set; }

        //Microsoft.EntityFrameWorkCore.Tools  --> install in migration's folder
        //Microsoft.EntityFrameworkCore.Relational --> install in migration's folder
        //Microsoft.EntityFrameworkCore.Design --> Install in main API project
    }
}
