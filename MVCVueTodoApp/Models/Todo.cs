using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCVueTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        public Todo(int id, string description)
        {
            Id = id;
            Description = description;
            IsComplete = false;
        }
    }
}