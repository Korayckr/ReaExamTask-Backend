using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class FollowersConfiguration : IEntityTypeConfiguration<Followers>
    {
        public void Configure(EntityTypeBuilder<Followers> builder)
        {
           
            builder.Property(f => f.FollowersId).IsRequired();




            builder.HasOne(x => x.User)
                .WithMany(f => f.Followers)
                .HasForeignKey(x => x.UserId);






        }
    }
}
