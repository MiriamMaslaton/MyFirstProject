using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace MyProject.Mock
{
    public class MockContext : IContext
    {
        public List<Role> Roles { get ; set ; }
        public List<Permission> Permissions { get; set ; }
        public List<Claim> Claims { get ; set; }

        public MockContext()
        {
            Roles = new List<Role>();
            Permissions = new List<Permission>();
            Claims = new List<Claim>();

            Roles.Add(new Role { Id = 1, Name = "admin", Description = "admin with full access" });
            Roles.Add(new Role { Id = 2, Name = "student", Description = "student with limited access" });

            Permissions.Add(new Permission { Id = 1, Name = "ViewAllTests", Description ="Can see the tests"});
            Permissions.Add(new Permission { Id = 2, Name = "UploadTest" ,Description="Can upload tests into the site"});

            Claims.Add(new Claim { Id = 1, RoleId = 1, PermissionId = 1, Policy = EPolicy.Allow });
            Claims.Add(new Claim { Id = 2, RoleId = 1, PermissionId = 2, Policy = EPolicy.Allow });
            Claims.Add(new Claim { Id = 3, RoleId = 2, PermissionId = 1, Policy = EPolicy.Deny });
            Claims.Add(new Claim { Id = 4, RoleId = 2, PermissionId = 2, Policy = EPolicy.Allow });
        }
    }
}
