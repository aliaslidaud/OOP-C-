namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();

            int index = random.Next(Count);

            string element = this[index];

            RemoveAt(index);
            return element;
        }
    }
}
