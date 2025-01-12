﻿using System.Collections.Generic;

namespace Marketplace.Web.Domain.Models.Identities
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Token { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }
        public List<string> Roles { get; set; }
    }
}