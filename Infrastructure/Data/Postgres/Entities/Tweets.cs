using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Tweets : Entity<int>
    {

        public int UserId { get; set; }
        public string UserName { get; set; } = default!;

        public string TweetHeader { get; set; } = default!;

        public string TweetDesc { get; set; } = default!;
        public int TweetLikes { get; set; } = default!;

        public DateTime CreatedAt { get; set; } = default!;


        public User User { get; set; } = default!;

       
    }
}
