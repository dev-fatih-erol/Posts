﻿using System.Threading.Tasks;
using MongoDB.Driver.Linq;
using Posts.Infrastructure.Entities;

namespace Posts.Infrastructure.Services
{
    public interface IPostService
    {
        IMongoQueryable<Post> GetByUserId(int userId);

        Task<Post> GetById(string id);

        Task<Post> Delete(string id, int userId);

        Task Create(Post post);
    }
}