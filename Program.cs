using System;
using AcessoDados2.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace AcessoDados2
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Test;User ID=sa;Password=Vasco748997!;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            //ReadUsers();
            //ReadUser();
            //CreateUser();
            //UpdateUser();
            //DeleteUser();
        }

        public static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>();

                foreach (var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }
        }

        public static void ReadUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);
                Console.WriteLine(user.Name);
            }
        }

        public static void CreateUser()
        {
            var user = new User()
            {
                Bio = "Teste de Create",
                Email = "teste2@gmail.com",
                Image = "https://...",
                Name = "Create teste",
                PasswordHash = "HASH",
                Slug = "teste-create"
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
                Console.WriteLine("Cadastro realizado");
            }
        }

        public static void UpdateUser()
        {
            var user = new User()
            {
                Id = 2,
                Bio = "Teste de Update",
                Email = "teste2@gmail.com",
                Image = "https://...",
                Name = "Update teste",
                PasswordHash = "HASH",
                Slug = "teste-create"
            };
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);
                Console.WriteLine("Usuario alterado com sucesso");
            }
        }
        
        public static void DeleteUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(2);
                connection.Delete<User>(user);
                Console.WriteLine("Usuario removido do banco");
            }
        }
    }
}