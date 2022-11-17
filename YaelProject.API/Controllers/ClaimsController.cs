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
    public class ClaimsController : ControllerBase
    {
        private readonly IClaimRepository _ClaimRepository;
        public ClaimsController(IClaimRepository claimRepository)
        {
            _ClaimRepository = claimRepository;
        }
        [HttpGet]
        public List<Claim> GetALL()
        {
            return _ClaimRepository.GetALL();
        }
        [HttpGet("{id}")]
        public Claim GetById(int id)
        {
            return _ClaimRepository.GetById(id);
        }
        [HttpDelete("{id}")]
        public Claim Delete(int id)
        {
            return _ClaimRepository.Delete(id);
        }
        [HttpPost]
        public Claim Add(int id, int roleid, int permissionid, EPolicy policy)
        {
            return _ClaimRepository.Add(id,roleid,permissionid,policy);
        }
        [HttpPut]
        public Claim Update(Claim claim)
        { return _ClaimRepository.Update(claim); }
    }
}
