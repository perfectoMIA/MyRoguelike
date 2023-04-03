using Roguelike;
using RoguLike2.Scenes;
using rpg_console;
using SceneStructerDemo;
using static RoguLike2.Scenes.MapScene;


Game myGame = new Game();
Console.CursorVisible = false;
Console.Title = "Kingdom Of Darkness";
myGame.Start();
while (true)
{
    Console.WriteLine("хотите начать заново? ");
    string? tmp = Console.ReadLine();
    if (tmp == "yes")
    {
        myGame.Start();
    }
    else
    {
        break;
    }
}



