﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BradyStarcherTodo.Models;
using Microsoft.AspNetCore.Identity;

namespace BradyStarcherTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync(IdentityUser user);
        Task<bool> AddItemAsync(TodoItem newItem, IdentityUser user);
        Task<bool> MarkDoneAsync(Guid id, IdentityUser user);
    }
}
