using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_ssssssss
{
    class Game
    {
		ConsoleKeyInfo key;	
        public int xOffset = 25;
        public int yOffset = 8;
		string[] Main;
		public ConsoleColor colour = ConsoleColor.Gray;
		public char snake = '*';
		public char wall = '+';
		public char food = '$';

        public void Menu()
        {
			do
			{
				Main = new string[] { "-----------------", "1 - Start", "2 - Settings", "3 - Difficulty", "4 - Quit" };
				PrintMenu(Main, xOffset, yOffset);
				key = Console.ReadKey(true);
				if (key.Key == ConsoleKey.D1)
                {
					break;
                }
                else if (key.Key==ConsoleKey.D2)
                {
					Main = new string[] { "-----------------", "1 - Sky Preset", "2 - Rock Preset", "3 - Snow Preset", "4 - Back" };
					Settings();
				}
                else if (key.Key == ConsoleKey.D3)
                {
					Main = new string[] { "-----------------", "1 - Easy", "2 - Medium", "3 - Hard", "4 - Back" };
					PrintMenu(Main, xOffset, yOffset);
					key = Console.ReadKey(true);
				}
				else if (key.Key == ConsoleKey.D4)
                {
					Environment.Exit(0);
				}
			} while (true);
			Console.Clear();
		}
		private void Settings()
        {
            do
            {
				PrintMenu(Main, xOffset, yOffset);
				key = Console.ReadKey(true);
				if (key.Key == ConsoleKey.D1)
				{
					Console.BackgroundColor = ConsoleColor.Black;
					Console.ForegroundColor = ConsoleColor.Gray;
					colour = ConsoleColor.Blue;
					snake = '*';
					wall = '#';
					food = '¤';
				}
				else if (key.Key == ConsoleKey.D2)
				{
					colour = ConsoleColor.Black;
					Console.BackgroundColor = ConsoleColor.White;
					Console.ForegroundColor = ConsoleColor.Black;
					snake = '*';
					wall = '?';
					food = '@';
				}
				else if (key.Key == ConsoleKey.D3)
				{
					Console.BackgroundColor = ConsoleColor.Black;
					Console.ForegroundColor = ConsoleColor.Gray;
					colour = ConsoleColor.White;
					snake = '*';
					wall = '+';
					food = '$';
				}
				else if (key.Key == ConsoleKey.D4)
				{
					break;
				}
			} while (true);
		}
		public void WriteGameOver()
		{
			Main = new string[] { "================================", "G A M E	O V E R", "Autor: Evgenij Kartavec and TARpv20","Press any key to continue"};
			PrintMenu(Main, xOffset, yOffset);
		}

		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
        static void PrintMenu(string[] M,int xOffset, int yOffset)
        {
			Console.Clear();
            for (int i = 0; i < M.Length; i++)
            {
				WriteText(M[i], xOffset, yOffset++);
            }
		WriteText(M[0], xOffset, yOffset++);
		}
	}
}
