using Microsoft.AspNetCore.Mvc;
using SmartStore.DB;
using SmartStore.Helpers;
using SmartStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Repository
{
    public class UserRepository : GenericRepository<User>
    {
        private IUserService _userService;

        public UserRepository([FromServices] IUserService userService)
        {
            this._userService = userService;
        }

        public override User Create(User toSave) {
            try
            {
                using (var db = new MyAppContext())
                {
                    if (db.Users.Count<User>(u => u.UserName == toSave.UserName || u.Email == toSave.Email) > 0)
                    {
                        throw new Exception("Usuário ou email já cadastrado");
                    }

                    return base.Create(toSave);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public User Auth(User toLoggin)
        {
            using (var db = new MyAppContext())
            {
                return _userService.Authenticate(_userService, db, toLoggin.UserName, toLoggin.Password);
            }
        }

    }
}
