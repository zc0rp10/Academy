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
            if (scene != Scene.Starting)
                cki = Console.ReadKey(true);

        }

        private void Draw()
        {
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
                        

                    }
                    break;
                case Scene.Battle:
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
                case Job.Mage: { new Player("Bertil", 200, 10, 10, 10, Job.Fighter); } break;
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
        Battle,
    }

}
