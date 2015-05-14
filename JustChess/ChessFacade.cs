﻿namespace JustChess
{
    using System;

    using Engine;
    using InputProviders;
    using Renderers;
    using Engine.Initializations;

    public static class ChessFacade
    {
        public static void Start()
        {
            var renderer = new ConsoleRenderer();
            // renderer.RenderMainMenu();

            var inputProvider = new ConsoleInputProvider();

            var chessEngine = new StandardTwoPlayerEngine(renderer, inputProvider);

            var gameInitializationStrategy = new StandardStartGameInitializationStrategy();

            chessEngine.Initialize(gameInitializationStrategy);
            chessEngine.Start();

            Console.ReadLine();
        }
    }
}
