using System;
using AcessoDados2.Models;
using AcessoDados2.Repositories;
using Microsoft.Identity.Client;

namespace AcessoDados2.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.WriteLine("Excluir uma tag");
            Console.WriteLine("--------------");
            Console.WriteLine("qual o Id da tag que deseja excluir: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag excluída com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}