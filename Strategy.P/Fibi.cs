﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.P
{
    public class  StoryTeller : IStoryTeller
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string StoryTellerType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public StoryTeller(string Name, string Description, string StoryTellerType)
        {
            this.Name = Name;
            this.Description = Description;
            this.StoryTellerType = StoryTellerType;
        }

        public override string ToString()
        {
            new StringBuilder().Append(Name)
                .Append('\t')
                .Append (Description)
                .Append('\t')
        }
    }
}
