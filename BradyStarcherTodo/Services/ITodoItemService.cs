using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BradyStarcherTodo.Models;

namespace BradyStarcherTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
        Task<bool> AddItemAsync(TodoItem newItem);
    }
}
