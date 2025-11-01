using AcessoDados2.Models;
using AcessoDados2.Repositories;

namespace AcessoDados2.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.WriteLine("Novo usuário");
            Console.WriteLine("--------------");
            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();

            Console.WriteLine("Email: ");
            var email = Console.ReadLine();

            Console.WriteLine("Senha: ");
            var passwordHash = Console.ReadLine();

            Console.WriteLine("Resumo sobre voce: ");
            var bio = Console.ReadLine();

            Console.WriteLine("Sua foto: ");
            var image = Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new User
            {
                Name = name,
                Email = email,
                PasswordHash = passwordHash,
                Bio = bio,
                Image = image,
                Slug = slug
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }
        
        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuário cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}