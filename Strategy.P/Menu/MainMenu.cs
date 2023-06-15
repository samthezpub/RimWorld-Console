using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.P
{
    public class MainMenu : IMenu
    {
        List<Point> Points { get; set; }
        public List<Point> GetListPoints()
        { return Points; }
        public void ShowMenu()
        {
            foreach (var point in Points)
            {
                Console.WriteLine("${0} - ${1}", point.Title, point.Command);
            }
        }


        public MainMenu(List<Point> Points) 
        { 
            this.Points = Points;
        }

    }
}
