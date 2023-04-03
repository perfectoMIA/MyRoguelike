using static System.Console;
using SceneStructerDemo.Scenes;
using static RoguLike2.Scenes.MapScene;


namespace SceneStructerDemo
{
    
    class TitleScene : Scene
    {
        string TitleArt = @"
██╗░░██╗██╗███╗░░██╗░██████╗░██████╗░░█████╗░███╗░░░███╗  ░█████╗░███████╗
██║░██╔╝██║████╗░██║██╔════╝░██╔══██╗██╔══██╗████╗░████║  ██╔══██╗██╔════╝
█████═╝░██║██╔██╗██║██║░░██╗░██║░░██║██║░░██║██╔████╔██║  ██║░░██║█████╗░░
██╔═██╗░██║██║╚████║██║░░╚██╗██║░░██║██║░░██║██║╚██╔╝██║  ██║░░██║██╔══╝░░
██║░╚██╗██║██║░╚███║╚██████╔╝██████╔╝╚█████╔╝██║░╚═╝░██║  ╚█████╔╝██║░░░░░
╚═╝░░╚═╝╚═╝╚═╝░░╚══╝░╚═════╝░╚═════╝░░╚════╝░╚═╝░░░░░╚═╝  ░╚════╝░╚═╝░░░░░

██████╗░░█████╗░██████╗░██╗░░██╗███╗░░██╗███████╗░██████╗░██████╗
██╔══██╗██╔══██╗██╔══██╗██║░██╔╝████╗░██║██╔════╝██╔════╝██╔════╝
██║░░██║███████║██████╔╝█████═╝░██╔██╗██║█████╗░░╚█████╗░╚█████╗░
██║░░██║██╔══██║██╔══██╗██╔═██╗░██║╚████║██╔══╝░░░╚═══██╗░╚═══██╗
██████╔╝██║░░██║██║░░██║██║░╚██╗██║░╚███║███████╗██████╔╝██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝╚═════╝░╚═════╝░
";
        public TitleScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            // WriteLine("Пролог начинается");      
            string promt = $@"{TitleArt}
Добро пожаловать в игру. Что будешь делать?

(Управление на 'w a s d' и Enter для выбора.)";

            string[] options = { "Играть", "Об игре", "Выйти" };//  строки главного меню
            Menu menu = new Menu(promt, options);
            int selectedIndex = menu.Run();
            switch (selectedIndex) // как туда попадаем
            {
                case 0:
                    Clear();
                    MyGame.MyMapScene.Run();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    MyGame.MyExitScene.Run();
                    break;

            }
        }


        private void DisplayAboutInfo() // инфа об игре
        {
            Clear();
            WriteLine(@"Напишите свою историю!
");

            ConsoleUtils.WaitForKeyPress();
            Run();
        }

    }
}
