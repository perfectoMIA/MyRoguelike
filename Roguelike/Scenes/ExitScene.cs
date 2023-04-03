using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneStructerDemo.Scenes
{
    internal class ExitScene : Scene
    {

        public ExitScene(Game game) : base(game)
        {
        }
        public override void Run()
        {
            string prompt = "Вы дейсвтивельно хотите выйти?";

            string[] option = { "Нет", "Да" };
            Menu menu = new Menu(prompt, option);

            int selectIndex = menu.Run();
            switch (selectIndex)
            {
                case 0:
                    MyGame.Start();
                    break;
                case 1:
                    ConsoleUtils.QuitConsole();
                    break;

            }
        }
    }
}
