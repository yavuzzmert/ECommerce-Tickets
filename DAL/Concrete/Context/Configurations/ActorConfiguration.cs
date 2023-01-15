using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DAL.Concrete.Context.Configurations
{
    public class ActorConfiguration : BaseConfiguration<Actor>
    {
        public override void Configure(EntityTypeBuilder<Actor> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ProfilePictureURL)
                .IsRequired(false);

            builder.Property(x => x.FullName)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(x => x.Biography)
                .IsRequired();

            builder.HasMany(x => x.Movies)
                    .WithMany(x => x.Actors);
        }
    }
}
