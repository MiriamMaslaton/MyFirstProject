using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace MyProject.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _PermissionRepositpry;
        private readonly IMapper _mapper;

        public PermissionService(IPermissionRepository PermissionRepositpry, IMapper mapper)
        {
            _PermissionRepositpry = PermissionRepositpry;
            _mapper = mapper;
        }


        public PermissionDTO Add(int id, string name, string description)
        {
            return _mapper.Map<PermissionDTO>(_PermissionRepositpry.Add(id, name, description));
        }

        public void Delete(int id)
        {
            _PermissionRepositpry.Delete(id);
        }

        public List<PermissionDTO> GetList()
        {
            return _mapper.Map<List<PermissionDTO>>(_PermissionRepositpry.GetAll());
        }

        public PermissionDTO UpDate(Permission Permission)
        {
            return _mapper.Map<PermissionDTO>(_PermissionRepositpry.Update(Permission));
        }

        PermissionDTO IPermissionService.GetById(int id)
        {
            return _mapper.Map<PermissionDTO>(_PermissionRepositpry.GetById(id));
        }
    }
}
