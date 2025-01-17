﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkippingCounter.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        ValueTask<T?> GetItemAsync(string id);
        IAsyncEnumerable<T> GetItemsAsync(bool forceRefresh = false);
    }
}
