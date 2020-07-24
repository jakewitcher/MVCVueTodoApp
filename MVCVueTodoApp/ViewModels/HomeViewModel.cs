using MVCVueTodoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCVueTodoApp.ViewModels
{
    public class HomeViewModel
    {
        public List<Todo> Todos { get; set; }

        public HomeViewModel(List<Todo> todos)
        {
            Todos = todos;
        }
    }
}