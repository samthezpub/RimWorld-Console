namespace Strategy.P.Character
{
    public class PlayerCharacter : ICharacter
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nick { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Childhood { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Maturity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string[][] Abilities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string[] PersonalFeatures { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Size { get; set; }
        public bool IsControllable { get=> this.IsControllable; set => this.IsControllable = true; }

    }
}
