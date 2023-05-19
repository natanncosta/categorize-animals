namespace ex1
{
    public class Walker : Animal, IWalk
    {
        public Walker(string name, string owner, string category) : base(name, owner, category)
        {
        }

        public void Walk()
        {

        }
    }
}
