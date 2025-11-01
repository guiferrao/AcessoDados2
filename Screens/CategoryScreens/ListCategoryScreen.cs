using AcessoDados2.Models;
using AcessoDados2.Repositories;

namespace AcessoDados2.Screens.CategoryScreens
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            Console.WriteLine("Lista de perfis");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
        
        private static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.Get();
            foreach(var item in categories)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }
    }
}