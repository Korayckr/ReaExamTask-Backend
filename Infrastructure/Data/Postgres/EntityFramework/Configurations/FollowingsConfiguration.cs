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
    public class FollowingsConfiguration : IEntityTypeConfiguration<Followings>
    {
        public void Configure(EntityTypeBuilder<Followings> builder)
        {
            builder.Property(f => f.FollowingsId).IsRequired();




            builder.HasOne(x => x.User)
                .WithMany(f => f.Followings)
                .HasForeignKey(x => x.UserId);

        }
    }
}
