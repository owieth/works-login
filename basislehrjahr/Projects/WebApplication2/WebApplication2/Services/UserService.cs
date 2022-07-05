using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class UserService : DbService<ApplicationUser>
    {
        private DbSet<ApplicationUser> _applicationUsers;

        public UserService(ApplicationDbContext context) : base(context)
        {
            _applicationUsers = _dbContext.Set<ApplicationUser>();
        }


        public ApplicationUser GetUserById(string id)
        {
            return _applicationUsers.FirstOrDefault(user => user.Id == id); //lambda expression //first or default gibt null zurpck wenn nichts gefunden
            //sucht nach benutzer mit der id, falls kein benutzer gefunden wird, wird null zurückgegeben 
            //dbcontext = db verbindung
            //set = auflistung
            //alles ab first or default ist wie select abfrage
        }

        public ApplicationUser GetUserByLastName(string lastName)
        {
            return _applicationUsers.Where(user => user.LastName == lastName).ToList();
        }

        public ApplicationUser AddUser(string newUser)
        {
            return _applicationUsers.FirstOrDefault(user => user.UserName == newUser);
        }
    }
}
