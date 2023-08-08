using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateFollowersDto
    {

        public int UserId { get; set; }

        public int FollowersId { get; set; }
    }
}
