namespace AcessoDados2.Screens.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Gestão de usuários");
                Console.WriteLine("--------------");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine();
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Cadastrar usuários");
                Console.WriteLine("3 - Atualizar usuários");
                Console.WriteLine("4 - Excluir usuários");
                Console.WriteLine();
                Console.WriteLine("ESC para voltar");
                Console.WriteLine();
                
                var option = Console.ReadKey();

                switch (option.Key)
                {
                    case ConsoleKey.D1:
                        ListUserScreen.Load();
                        break;
                    case ConsoleKey.D2:
                        CreateUserScreen.Load();
                        break;
                    case ConsoleKey.D3:
                        UpdateUserScreen.Load();
                        break;
                    case ConsoleKey.D4:
                        DeleteUserScreen.Load();
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