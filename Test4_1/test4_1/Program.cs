using System;
namespace test4_1
{
    class Fruit
    {
        public double Number { get; set; }
        public double Weight { get; set; }
        public double GetCost()
        {
            return Number*Weight;
        }
        public Fruit(double number, double weight)
        {
            this.Number = number;
            this.Weight = weight;
        }
        public void Show()
        {
            Console.WriteLine($"Hello, here are {this.Number} fruits.And there are {this.Weight} weight.");
        }
    }
    class Apple : Fruit
    {
        string? Color { get; set; }
        public Apple(double number, double weight, string color) : base(number, weight)
        {
            this.Number = number;
            this.Weight = weight;
            this.Color = color;
        }
        public void Show()
        {
            Console.WriteLine($"Hello, here are {this.Number} fruits.And there are {this.Weight} weight.");
            Console.WriteLine($"They are apples,and they are {this.Color}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruitA = new(123,200);
            Apple appleA = new(20, 300, "red");
            fruitA.Show();
            appleA.Show();
        }
    }
}