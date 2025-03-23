namespace EmployeeBonusManagementSystem.Domain.Entities;

public class RolesEntity
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }


}

public enum Role
{
    Admin = 1,
    User = 2
}