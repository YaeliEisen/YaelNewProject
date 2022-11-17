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
    public class PermissionsController : ControllerBase
    {
        private readonly IPermissionRepository _PremissinRepository;
        public PermissionsController(IPermissionRepository PremissinRepository)
        {

            _PremissinRepository = PremissinRepository;
        }
        [HttpGet]
        public List<Permission> GetAll()
        {
            return _PremissinRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Permission GetById(int id)
        {
            return _PremissinRepository.GetById(id);
        }
        [HttpDelete("{id}")]
        public Permission Delete(int id)
        {
            return _PremissinRepository.Delete(id);
        }
        [HttpPost]
        public Permission Add(int id, string name, string description)
        {
            return _PremissinRepository.Add(id, name, description);
        }
        [HttpPut]
        public Permission Update(Permission permission) { 
            return _PremissinRepository.Update(permission); }

    }
}
