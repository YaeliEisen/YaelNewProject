using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YaelProject.Repositories.Entities;
using YaelProject.Repositories.Interfaces;

namespace YaelProject.Repositories.Reposiitories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly Icontext _context;
        public RoleRepository(Icontext context)
        {
            this._context = context;
        }

        public Role Add(int id, string name, string description)
        {
            _context.Roles.Add(new Role { Id = id, Name = name, Description = description });
            return _context.Roles.First(p => p.Id == id);
        }

        public Role Delete(int id)
        {
            Role role = _context.Roles.First(p => p.Id == id);
           _context.Roles.Remove(role);
            return role;
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(int id)
        {
            return _context.Roles.First(p => p.Id == id);
        }

        public Role Update( Role role)
        {
            Role r=_context.Roles.First(p => p.Id == role.Id);
            r.Name=role.Name;
            r.Description = role.Description;
            return r;
        }
    }
}
