using NauticalCatchChallenge.Core;
using NauticalCatchChallenge.Core.Contracts;

namespace P08_NauticalCatchChallenge_OOP_
{
    internal class Program
    {
        static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
