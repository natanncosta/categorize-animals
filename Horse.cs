using System;

namespace ex1
{
    public class Horse : Animal, IWalk
    {
        public Horse(string name, string owner, string category) : base(name, owner, category)
        {
        }

        public void Walk()
        {
            Console.WriteLine("estah caminhando.");
        }
    }
}
