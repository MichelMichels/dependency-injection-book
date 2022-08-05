using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled.Domain;

public interface IUserContext
{
    bool IsInRole(Role role);
}

public enum Role
{
    PreferredCustomer
}
