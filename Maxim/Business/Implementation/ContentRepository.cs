using Business.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Implementation
{
    public class ContentRepository : IContentService
    {
        public Task Create(Content entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Content> Get(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException();
            }
            
        }

        public Task<List<Content>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Content entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
