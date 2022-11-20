using AutoMapper;
using MyProject.Common;
using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using Claim = MyProject.Repositories.Entities.Claim;


namespace MyProject.Services
{
  

    public class ClaimService : IClaimService
    {
        private readonly IClaimRepository _ClaimRepository;
        private readonly IMapper _mapper;

        public ClaimService(IClaimRepository ClaimRepositpry, IMapper mapper)
        {
            _ClaimRepository = ClaimRepositpry;
            _mapper = mapper;
        }
        public ClaimDTO Add(int id, int roleId, int permissionId, EPolicy policy)
        {
            return _mapper.Map<ClaimDTO>(_ClaimRepository.Add(id, roleId, permissionId, policy));
        }

        
        public void Delete(int id)
        {
           _ClaimRepository.Delete(id);
        }

        public List<ClaimDTO> GetList()
        {
            return _mapper.Map<List<ClaimDTO>>(_ClaimRepository.GetAll());
        }

        public ClaimDTO Update(Claim claim)
        {
            return _mapper.Map<ClaimDTO>(_ClaimRepository.Update(claim));
        }


        ClaimDTO IClaimService.GetById(int id)
        {
            return _mapper.Map<ClaimDTO>(_ClaimRepository.GetById(id));
        }
    }
}
