using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UpdateTweetsDto
    {

       

        public string TweetHeader { get; set; } = default!;

        public string TweetDesc { get; set; } = default!;
        public int TweetLikes { get; set; } = default!;

        public DateTime CreatedAt { get; set; } = default!;
    }
}
