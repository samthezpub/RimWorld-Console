using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.P
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenuBuilder mainMenuBuilder = new MainMenuBuilder();
            mainMenuBuilder.AddPoint("Играть", "P");
            mainMenuBuilder.AddPoint("Играть", "P");
            mainMenuBuilder.AddPoint("Играть", "P");
            MainMenu mainMenu = mainMenuBuilder.Build();
            mainMenu.GetListPoints();
        }
    }
    
}
