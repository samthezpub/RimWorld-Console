using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.P.World
{
    public interface IWorldBuilder
    {
        void BuildName();
        void BuildSeed();
        void BuildFractionName();

        public World Build();
    }
}
