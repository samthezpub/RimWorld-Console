using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.P
{
    public class MainMenuBuilder : IMenuBuilder
    {
        private List<Point> Points = new List<Point>();
        public void AddPoint(string pointTitle, string PointCommand)
        {
            Point point = new Point(pointTitle, PointCommand);
            Points.Append(point);
        }

        public MainMenu Build()
        {
            MainMenu _menu = new MainMenu(Points);
            return _menu;
        }
    }
}
