using System;
using System.Collections.Generic;
using System.Text;

namespace TreeehouseDefense
{
    class Path
    {
        private MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        public bool OnPath(int X, int Y)
        {
            //returns true if point is on the path
            foreach (MapLocation maplocation in _path)
            {
                if (maplocation.X == X && maplocation.Y == Y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
