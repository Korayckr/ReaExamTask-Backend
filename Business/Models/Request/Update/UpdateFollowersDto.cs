using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UpdateFollowersDto
    {

        public int UserId { get; set; }

        public int FollowersId { get; set; }
    }
}
