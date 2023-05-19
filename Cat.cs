using System;

namespace ex1
{
    public class Cat : Animal, IWalk
    {
        public Cat(string name, string owner, string category) : base(name, owner, category)
        {
        }

        public void Walk()
        {
            Console.WriteLine("estah caminhando.");
        }
    }
}
