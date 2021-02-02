using System;
using System.Collections.Generic;
using System.Text;

namespace NotAnotherRPG
{
    class Game
    {
        bool game = true;
        Player player;
        Scene scene;

        public Game()
        {
            scene = Scene.Starting;
        }

        public void Run()
        {
            // Game Constructor

            // Initialize()

            // LoadContent()

            while (game != false)
            {
                // (GetInput) Update()
                Update();

                // UpdateWorld?

                // (Render)Draw()
                Draw();
            }
        }

        private void Update()
        {
            ConsoleKeyInfo cki;

            switch (scene)
            {
                case Scene.Starting:
                    {

                    }
                    break;
                case Scene.Paused:
                    {

                    }
                    break;
                case Scene.MainMenu:
                    {
                        cki = Console.ReadKey(true);
                        if (cki.Key == ConsoleKey.N)
                            scene = Scene.CharacterCreation;
                        if (cki.Key == ConsoleKey.C)
                            Console.WriteLine("Continue");
                    }
                    break;
                case Scene.CharacterCreation:
                    {
                        Console.WriteLine("Select a class");
                        Console.WriteLine("[F]ighter");
                        Console.WriteLine("[T]hief");
                        Console.WriteLine("[R]ed Mage");
                    }
                    break;
                case Scene.Battle:
                    {

                    }
                    break;
            }

        }

        private void Draw()
        {
            Console.Clear();
            switch (scene)
            {
                case Scene.Starting:
                    {
                        Renderer.SplashScreen();
                        scene = Scene.MainMenu;
                    }
                    break;
                case Scene.MainMenu:
                    {
                        Renderer.MainMenu();
                    }
                    break;
                case Scene.CharacterCreation:
                    {

                    }
                    break;
                case Scene.Battle:
                    {

                    }
                    break;
            }
        }

        public void SetGameStart(Job job)
        {
            resetPlayer(job);
            setPreFight();
        }

        void resetPlayer(Job job)
        {
            switch (job)
            {
                case Job.Fighter: { new Player("Bertil", 200, 10, 10, 10, Job.Fighter); } break;
                case Job.Thief: { new Player("Bertil", 200, 10, 10, 10, Job.Fighter); } break;
                case Job.RedMage: { new Player("Bertil", 200, 10, 10, 10, Job.Fighter); } break;
            }
        }

        void setPreFight()
        {

        }

    }

    enum Scene
    {
        Starting,
        Paused,
        MainMenu,
        CharacterCreation,
        Battle,
    }

}
