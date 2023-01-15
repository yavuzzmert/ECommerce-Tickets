using Entities;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Concrete.Context.Configurations
{
    public class MovieConfiguration : BaseConfiguration<Movie>
    {
        public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.MovieName)
                .IsRequired()
                .HasMaxLength(30);

            builder.HasIndex(x => x.MovieName)
                .IsUnique();

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(350);

            builder.Property(x => x.Price)
                .IsRequired();

            builder.Property(x => x.ImageURL)
                .IsRequired();

            builder.Property(x => x.StartDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(x => x.EndDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(x => x.MovieCategory)
                .HasConversion(new EnumToStringConverter<MovieCategory>());


            builder.HasOne(x => x.Cinema)
                .WithMany(x => x.Movies)
                .HasForeignKey(x => x.CinemaId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Producer)
                .WithMany(x => x.Movies)
                .HasForeignKey(x => x.ProducerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Actors)
                .WithMany(x => x.Movies);              
                

        }
    }
}
