using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.P
{
    public class Point
    {
        public string Title { get; set; }
        public string Command { get; set; }
        public Point(string title, string command) 
        { 
            this.Title = title;
            this.Command = command;
        }


    }
}
