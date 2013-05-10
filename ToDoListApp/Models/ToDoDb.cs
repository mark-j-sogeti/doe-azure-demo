using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ToDoListApp.Models
{
    public class ToDoDb : DbContext
    {
        public ToDoDb()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}