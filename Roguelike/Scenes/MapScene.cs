using Roguelike;
using rpg_console;
using SceneStructerDemo;
using SceneStructerDemo.Scenes;
using System.Security.Cryptography.X509Certificates;

namespace RoguLike2.Scenes
{
    internal class MapScene : Scene
    {
        public MapScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            Random random = new Random();
            int lvl = 1;
            //создание карты
            Map map = new Map();
            map.CreateMap();
            //создание торговца
            Trader trader = new Trader();
            trader.RandomPosition(map);
            //создание персонажа
            Person ivan = new Person("Иван", 100, 1, 5, 5, 500, '@');
            char curChar = ivan.RandomPosition(map); //переменная, которая хранит текущую клетку на которой стоял персонаж. 
            int playerX = ivan.X, playerY = ivan.Y; //координаты игрока 
            //рандомная генерация противников 
            List<Enemy> enemy = new List<Enemy>();
            Enemy.RandomGeneration(enemy, map, 10, lvl);
            //рандомная генерация портала
            Portal portal = new Portal();
            portal.RandomPosition(map);
            //передвижение персонажа 
            while (true)
            {
                map.PrintMap();
                ConsoleKey consoleKey = Console.ReadKey(true).Key;
                if (consoleKey == ConsoleKey.W && map.map[playerY - 1, playerX] != ' ')
                {
                    if (map.map[playerY - 1, playerX] == '$')
                    {
                        trader.Start(ivan);
                        map.map[playerY, playerX] = curChar;
                        playerY--;
                        curChar = map.map[playerY, playerX];
                        map.map[playerY, playerX] = '@';
                    }
                    if (map.map[playerY - 1, playerX] == '!')
                    {
                        Console.Clear();
                        for (int i = 0; i < enemy.Count();i++)
                        {   
                            if (enemy[i].X == playerX && enemy[i].Y == playerY - 1)
                            {
                                Fight.Attack2(ivan, enemy[i]);
                                if (ivan.health > 0)
                                {
                                    enemy.RemoveAt(i);
                                    map.map[playerY, playerX] = curChar;
                                    playerY--;
                                    curChar = '.';
                                    map.map[playerY, playerX] = '@';
                                }
                            }
                        }
                        if (ivan.health <= 0)
                        {
                            break;
                        }
                    }
                    if (map.map[playerY - 1, playerX] == 'O')
                    {
                        Enemy.ClearOpponent(enemy, map);
                        map.CreateMap();
                        lvl++;
                        Enemy.RandomGeneration(enemy, map, 10, lvl);
                        trader.RandomPosition(map);
                        curChar = ivan.RandomPosition(map);
                        playerX = ivan.X;
                        playerY = ivan.Y;
                        portal.RandomPosition(map);
                    }
                    else
                    {
                        map.map[playerY, playerX] = curChar;
                        playerY--;
                        curChar = map.map[playerY, playerX];
                        map.map[playerY, playerX] = '@';
                    }
                }
                if (consoleKey == ConsoleKey.A && map.map[playerY, playerX - 1] != ' ')
                {
                    if (map.map[playerY, playerX - 1] == '$')
                    {
                        trader.Start(ivan);
                        map.map[playerY, playerX] = curChar;
                        playerX--;
                        curChar = map.map[playerY, playerX];
                        map.map[playerY, playerX] = '@';
                    }
                    if (map.map[playerY, playerX - 1] == '!')
                    {
                        Console.Clear();
                        for (int i = 0; i < enemy.Count(); i++)
                        {
                            if (enemy[i].X == playerX - 1 && enemy[i].Y == playerY)
                            {
                                Fight.Attack2(ivan, enemy[i]);
                                if (ivan.health > 0)
                                {
                                    enemy.RemoveAt(i);
                                    map.map[playerY, playerX] = curChar;
                                    playerX--;
                                    curChar = '.';
                                    map.map[playerY, playerX] = '@';
                                }
                            }
                        }
                        if (ivan.health <= 0)
                        {
                            break;
                        }
                    }
                    if (map.map[playerY, playerX - 1] == 'O')
                    {
                        Enemy.ClearOpponent(enemy, map);
                        map.CreateMap();
                        lvl++;
                        Enemy.RandomGeneration(enemy, map, 10, lvl);
                        trader.RandomPosition(map);
                        curChar = ivan.RandomPosition(map);
                        playerX = ivan.X;
                        playerY = ivan.Y;
                        portal.RandomPosition(map);
                    }
                    else
                    {
                        map.map[playerY, playerX] = curChar;
                        playerX--;
                        curChar = map.map[playerY, playerX];
                        map.map[playerY, playerX] = '@';
                    }
                }
                if (consoleKey == ConsoleKey.D && map.map[playerY, playerX + 1] != ' ')
                {
                    if (map.map[playerY, playerX + 1] == '$')
                    {
                        trader.Start(ivan);
                        map.map[playerY, playerX] = curChar;
                        playerX++;
                        curChar = map.map[playerY, playerX];
                        map.map[playerY, playerX] = '@';
                    }
                    if (map.map[playerY, playerX + 1] == '!')
                    {
                        Console.Clear();
                        for (int i = 0; i < enemy.Count(); i++)
                        {
                            if (enemy[i].X == playerX + 1 && enemy[i].Y == playerY)
                            {
                                Fight.Attack2(ivan, enemy[i]);
                                if (ivan.health > 0)
                                {
                                    enemy.RemoveAt(i);
                                    map.map[playerY, playerX] = curChar;
                                    playerX++;
                                    curChar = '.';
                                    map.map[playerY, playerX] = '@';
                                }
                            }
                        }
                        if (ivan.health <= 0)
                        {
                            break;
                        }
                    }
                    if (map.map[playerY, playerX + 1] == 'O')
                    {
                        Enemy.ClearOpponent(enemy, map);
                        map.CreateMap();
                        lvl++;
                        Enemy.RandomGeneration(enemy, map, 10, lvl);
                        trader.RandomPosition(map);
                        curChar = ivan.RandomPosition(map);
                        playerX = ivan.X;
                        playerY = ivan.Y;
                        portal.RandomPosition(map);
                    }
                    else
                    {
                        map.map[playerY, playerX] = curChar;
                        playerX++;
                        curChar = map.map[playerY, playerX];
                        map.map[playerY, playerX] = '@';
                    }
                }
                if (consoleKey == ConsoleKey.S && map.map[playerY + 1, playerX] != ' ')
                {
                    if (map.map[playerY + 1, playerX] == '$')
                    {
                        trader.Start(ivan);
                        map.map[playerY, playerX] = curChar;
                        playerY++;
                        curChar = map.map[playerY, playerX];
                        map.map[playerY, playerX] = '@';
                    }
                    if (map.map[playerY + 1, playerX] == '!')
                    {
                        Console.Clear();
                        for (int i = 0; i < enemy.Count(); i++)
                        {
                            if (enemy[i].X == playerX && enemy[i].Y == playerY + 1)
                            {
                                Fight.Attack2(ivan, enemy[i]);
                                if (ivan.health > 0)
                                {
                                    enemy.RemoveAt(i);
                                    map.map[playerY, playerX] = curChar;
                                    playerY++;
                                    curChar = '.';
                                    map.map[playerY, playerX] = '@';
                                }
                            }
                        }
                        if (ivan.health <= 0)
                        {
                            break;
                        }
                    }
                    if (map.map[playerY + 1, playerX] == 'O')
                    {
                        Enemy.ClearOpponent(enemy, map);
                        map.CreateMap();
                        lvl++;
                        Enemy.RandomGeneration(enemy, map, 10, lvl);
                        trader.RandomPosition(map);
                        curChar = ivan.RandomPosition(map);
                        playerX = ivan.X;
                        playerY = ivan.Y;
                        portal.RandomPosition(map);
                    }
                    else
                    {
                        map.map[playerY, playerX] = curChar;
                        playerY++;
                        curChar = map.map[playerY, playerX];
                        map.map[playerY, playerX] = '@';
                    }
                }
                ivan.X = playerX;
                ivan.Y = playerY;
                foreach (Enemy i in enemy)
                {
                    i.RandomMovement(map);
                }
            }
            Console.Clear();
        }
    }
}



