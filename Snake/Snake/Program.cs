using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 25);
            Walls walls= new Walls(80,25);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();

            FoodSpam foodSpam = new FoodSpam(80, 25, '$');
            Point food = foodSpam.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail()) // Проверка на столкновение со стеной и самим собой
                    break;
                if (snake.Eat(food)) // Проверка на встречу с едой
                {
                    food = foodSpam.CreateFood();
                    food.Draw();
                }
                else snake.Move();
                Thread.Sleep(100);
                if (Console.KeyAvailable) // Управление змейкой
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                
            }
            GameOver.WriteGameOver();
            Console.ReadLine();
        }
    }
}
