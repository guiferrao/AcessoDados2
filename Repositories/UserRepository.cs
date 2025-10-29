using Microsoft.Data.SqlClient;
using AcessoDados2.Models;
using Dapper.Contrib.Extensions;
using System.Data.SqlTypes;
using Microsoft.VisualBasic;
using System.Linq.Expressions;

namespace AcessoDados2.Repositories
{
    public class UserRepository
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<User> Get()
            => _connection.GetAll<User>();

        public User Get(int id)
            => _connection.Get<User>(id);

        public void Create(User user)
        {
            user.Id = 0;
            _connection.Insert<User>(user);
        }

        public void Update(User user)
        {
            if (user.Id != 0)
                _connection.Update<User>(user);
        }

        public void Delete(User user)
        {
            if (user.Id != 0)
                _connection.Delete<User>(user);
        }

        public void Delete(int id)
        {
            if (id != 0)
                return;

            var user = _connection.Get<User>(id);
            _connection.Delete<User>(user);   
        }     
    }
}
