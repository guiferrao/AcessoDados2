using AcessoDados2.Screens.CategoryScreens;
using AcessoDados2.Screens.RoleScreens;
using AcessoDados2.Screens.TagScreens;
using AcessoDados2.Screens.UserScreens;
using Microsoft.Data.SqlClient;

namespace AcessoDados2
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Test;User ID=sa;Password=Password123;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }
        private static void Load()
        {
            bool running = true;
            
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Meu Site");
                Console.WriteLine("--------------");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine();
                Console.WriteLine("1 - Gestão de Usuário");
                Console.WriteLine("2 - Gestão de Perfil");
                Console.WriteLine("3 - Gestão de categoria");
                Console.WriteLine("4 - Gestão de tag");
                Console.WriteLine("5 - Vincular perfil/usuário");
                Console.WriteLine("6 - Vincular post/tag");
                Console.WriteLine("7 - relatórios");
                Console.WriteLine();
                Console.WriteLine("ESC para sair");
                Console.WriteLine();
  
                var option = Console.ReadKey();

                switch (option.Key)
                {
                    case ConsoleKey.D1:
                        MenuUserScreen.Load();
                        break;
                    case ConsoleKey.D2:
                        MenuRoleScreen.Load();
                        break;
                    case ConsoleKey.D3:
                        MenuCategoryScreen.Load();
                        break;
                    case ConsoleKey.D4:
                        MenuTagScreen.Load();
                        break;
                    case ConsoleKey.D5:
                        //UserRoleScreen.Load();
                        break;
                    case ConsoleKey.D6:
                        //PostTagScreen.Load();
                        break;
                    case ConsoleKey.D7:
                        //RelatoryScreen.Load();
                        break;
                    case ConsoleKey.Escape:
                        running = false;
                        break;
                    default: Load();  break;
                }
            }
        }
    }
}
