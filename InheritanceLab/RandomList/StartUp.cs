namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList();

            randomList.Add("Asli");
            randomList.Add("Ali");
            randomList.Add("Meliha");
            randomList.Add("Gyulnur");
            randomList.Add("Gyunay");

            Console.WriteLine("Removed item");
            Console.WriteLine(randomList.RandomString());

            Console.WriteLine();

            foreach (var item in randomList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
