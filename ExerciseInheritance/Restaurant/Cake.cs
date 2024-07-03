namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double DefaultGrams = 250;
        private const double DefaultCalories = 1000;
        private const decimal DefaultDessertPrice = 5m;
        public Cake(string name) 
            : base(name, DefaultDessertPrice, DefaultGrams, DefaultCalories)
        {
           
            
        } 
    }
}
