using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using YaelProject.Repositories.Entities;
using YaelProject.Repositories.Interfaces;
using Claim = YaelProject.Repositories.Entities.Claim;

namespace YaelProject.Repositories.Reposiitories
{
    public class claimRepository : IClaimRepository
    {
        private readonly Icontext _context;
        public claimRepository(Icontext context)
        {
            this._context = context;
        }
        public Claim Add(int id, int roleid, int permissionid, EPolicy policy)
        {
            _context.Claims.Add(new Claim { Id = 1, RoleId = 1, PermissionId = 1, Policy = EPolicy.allow });
            return _context.Claims.First(p => p.Id == id);
        }

        public Claim Delete(int id)
        {
            Claim c = _context.Claims.First(p1 => p1.Id == id);
            _context.Claims = _context.Claims.Where(p1 => p1.Id != id).ToList();
            return c;
        }

        public List<Claim> GetALL()
        {
            return _context.Claims;
        }

        public Claim GetById(int id)
        {
            return _context.Claims.First(p => p.Id == id);
        }

        public Claim Update(Claim claim)
        {

            Claim r = _context.Claims.First(p => p.Id == claim.Id);
            r.RoleId = claim.RoleId;
            r.PermissionId = claim.PermissionId;
            r.Policy = claim.Policy;
            return r;

        }
    }
}
