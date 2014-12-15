using System;
using Grgl.Character;

namespace GrglTestDebugApp
{
    class Program
    {


        static void Main(string[] args)
        {
            Character testMan = new Character("TestMan", "testMan001");
            Console.WriteLine(testMan.Resources["Health"].CurrentValue);

            Console.ReadKey();
        }




    }
}
