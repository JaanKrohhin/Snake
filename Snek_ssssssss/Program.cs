using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snek_ssssssss
{
	class Program
    {
		static void Main(string[] args)
		{
			Console.Title = "Snake";
			Console.SetWindowSize(80, 25);

			Game game = new Game();
			game.Menu();

			Point p = new Point(4, 5, game.snake, game.colour);

            Snake snake = new Snake(p, 4, Directions.RIGHT, game.colour);
			snake.Draw();

			Walls walls = new Walls(80, 25, game.wall, game.colour);
			walls.Draw();


			FoodCreator foodCreator = new FoodCreator(80, 25, game.food, game.colour);
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
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			game.WriteGameOver();
			Console.ReadLine();
		}
	}
}