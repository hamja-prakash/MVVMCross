using MvxForms.Core.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MvxForms.Core.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}
