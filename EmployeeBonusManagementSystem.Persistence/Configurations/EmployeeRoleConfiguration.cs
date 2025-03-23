using EmployeeBonusManagementSystem.Domain.Entities;


namespace EmployeeBonusManagementSystem.Persistence.Configurations
{
    class EmployeeRoleConfiguration : IEntityTypeConfiguration<EmployeeRoleEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeRoleEntity> builder)
        {
            builder.ToTable("EmployeeRole");

            builder.HasKey(b => b.Id);

            builder.HasOne<EmployeeEntity>()
                .WithMany()
                .HasForeignKey(b => b.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<RolesEntity>()
                .WithMany()
                .HasForeignKey(b => b.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
