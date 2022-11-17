using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using YaelProject.Repositories.Entities;
using YaelProject.Repositories.Interfaces;
using Claim = YaelProject.Repositories.Entities.Claim;

namespace YaelProject.Mock
{
    
    public class MockContext:Icontext
    {
        public List<Claim> Claims { set; get; }
        public List<Role> Roles { set; get; }
        public List<Permission> Permissions { set; get; }

        public MockContext()
        {
            Roles = new List<Role>();
            Permissions = new List<Permission>();
            Claims = new List<Claim>();

            Roles.Add(new Role { Id = 1, Name = "admin", Description = "full access" });
            Roles.Add(new Role { Id = 2, Name = "student", Description = "student in seminary" });

            Permissions.Add(new Permission { Id = 1, Name = "ViewAllTests", Description = "" });

            Claims.Add(new Claim { Id = 1, RoleId = 1, PermissionId = 1, Policy = EPolicy.allow });
            Claims.Add(new Claim { Id = 2, RoleId = 2, PermissionId = 1, Policy = EPolicy.deny });
        }
    }
}
