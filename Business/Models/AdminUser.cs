
namespace Business.Models;

public class AdminUser : UserBase
{
    string roll = "Admin";

    public override string GetRole()
    {
        return roll;
    }
}
