using MvxForms.Core.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MvxForms.Core.Services
{
    internal class UserService : IUserService
    {
        public List<User> GetUsers()
        {
            var mUsers = new List<User>();
            mUsers.Add(new User
            {
                Name = "Blake Toliman",
                Email = "BlakeToliman@teleworm.us",
            });
            mUsers.Add(new User
            {
                Name = "Joel Arden",
                Email = "JoelArden@rhyta.com",
            });

            mUsers.Add(new User
            {
                Name = "Emily Fallon",
                Email = "EmilyFallon@teleworm.us",
            });

            mUsers.Add(new User
            {
                Name = "Sam Fowler",
                Email = "SamFowler@rhyta.com",
            });

            mUsers.Add(new User
            {
                Name = "Kayla Ashbolt",
                Email = "KaylaAshbolt@rhyta.com",
            });

            mUsers.Add(new User
            {
                Name = "Leo Deering",
                Email = "LeoDeering@rhyta.com",
            });
            return mUsers;
        }
    }
}
