using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Concrete.Context.Configurations
{
    public class ProducerConfiguration : BaseConfiguration<Producer>
    {
        public override void Configure(EntityTypeBuilder<Producer> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ProfilePictureURL)
                .IsRequired(false);

            builder.Property(x => x.FullName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Biography)
                .IsRequired()
                .HasMaxLength(300);

            builder.HasMany(x => x.Movies)
                .WithOne(x => x.Producer)
                .HasForeignKey(x => x.ProducerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
