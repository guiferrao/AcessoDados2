using AcessoDados2.Models;
using AcessoDados2.Repositories;

namespace AcessoDados2.Screens.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.WriteLine("Excluir uma categoria");
            Console.WriteLine("--------------");
            Console.WriteLine("qual o Id da categoria que deseja excluir: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Categoria excluída com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}