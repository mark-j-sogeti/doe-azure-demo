using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListApp.Models
{
    public class ToDoItem
    {
        public int ToDoItemId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(256)]
        public string Name { get; set; }
        
        public bool IsComplete { get; set; }
    }
}