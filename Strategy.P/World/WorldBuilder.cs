using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.P.World
{
    // TODO WorldBuilder
    // Make writing to a file
    public class WorldBuilder : IWorldBuilder
    {
        private World _world;
        public World Build()
        {
            World world = new World();
            return world;
        }

        public void BuildFractionName()
        {
            throw new NotImplementedException();
        }

        public void BuildName()
        {
            throw new NotImplementedException();
        }

        public void BuildSeed()
        {
            throw new NotImplementedException();
        }
    }
}
