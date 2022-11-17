using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaelProject.Repositories.Entities;

namespace YaelProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        List<Claim> GetALL();
        Claim GetById(int id);
        Claim Add(int id, int roleid, int permissionid, EPolicy policy);
        Claim Update(Claim claim);
        Claim Delete(int id);
        
    }
}
