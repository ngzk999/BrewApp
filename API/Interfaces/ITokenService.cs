using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    // The implemented classes will inherit all the methods, and
    // interface doesn't have any implementation logic.
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
