namespace AcessoDados2.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Gestão de tags");
                Console.WriteLine("--------------");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine();
                Console.WriteLine("1 - Listar tags");
                Console.WriteLine("2 - Cadastrar tags");
                Console.WriteLine("3 - Atualizar tags");
                Console.WriteLine("4 - Excluir tags");
                Console.WriteLine();
                Console.WriteLine("ESC para voltar");
                Console.WriteLine();
                
                var option = Console.ReadKey();

                switch (option.Key)
                {
                    case ConsoleKey.D1:
                        ListTagScreen.Load();
                        break;
                    case ConsoleKey.D2:
                        CreateTagScreen.Load();
                        break;
                    case ConsoleKey.D3:
                        UpdateTagScreen.Load();
                        break;
                    case ConsoleKey.D4:
                        DeleteTagScreen.Load();
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