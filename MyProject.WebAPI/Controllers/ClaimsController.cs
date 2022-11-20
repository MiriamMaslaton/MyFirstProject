using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Security.Claims;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {

        private readonly IClaimRepository _claimRepository;

        public ClaimsController(IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }

        [HttpGet]

        public List<Claim> Get()
        {
            return _claimRepository.GetAll();
        }

        [HttpGet("{id}")]

        public Claim Get(int id)
        {
            return _claimRepository.GetById(id);
        }
    }
}
