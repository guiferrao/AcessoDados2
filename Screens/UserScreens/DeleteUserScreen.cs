using System;
using AcessoDados2.Models;
using AcessoDados2.Repositories;
using Microsoft.Identity.Client;

namespace AcessoDados2.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.WriteLine("Excluir um usuário");
            Console.WriteLine("--------------");
            Console.WriteLine("qual o Id do usuário que deseja excluir: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuário excluído com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}