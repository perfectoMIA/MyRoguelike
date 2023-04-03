using System;
using SceneStructerDemo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using SceneStructerDemo.Scenes;
using RoguLike2.Scenes;
using static RoguLike2.Scenes.MapScene;

namespace SceneStructerDemo
{
    class Game
    {
        public ExitScene Scene;
        public TitleScene MyTitleScene;        
        public MapScene MyMapScene;
        public ExitScene MyExitScene { get; }

        public Game()
        {
            MyTitleScene = new TitleScene(this);
            MyExitScene = new ExitScene(this);
            MyMapScene = new MapScene(this);
            Map map = new Map();
        }
        public void Start()
        {
            MyTitleScene.Run();
        }
    }
}
