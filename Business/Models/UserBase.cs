
namespace Business.Models;

abstract public class UserBase
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public virtual string GetRole()
    {
        return null!;
    }
}
