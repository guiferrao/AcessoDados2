using AcessoDados2.Models;
using AcessoDados2.Repositories;

namespace AcessoDados2.Screens.RoleScreens
{
    public static class ListRoleScreen
    {
        public static void Load()
        {
            Console.WriteLine("Lista de perfis");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }
        
        private static void List()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.Get();
            foreach(var item in roles)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }
    }
}