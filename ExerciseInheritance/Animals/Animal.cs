using System;
using System.Data;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, int age, string gender)
        {
            if ((string.IsNullOrWhiteSpace(name)) || (age < 0)
                || string.IsNullOrWhiteSpace(gender))
                throw new ArgumentException();
            
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; }
        public int Age { get; }
        public string Gender { get; }

        public virtual string ProduceSound() => "";

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(this.GetType().Name);
            stringBuilder.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            stringBuilder.Append(ProduceSound());  
            return stringBuilder.ToString();
        }
    }
}
