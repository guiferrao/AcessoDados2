using System;
using System.Linq.Expressions;
using AcessoDados2.Models;
using AcessoDados2.Repositories;
using Azure.Core.Pipeline;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace AcessoDados2
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Test;User ID=sa;Password=Password123;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            //ReadUsers(connection);
            //ReadRoles(connection);
            //ReadTags(connection);
            //CreateUsers(connection);
            //CreateTags(connection);
            //CreateRoles(connection);
            //UpdateUsers(connection);
            //UpdateTags(connection);
            //UpdateRoles(connection);
            //DeleteUser(connection);
            //DeleteRole(connection);
            //DeleteTag(connection);
            ReadUserWithRoles(connection);
    
            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }

        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }

        public static void ReadTags(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }

        public static void CreateUsers(SqlConnection connection)
        {
            var user = new User()
            {
                Bio = "Teste de Create 3",
                Email = "teste3@gmail.com",
                Image = "https://...",
                Name = "Create teste 2",
                PasswordHash = "HASH",
                Slug = "teste-create-2"
            };
            var repository = new Repository<User>(connection);
            repository.Create(user);
            Console.WriteLine("usuario criado com sucesso");
        }

        public static void CreateTags(SqlConnection connection)
        {
            var tag = new Tag()
            {
                Name = "Create Tag teste",
                Slug = "teste-tag"
            };
            var repository = new Repository<Tag>(connection);
            repository.Create(tag);
            Console.WriteLine("tag criado com sucesso");
        }

        public static void CreateRoles(SqlConnection connection)
        {
            var role = new Role()
            {
                Name = "Create Role teste",
                Slug = "teste-role"
            };

            var repository = new Repository<Role>(connection);
            repository.Create(role);
            Console.WriteLine("Role criado com sucesso");
        }

        public static void UpdateUsers(SqlConnection connection)
        {
            var user = new User()
            {
                Id = 1002,
                Bio = "Teste de Update 3",
                Email = "Update3@gmail.com",
                Image = "https://...",
                Name = "Create Update 2",
                PasswordHash = "HASH",
                Slug = "teste-update-2"
            };

            var repository = new Repository<User>(connection);
            repository.Update(user);
            Console.WriteLine($"O usuario {user.Id} foi atualizado");
        }

        public static void UpdateTags(SqlConnection connection)
        {
            var tag = new Tag()
            {
                Id = 2,
                Name = "Update tag 2",
                Slug = "teste-update-tag-2"
            };

            var repository = new Repository<Tag>(connection);
            repository.Update(tag);
            Console.WriteLine($"A tag {tag.Id} foi atualizado");
        }

        public static void UpdateRoles(SqlConnection connection)
        {
            var role = new Role()
            {
                Id = 2,
                Name = "Update Role 2",
                Slug = "teste-update-role-2"
            };

            var repository = new Repository<Role>(connection);
            repository.Update(role);
            Console.WriteLine($"A Role {role.Id} foi atualizado");
        }

        public static void DeleteUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var user = repository.Get(1002);
            repository.Delete(user);
            Console.WriteLine("usuario deletado");
        }

        public static void DeleteTag(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var tag = repository.Get(2);
            repository.Delete(tag);
            Console.WriteLine("tag deletado");
        }

        public static void DeleteRole(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var role = repository.Get(2);
            repository.Delete(role);
            Console.WriteLine("role deletado");
        }
        
        public static void ReadUserWithRoles(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var items = repository.GetWithRoles();

            foreach(var item in items)
            {
                Console.WriteLine(item.Name);
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($" - {role.Name}");
                }
            }
        }
    }
}