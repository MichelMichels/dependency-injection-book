using LooselyCoupled.Domain;

namespace LooselyCoupled.UI.Adapters;

public class AspNetUserContextAdapter : IUserContext
{
    public bool IsInRole(Role role)
    {
        return true;
    }
}
