using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
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
    public class FollowingsRepository : Repository<Followings, int>, IFollowingsRepository
    {
        public FollowingsRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Followings>> GetByFollowingsIdAsync(int id)
        {
            return await PostgresContext.Set<Followings>()
                .Where(f => f.UserId == id || f.FollowingsId == id)  
                .ToListAsync();
        }


        public async Task<IList<Followings>> GetAllAsync(Expression<Func<Followings, bool>>? filter = null)
        {
            var houses = PostgresContext.Set<Followings>();
            return filter == null
                ? await houses.ToListAsync()
                : await houses.Where(filter)
                .ToListAsync();
        }

        public async Task AddAsync(Followings entity)
        {
            await PostgresContext.Set<Followings>().AddAsync(entity);
            await PostgresContext.SaveChangesAsync();
        }

        public void Update(Followings entity)
        {
            PostgresContext.Set<Followings>().Update(entity);
            PostgresContext.SaveChanges();
        }

        
    }
}
