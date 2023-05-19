namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Clear();

            Cow cow = new("Mimosa", "John", "Vaca");
            Dog dog = new("Rex", "John", "Cachorro");
            Cat cat = new("Bilbo", "John", "Gato");
            Horse horse = new("Ventania", "John", "Cavalo");
            Fish fish = new("Barao", "John", "Peixe");

            AnimalManager manager = new();
            manager.Add(cow);
            manager.Add(dog);
            manager.Add(cat);
            manager.Add(horse);
            manager.Add(fish);

            manager.DoReport();
        }
    }
}
