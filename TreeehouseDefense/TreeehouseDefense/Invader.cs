using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class Invader
    {

        //fields
        private int _pathStep = 0;
        private readonly Path _path;

        //location property
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public int Health { get; private set; } = 2;

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => (Health <= 0);
        public bool IsActive => !(IsNeutralized || HasScored);

        //constructor
        public Invader(Path path)
        {
            _path = path;
        }

        //method
        public void Move() => _pathStep += 1;

        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
    }
}
