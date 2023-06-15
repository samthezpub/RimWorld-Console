using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.P
{
    public interface IMenuBuilder
    {
        void AddPoint(string pointTitle, string PointCommand);
        MainMenu Build();
    }
}
