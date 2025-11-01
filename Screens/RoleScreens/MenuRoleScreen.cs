namespace AcessoDados2.Screens.RoleScreens
{
    public static class MenuRoleScreen
    {
        public static void Load()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Gestão de Perfis");
                Console.WriteLine("--------------");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine();
                Console.WriteLine("1 - Listar perfis");
                Console.WriteLine("2 - Cadastrar perfis");
                Console.WriteLine("3 - Atualizar perfis");
                Console.WriteLine("4 - Excluir perfis");
                Console.WriteLine();
                Console.WriteLine("ESC para voltar");
                Console.WriteLine();
                
                var option = Console.ReadKey();

                switch (option.Key)
                {
                    case ConsoleKey.D1:
                        ListRoleScreen.Load();
                        break;
                    case ConsoleKey.D2:
                        CreateRoleScreen.Load();
                        break;
                    case ConsoleKey.D3:
                        UpdateRoleScreen.Load();
                        break;
                    case ConsoleKey.D4:
                        DeleteRoleScreen.Load();
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