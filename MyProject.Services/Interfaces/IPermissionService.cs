using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IPermissionService
    {
        List<PermissionDTO> GetList();
        PermissionDTO GetById(int id);
        void Delete(int id);
        PermissionDTO UpDate(Permission permission);
        PermissionDTO Add(int id, string name, string description);
    }
}
