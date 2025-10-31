using System;
using AcessoDados2.Models;
using AcessoDados2.Repositories;
using Microsoft.Identity.Client;

namespace AcessoDados2.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.WriteLine("Nova tag");
            Console.WriteLine("--------------");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }
        
        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag cadastrada com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}