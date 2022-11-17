using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaelProject.Repositories.Entities;

namespace YaelProject.Repositories.Interfaces
{
    public interface Icontext
    {
        public List<Claim> Claims { set; get; }
        public List<Role> Roles { set; get; }
        public List<Permission> Permissions { set; get; }
    }
}
