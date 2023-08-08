using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class TweetsConfiguration : IEntityTypeConfiguration<Tweets>
    {
        public void Configure(EntityTypeBuilder<Tweets> builder)
        {
            builder.Property(t => t.TweetHeader).IsRequired();
            builder.Property(t => t.TweetDesc).IsRequired();
            builder.Property(t => t.TweetLikes).IsRequired();
            builder.Property(t => t.CreatedAt).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(t => t.Tweets)
                .HasForeignKey(x => x.UserId);

        }
    }
}
