
namespace Business.Models;

public class RegularUser : UserBase
{
    string roll = "Regular";

    public override string GetRole()
    {
        return roll;
    }
}
