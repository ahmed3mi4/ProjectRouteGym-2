using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectRouteGym.Business.Entities.Plans;

namespace ProjectRouteGym.DataAccess.Data.Configurations;

public class PlanConfiguration : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.ToTable("Plans");
        
        builder.Property(plan=> plan.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(plan => plan.Price)
            .IsRequired()
            .HasPrecision(18, 2);

        builder.Property(plan => plan.DurationDays)
            .IsRequired();

        builder.Property(plan => plan.Description)
            .HasMaxLength(maxLength: 500);
    }
}
