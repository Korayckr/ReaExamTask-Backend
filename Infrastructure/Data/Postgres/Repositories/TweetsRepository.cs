using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class TweetsRepository : Repository<Tweets, int>, ITweetsRepository
    {
        public TweetsRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Tweets>> GetAllAsync(Expression<Func<Tweets, bool>>? filter = null)
        {
            var houses = PostgresContext.Set<Tweets>();
            return filter == null
                ? await houses.ToListAsync()
                : await houses.Where(filter)
                .ToListAsync();
        }

        public async Task AddAsync(Tweets entity)
        {
            await PostgresContext.Set<Tweets>().AddAsync(entity);
            await PostgresContext.SaveChangesAsync();
        }

        public void Update(Tweets entity)
        {
            PostgresContext.Set<Tweets>().Update(entity);
            PostgresContext.SaveChanges();
        }

        async Task<Tweets> IRepository<Tweets, int>.GetByIdAsync(int id)
        {
            return await PostgresContext.Set<Tweets>().FindAsync(id);
        }


        public class Followings
        {

            public int UserId { get; set; }

            public int FollowingsId { get; set; }
            public User User { get; set; } = default!;


        }

        public async Task<IList<Tweets>> GetByTweetsIdAsync(int userId)
        {
            var followings = await PostgresContext.Set<Followings>()
            .Where(f => f.UserId == userId)  // Kullanıcının takip ettikleri
                .Include(f => f.User.Tweets)  // Takip edilen kullanıcıların tweet koleksiyonunu dahil et
                .ToListAsync();

            var tweets = new List<Tweets>();

            foreach (var following in followings)
            {
                tweets.AddRange(following.User.Tweets);  // Kullanıcının takip ettiği kişilerin tweetlerini ekleyin
            }

            return tweets;
        }
   







    }
}
