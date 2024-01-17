using UniversityCompetition.Core;
using UniversityCompetition.Core.Contracts;

namespace P18_UniversityCompetition_OOP_
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
