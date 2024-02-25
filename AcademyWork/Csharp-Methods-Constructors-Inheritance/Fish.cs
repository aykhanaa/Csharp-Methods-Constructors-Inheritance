

namespace Csharp_Methods_Constructors_Inheritance
{
    class Fish:Animal
    {
        public string color;

        public Fish():base("Just animal")
        {
            Console.WriteLine("Fish constructor");
        }
    }
}
