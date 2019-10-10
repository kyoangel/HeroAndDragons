using System;
using System.Threading;

namespace HeroAndDragons
{
    internal class Game
    {
        public void Run()
        {
            Console.WriteLine("Hello Game!");
            var boss = new Boss(100);
            while (boss.Hp >0)
            {
                Thread.Sleep(100);
                boss.Hp -= 1;
                Console.WriteLine($"Boss Hp:{boss.Hp}");
            }

            Console.WriteLine("You Win!");
            Console.ReadLine();
        }
    }

    internal class Boss
    {
        private int _hp;

        public Boss(int hp)
        {
            _hp = hp;
        }

        public int Hp
        {
            get => _hp;
            set => _hp = value;
        }
    }
}