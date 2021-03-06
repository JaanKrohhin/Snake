﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_ssssssss
{
    class Snake:Figure
    {
        public Directions direction;
        public ConsoleColor colour;
        public Snake(Point tail, int length, Directions _direction, ConsoleColor colour)
        {
            direction = _direction;
            this.colour = colour;
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail, colour);
                p.Move(i, direction);
                plist.Add(p);
            }
        }
        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);
            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head, colour);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        internal bool IsHitTail()
        {
            var head = plist.Last();
            for (int i = 0; i < plist.Count-2; i++)
            {
                if (head.IsHit(plist[i]))
                    return true;
            }
            return false;
        }
        
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow | key == ConsoleKey.A)
                direction = Directions.LEFT;
            else if (key == ConsoleKey.RightArrow | key == ConsoleKey.D)
                direction = Directions.RIGHT;
            else if (key == ConsoleKey.DownArrow | key == ConsoleKey.S)
                direction = Directions.DOWN;
            else if (key == ConsoleKey.UpArrow | key == ConsoleKey.W)
                direction = Directions.UP;
            else if (key == ConsoleKey.Escape)
                Console.ReadKey(true);
        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                plist.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
