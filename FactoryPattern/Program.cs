namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me what type of pickups you'd like in your guitar: ");
            string typeOfPickups;


            typeOfPickups = Console.ReadLine().ToLower();

          var guitar =  GuitarFactory.GetGuitar(typeOfPickups);

            guitar.GuitarType();
        }
        
    }
}
