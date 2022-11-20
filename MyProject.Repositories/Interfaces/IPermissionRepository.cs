using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IPermissionRepository
    {
        public List<Permission> GetAll();

        public Permission GetById(int id);

        public Permission Add(int id, string name, string description);

        public Permission Update(Permission permission);

        public void Delete(int id);

    }
}
