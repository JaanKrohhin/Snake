using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek_ssssssss
{
    class Score : Game
    {
        public int score = 0;
        string temp;
        int tempo;
        string name;
        string[] names = new string[11];
        int[] scores = new int[11];
        public void AddPoint()
        {
            score = score + 1;
        }
        public void KeepScore()
        {
            Console.Clear();
            Main = new string[] { "----------------------", "Enter your name below", "" };
            PrintMenu(Main, xOffset, yOffset);
            Console.SetCursorPosition(xOffset, yOffset + 2);
            name = Console.ReadLine();
            SortBoard();
            WriteScore();
            Board();
        }
        public void SortBoard()
        {
            using (StreamReader f = new StreamReader(@"..\..\leaderboard.txt")) 
            {
                for (int i = 0; i < 10; i++)
                {
                    temp = f.ReadLine();
                    names[i] = temp.Split(' ')[1];
                    scores[i] = Convert.ToInt32(temp.Split(' ')[0]);
                }

            }
            names[10] = name;
            scores[10] = score;
            for (int j = 0; j <= scores.Length - 2; j++)
            {
                for (int i = 0; i <= scores.Length - 2; i++)
                {
                    if (scores[i] < scores[i + 1])
                    {
                        tempo = scores[i + 1];
                        scores[i + 1] = scores[i];
                        scores[i] = tempo;

                        temp = names[i + 1];
                        names[i + 1] = names[i];
                        names[i] = temp;
                    }
                }
            }
            Console.Clear();
        }
        public void WriteScore()
        {
            using (StreamWriter file = new StreamWriter(@"..\..\leaderboard.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    file.WriteLine(scores[i] + " " + names[i]);
                }
            }
        }
        public void Board()
        {
            using (StreamReader file = new StreamReader(@"..\..\leaderboard.txt"))
            {
                WriteText("   LeaderBoard", xOffset, yOffset++);
                WriteText("-----------------", xOffset, yOffset++);
                for (int i = 0; i < 10; i++)
                {
                    WriteText(file.ReadLine(), xOffset, yOffset++);
                }
                WriteText("-----------------", xOffset, yOffset++);
            }
        }
    }
}
