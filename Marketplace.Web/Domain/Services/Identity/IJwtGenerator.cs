﻿using System.Collections.Generic;
using Marketplace.Web.DataAccess.Entities;

namespace Marketplace.Web.Domain.Services.Identity
{
    public interface IJwtGenerator
    {
        string CreateToken(ApplicationUser user, List<string> roles);
    }
}
