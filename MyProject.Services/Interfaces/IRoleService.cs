using MyProject.Common;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IRoleService
    {
        List<RoleDTO> GetList();
        RoleDTO GetById(int id);
        void Delete(int id);
        RoleDTO UpDate(Role role);
        RoleDTO Add(int id,string name,string description);

    }
}
