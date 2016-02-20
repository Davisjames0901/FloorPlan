using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DB.DataAccess;
using System.Data.Linq;
using System.Data;
using Contracts.DataContracts;
using Contracts.Helpers;

namespace ServiceImplementations
{
    public class UserService
    {
        private readonly IPVRTourEntities _db;
        public UserService()
        {
            _db = new IPVRTourEntities();
        }

        public UserData Get(int id)
        {
            return DataMapper.UserDBToCode(_db.Users
                .AsNoTracking()
                .SingleOrDefault(x=>x.Id == id));
        }

        public List<UserData> GetAll()
        {
            return _db.Users
                .AsNoTracking()
                .Select(DataMapper.UserDBToCode)
                .ToList();
        }

        public int Create(UserData data)
        {
            var dbItem = DataMapper.UserCodeToDB(data);

            _db.Users.Add(dbItem);
            _db.SaveChanges();

            return dbItem.Id;
        }

        public void Update(UserData data)
        {
            var dbItem = _db.Users.SingleOrDefault(x=>x.Id == data.Id);

            dbItem.Password = data.Password;
            dbItem.UserName = data.UserName;

            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var dbItem = _db.Users.SingleOrDefault(x => x.Id == id);

            _db.Users.Remove(dbItem);

            _db.SaveChanges();
        }
    }
}
