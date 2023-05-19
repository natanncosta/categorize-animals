using System;

namespace ex1
{
    public class Cow : Animal, IWalk
    {
        public Cow(string name, string owner, string category) : base(name, owner, category)
        {
        }

        public void Walk()
        {
            Console.WriteLine("estah caminhando.");
        }
    }
}
