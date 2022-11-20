using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IContext _context;
        public RoleRepository(IContext context)
        {
            _context = context;
        }
        public Role Add(int id, string name, string description)
        {
            Role r = new Role { Id = id, Name = name, Description = description };
            _context.Roles.Add(r);
            return r;
        }

        public void Delete(int id)
        {
            _context.Roles.Remove(_context.Roles.Find(r => r.Id == id));
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(int id)
        {
            return _context.Roles.Find(r => r.Id == id);
        }

        public Role Update(Role role)
        {
            var r1 = _context.Roles.Find(r => r.Id == role.Id);
            r1.Name = role.Name;
            r1.Description = role.Description;
            return r1;
        }
    }
}
