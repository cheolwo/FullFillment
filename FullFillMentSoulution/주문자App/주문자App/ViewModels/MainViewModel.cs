using System;
using System.Collections.Generic;

namespace 주문자App.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            var service = new ToDoListService();
            ToDoList = new ToDoListViewModel(service.GetItems());
        }

        public ToDoListViewModel ToDoList { get; }
        public string Greeting => "Welcome to Avalonia!";
    }
    public class ToDoItem
    {
        public string Description { get; set; } = String.Empty;
        public bool IsChecked { get; set; }
    }
    public class ToDoListService
    {
        public IEnumerable<ToDoItem> GetItems() => new[]
        {
            new ToDoItem { Description = "Walk the dog" },
            new ToDoItem { Description = "Buy some milk" },
            new ToDoItem { Description = "Learn Avalonia", IsChecked = true },
        };
    }
}
