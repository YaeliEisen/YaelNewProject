using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaelProject.Mock;
using YaelProject.Repositories.Entities;
using YaelProject.Repositories.Interfaces;
using YaelProject.Repositories.Reposiitories;

namespace YaelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;
        public RolesController(IRoleRepository RoleRepository)
        {

            _roleRepository = RoleRepository;
        }
        [HttpGet]
        public List<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }
        [HttpDelete("{id}")]
        public Role Delete(int id)
        {
            return _roleRepository.Delete(id);
        }
        [HttpPost]
        public Role Add(int id, string name, string description)
        {
           return _roleRepository.Add(id, name, description);
        }
        [HttpPut]
        public Role Update( Role role) 
        {return _roleRepository.Update(role); }

    }
}
