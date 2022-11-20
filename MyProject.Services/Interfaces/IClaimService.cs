using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public enum EPolicy { Allow, Deny };

    public interface IClaimService
    {
        List<ClaimDTO> GetList();
        ClaimDTO GetById(int id);
        void Delete(int id);
        ClaimDTO Update(Claim claim);
        ClaimDTO Add(int id, int roleId, int permissionId,EPolicy policy);
    }
}
