
namespace Csharp_Methods_Constructors_Inheritance
{
    internal class Animal
    {
        public int id;
        public string name;

        public Animal(string text)
        {
            Console.WriteLine(text);
        }


        public void Sound()
        {
            Console.WriteLine("Animal sound");
        }


    }
}
