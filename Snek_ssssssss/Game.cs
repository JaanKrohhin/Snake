using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_ssssssss
{
    class Game
    {
		ConsoleKeyInfo key;
		public bool mus = true;
		public int dif = 1;
        public int xOffset = 25;
        public int yOffset = 8;
		public string[] Main;
		public ConsoleColor[] colours= {ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Black,};//0=snake,1=food,2=walls,3=background
		public char[] syms = {'*','$','+'};//0=snake,1=food,2=walls

        public void Menu()
        {
			Console.SetWindowSize(80, 25);
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			do
			{ 
				Console.SetWindowSize(80, 25);
				Main = new string[] { "-----------------", "1 - Start", "2 - Settings", "3 - Difficulty","4 - Leaderboard", "5 - Quit" };
				PrintMenu(Main, xOffset, yOffset);
				key = Console.ReadKey(true);
				if (key.Key == ConsoleKey.D1)
                {
					break;
                }
                else if (key.Key==ConsoleKey.D2)
                {
					Main = new string[] { "-----------------", "1 - Sky Preset", "2 - Rock Preset", "3 - Snow Preset","4 - Sound off", "5 - Back" };
					Settings();
				}
                else if (key.Key == ConsoleKey.D3)
                {
					Main = new string[] { "-----------------", "1 - Easy", "2 - Medium", "3 - Hard", "4 - Back" };
					Difficulty();
				}
				else if (key.Key == ConsoleKey.D4)
				{
					Console.Clear();
					Board();
				}
				else if (key.Key == ConsoleKey.D5)
				{
					Environment.Exit(0);
				}
			} while (true);
		}
		private void Settings()
        {
            do
            {
				PrintMenu(Main, xOffset, yOffset);
				key = Console.ReadKey(true);
				if (key.Key == ConsoleKey.D1)
				{
					colours = new ConsoleColor[] {ConsoleColor.DarkBlue, ConsoleColor.DarkBlue,ConsoleColor.White,ConsoleColor.Cyan};
					syms = new char[] {'=','¤','#'};
				}
				else if (key.Key == ConsoleKey.D2)
				{
					colours = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.White };
					syms = new char[] { '¤','?','@'};
				}
				else if (key.Key == ConsoleKey.D3)
				{
					colours = new ConsoleColor[] { ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.Black};
					syms = new char[] { '%','1','0'};
				}
				else if (key.Key == ConsoleKey.D4)
				{
					mus = !mus;
					if (mus == false)
						Main[4] = "4 - Sound on";
					else
						Main[4] = "4 - Sound off";
				}
				else if (key.Key == ConsoleKey.D5)
				{
					break;
				}
			} while (true);
		}
		public void Difficulty()
        {
            do
            {
				PrintMenu(Main, xOffset, yOffset);
				key = Console.ReadKey(true);
				if (key.Key == ConsoleKey.D1)
                {
					dif = 1;
				}
				else if (key.Key == ConsoleKey.D2)
				{
					dif = 2;
				}
				else if (key.Key == ConsoleKey.D3)
				{
					dif = 3;
				}
				else if (key.Key == ConsoleKey.D4)
				{
					break;
				}

			} while (true);

		}
		public void WriteGameOver(int score)
		{
			Console.SetWindowSize(80, 25);
			Main = new string[] { "================================", "G A M E	O V E R", "Autor: Evgenij Kartavec and TARpv20", "", "Your score is "+score,"Press any key to continue"};
			PrintMenu(Main, xOffset, yOffset);
		}

		public void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
        public void PrintMenu(string[] M,int xOffset, int yOffset)
        {
			Console.Clear();
            for (int i = 0; i < M.Length; i++)
            {
				WriteText(M[i], xOffset, yOffset++);
            }
		WriteText(M[0], xOffset, yOffset++);
		}
		public void Board()
		{
			using (StreamReader file = new StreamReader(@"..\..\leaderboard.txt"))
			{
				WriteText("   LeaderBoard", xOffset, yOffset);
				WriteText("-----------------", xOffset, yOffset+1);
				for (int i = 0; i < 10; i++)
				{
					WriteText(file.ReadLine(), xOffset, yOffset+2+i);
				}
				WriteText("-----------------", xOffset, yOffset+12);
			}
			Console.ReadKey(true);

		}
	}

}
