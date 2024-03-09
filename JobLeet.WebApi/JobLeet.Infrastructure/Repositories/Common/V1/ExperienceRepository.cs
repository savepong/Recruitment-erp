﻿using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Common.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Common.V1
{
    public class ExperienceRepository : IExperienceRepository
    {
        private readonly BaseDBContext _dbContext;
        public ExperienceRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task AddAsync(ExperienceModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {

            throw new NotImplementedException();
        }

        public Task<List<ExperienceModel>> GetAllAsync()
        {
            try
            {
                var results = _dbContext.Experiences
                    .Select(e => new ExperienceModel
                    {
                        Id = e.Id,
                        ExperienceLevel = (ExperienceLevel)e.ExperienceLevel
                    }).ToListAsync();
                return results;
            }
            catch(DbUpdateException ex)
            {
                throw new Exception("Error while fetching the database. Please try again later " + ex.Message);
            }
        }

        public Task<ExperienceModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ExperienceModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
