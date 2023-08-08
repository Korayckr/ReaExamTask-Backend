using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Followings
    {

        public int UserId { get; set; } // Takip eden kullanıcının UserId'si

        public int FollowingsId { get; set; } // Takip edilen kullanıcının UserId'si





        public User User { get; set; } = default!;


    }
}
