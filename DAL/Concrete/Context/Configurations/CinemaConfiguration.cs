using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Concrete.Context.Configurations
{
    public class CinemaConfiguration : BaseConfiguration<Cinema>
    {
        public override void Configure(EntityTypeBuilder<Cinema> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Logo)
                .IsRequired(false);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(80);

            builder.HasMany(x => x.Movies)
                .WithOne(x => x.Cinema)
                .HasForeignKey(x => x.CinemaId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
