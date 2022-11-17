using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaelProject.Repositories.Entities
{
    public enum EPolicy { deny,allow}
    public class Claim
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public EPolicy Policy { get; set; }

        /*stam*/
    }
}
