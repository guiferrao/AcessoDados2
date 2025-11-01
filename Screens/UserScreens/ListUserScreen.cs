using AcessoDados2.Models;
using AcessoDados2.Repositories;

namespace AcessoDados2.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.WriteLine("Lista de usuários");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        
        private static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();
            foreach(var item in users)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }
    }
}