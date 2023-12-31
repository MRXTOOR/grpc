using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class ToDoitem
    {   
        [Key]
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? TodoStatus { get; set; } = "NEW";
    }
}