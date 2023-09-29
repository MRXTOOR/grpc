using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoGrpc.Data
{
    public class AppDbContext : AppDbContext
    {
        public AppDbContext(DbContextOption<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<ToDoItem> ToDoItem => Set<TodoItem>();
            }
}