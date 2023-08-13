namespace CSharpLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут? ");
            string name = Console.ReadLine();
            Console.Write("Какой ваш знак зодиака? ");
            string zodiac = Console.ReadLine();
            Console.Write("Сколько вам лет? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Где вы работаете? ");
            string workPlace = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name}, вам {age} лет, вы {zodiac} и работаете {workPlace}.");
            Console.WriteLine();
        }
    }
}