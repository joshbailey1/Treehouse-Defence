using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = 0.75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccesfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                //shoot if tower is in range of invader and invader is active
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccesfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit an invader");

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    //break so that it only shoots one at a time
                    break;
                }
            }
        }
    }
}
