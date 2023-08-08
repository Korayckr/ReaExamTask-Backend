using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Followers
    {

        public int UserId { get; set; }
        
        public int FollowersId { get; set; }


        public User User { get; set; } = default!;

        
       

    }
}
