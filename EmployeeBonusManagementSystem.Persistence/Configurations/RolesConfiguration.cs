using EmployeeBonusManagementSystem.Domain.Entities;

namespace EmployeeBonusManagementSystem.Persistence.Configurations
{
    public class RolesConfiguration : IEntityTypeConfiguration<RolesEntity>
    {
        public void Configure(EntityTypeBuilder<RolesEntity> builder)
        {
            builder.ToTable("Roles");
            builder.HasKey(b => b.RoleId);

            builder.Property(b => b.RoleName)
                .IsRequired();
        }
    }
}
