using System;
namespace ex1
{
    public class Dog : Animal, IWalk
    {
        public Dog(string name, string owner, string category) : base(name, owner, category)
        {
        }

        public void Walk()
        {
            Console.WriteLine("estah caminhando.");
        }
    }
}
