﻿using System.Collections.Generic;
using System.Threading.Tasks;

using XamarinNews.Models;

namespace XamarinNews.Services
{
    public interface IRestService
    {
        Task<List<Category>> FetchCategoriesAsync();
        Task<List<Post>> FetchPostsAsync(string path, int page);
        Task<bool> CheckMorePostAsync(string path, int page);
        Task<Post> GetPostAsync(string ind);

    }
}
