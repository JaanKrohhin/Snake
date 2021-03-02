using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snek_ssssssss
{
	class Program
	{
		static void Action(Game game)
		{
			Difficulty diff = new Difficulty(1);
			Score score = new Score();

			Console.BackgroundColor = game.colours[3];
			Console.Clear();
			Music music = new Music();
			if (game.mus == true)
			{
				music.Play();
			}
			Point p = new Point(4, 5, game.syms[0], game.colours[3]);

			Snake snake = new Snake(p, 4, Directions.RIGHT, game.colours[0]);
			snake.Draw();

			Walls walls = new Walls(80, 25, game.syms[2], game.colours[2]);
			walls.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, game.syms[1], game.colours[1]);
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				else if (snake.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
					score.AddPoint(diff.numbers[3]);
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(diff.numbers[0]);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey(true);
					snake.HandleKey(key.Key);
				}
			}
            if (game.mus==true)
            {
				music.Stop();
				music.DeathSound();
            }
			game.WriteGameOver(score.score);
			Thread.Sleep(3000);
			Console.ReadKey(true);
			score.KeepScore();			
		}
		static void Main(string[] args)
		{
			Console.Title = "Snake";
			Game game = new Game();
			while (true)
			{
                game.Menu();
                Action(game);
			}
		}
	}
}
