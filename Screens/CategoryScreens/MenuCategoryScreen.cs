namespace AcessoDados2.Screens.CategoryScreens
{
    public static class MenuCategoryScreen
    {
        public static void Load()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Gestão de Categorias");
                Console.WriteLine("--------------");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine();
                Console.WriteLine("1 - Listar categorias");
                Console.WriteLine("2 - Cadastrar categorias");
                Console.WriteLine("3 - Atualizar categorias");
                Console.WriteLine("4 - Excluir categorias");
                Console.WriteLine();
                Console.WriteLine("ESC para voltar");
                Console.WriteLine();
                
                var option = Console.ReadKey();

                switch (option.Key)
                {
                    case ConsoleKey.D1:
                        ListCategoryScreen.Load();
                        break;
                    case ConsoleKey.D2:
                        CreateCategoryScreen.Load();
                        break;
                    case ConsoleKey.D3:
                        UpdateCategoryScreen.Load();
                        break;
                    case ConsoleKey.D4:
                        DeleteCategoryScreen.Load();
                        break;
                    case ConsoleKey.Escape:
                        running = false;
                        break;
                    default: Load(); break;
                }
            }
        }
    }
}