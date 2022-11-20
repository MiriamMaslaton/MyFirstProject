using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        public List<Claim> GetAll();

        public Claim GetById(int id);

        public Claim Add(int id, int roleId, int permissionId, EPolicy policy);

        public Claim Update(Claim claim);

        public void Delete(int id);

    }
}
