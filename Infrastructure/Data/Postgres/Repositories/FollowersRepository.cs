using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class FollowersRepository : Repository<Followers, int>, IFollowersRepository
    {
        public FollowersRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Followers>> GetByFollowersIdAsync(int id)
        {
            return await PostgresContext.Set<Followers>()
              .Where(f => f.UserId == id || f.FollowersId == id)
              .ToListAsync();
        }


        public async Task<IList<Followers>> GetAllAsync(Expression<Func<Followers, bool>>? filter = null)
        {
            var houses = PostgresContext.Set<Followers>();
            return filter == null
                ? await houses.ToListAsync()
                : await houses.Where(filter)
                .ToListAsync();
        }

        public async Task AddAsync(Followers entity)
        {
            await PostgresContext.Set<Followers>().AddAsync(entity);
            await PostgresContext.SaveChangesAsync();
        }

        public void Update(Followers entity)
        {
            PostgresContext.Set<Followers>().Update(entity);
            PostgresContext.SaveChanges();
        }

    }

}
