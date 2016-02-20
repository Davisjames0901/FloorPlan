using Contracts.DataContracts;
using DB.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Helpers
{
    public class DataMapper
    {
        #region User
        public static readonly Func<UserData, User> UserCodeToDB = m => new User
        {
            Id = m.Id,
            UserName = m.UserName,
            Password = m.Password
        };

        public static readonly Func<User, UserData> UserDBToCode = m => new UserData
        {
            Id = m.Id,
            UserName = m.UserName,
            Password = m.Password
        };

        #endregion
    }
}
