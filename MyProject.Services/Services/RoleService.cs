using AutoMapper;
using MyProject.Common;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace MyProject.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepositpry;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository roleRepositpry, IMapper mapper)
        {
            _roleRepositpry = roleRepositpry;
            _mapper = mapper;
        }


        public RoleDTO Add(int id, string name, string description)
        {
            return _mapper.Map<RoleDTO>(_roleRepositpry.Add(id, name, description));
        }

        public void Delete(int id)
        {
            _roleRepositpry.Delete(id);
        }

        public List<RoleDTO> GetList()
        {
            return _mapper.Map<List<RoleDTO>>(_roleRepositpry.GetAll());
        }

        public RoleDTO UpDate(Role role)
        {
            return _mapper.Map<RoleDTO>(_roleRepositpry.Update(role));
        }

        RoleDTO IRoleService.GetById(int id)
        {
            return _mapper.Map<RoleDTO>(_roleRepositpry.GetById(id));
        }


    }
}
