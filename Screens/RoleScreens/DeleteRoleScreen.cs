using AcessoDados2.Models;
using AcessoDados2.Repositories;

namespace AcessoDados2.Screens.RoleScreens
{
    public static class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.WriteLine("Excluir um perfil");
            Console.WriteLine("--------------");
            Console.WriteLine("qual o Id do usuário que deseja excluir: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Perfil excluído com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir o perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}