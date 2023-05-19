namespace ex1
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Category { get; set; }

        public Animal(string name, string owner, string category)
        {
            Name = name;
            Owner = owner;
            Category = category;
        }
    }
}
