using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.P.Character
{
    public interface ICharacter
    {
        string Name { get; set; }
        string LastName { get; set; }
        string Nick { get; set; }

        string Childhood { get; set; }
        string Maturity { get; set; }
        string[][] Abilities { get; set; }
        string[] PersonalFeatures{ get; set; }
        public float Size { get; set; }
        public bool IsControllable { get; set; }

    }
}
