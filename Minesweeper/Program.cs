using System;
using System.Collections;
using System.Collections.Generic;

namespace Minesweeper
{
    class Program
    {
        const int _mine = -1;
        static readonly int _height = Console.WindowHeight;
        static readonly int _width = Console.WindowWidth;
        static readonly Random _random = new Random();
        static readonly float _mineRatio = .1f;
        static readonly int _mineCount = (int)(_width * _height * _mineRatio);
        static (int Value, bool Visible)[,] _board;
        static (int Column, int Row) _position = (_width / 2, _height / 2);
        private enum ExitState { Win, Lose, Quit };

        static void Main()
        {
            //GenerateBoard(); //zet het bord op
            //RenderBoard(); // hertekent het bord
            //EventLoop(); //leest input gebruiker
        }
        private static bool IsConsoleResized()
        {
            if (Console.WindowHeight != _height || Console.WindowWidth != _width)
            {
                Console.Clear();
                Quit(ExitState.Quit, "Console resized: Minesweeper is closed.");
                return true;
            }
            return false;
        }

        private static void Quit(ExitState state, string message)
        { }
        private static void PlaySound(string path)
        { }
        private static void EventLoop()
        { }
        static IEnumerable<(int Row, int Column)> AdjacentTiles (int column, int row) { }
        private static void GenerateBoard()
        {//we initialiseren het bord: een array van int/bool tuples (een tuple: combo van 2 elementen, tussen..
            _board = new (int Value, bool Visible)[_width, _height];
            var coordinates = new List<(int Row, int Column)>(); // lijst laat toe te weten waar al een mijn staat
            // Iinitalisatie van lijst en coordinaten : voor elke cel op het bord maken we een coordinaat aan

            for (int column = 0; column < _width; column++)
            {
                for (int row = 0; row < _height; row++)
                {
                    coordinates.Add((column, row));
                }
            }
            for (int i = 0; i < _mineCount; i++)
            {
                //op deze coordinaat wordt een mijn geplaatst...
                int randomIndex = _random.Next(0, coordinates.Count);
                (int Column, int Row) = coordinates[randomIndex];
                //verwijder de coordinaat uit de lijst om te voorkomen dat er nog eens een mijn op komt
                coordinates.RemoveAt(randomIndex);
                //Mijn plaatsen en visible is false: cel onzichtbaar bij opstarten
                _board[Column, Row] = (_mine, false);
                //bereken hoeveel mijnen er grenzen aan onze cel
                foreach (var tile in AdjacentTiles(Column, Row))
                {
                    if (_board[tile.Column, tile.Row].Value != _mine)
                    {
                        _board[tile.Column, tile.Row].Value++;
                    }
                }
            }
        }
    }
}
