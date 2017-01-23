using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Review
{
    class Program
    {

        static void TestOutStrategyPattern()
        {
            Vehicle raceCar = new RaceCar("Ferrari FHF");
            Vehicle airplane = new Airplane("BOA 345");
            Vehicle jet = new Jet("Jet 345");

            raceCar.Go();
            airplane.Go();
            jet.Go();

            jet.SetGoAlgorithm(new GoByDrivingAlgorithm());
            jet.Go();
        }
        static void TestOutDecoratorPattern()
        {
            // The decaorator pattern allows you to write your code avoid modification
            // while still extending that if you needed
            Console.WriteLine("**********************");
            IComputer computer = new Computer();
            Console.WriteLine(computer.GetType());

            computer = new Disk(computer);
            Console.WriteLine(computer.GetType());

            computer = new DVDWriter(computer);
            Console.WriteLine(computer.GetType());

            computer = new Monitor(computer);
            Console.WriteLine("Description : {0} ", computer.Description());
            Console.WriteLine("Price : {0} ", computer.Price);
        }
        static void TestOutChainOfResposabilityPattern()
        {
            // The decaorator pattern allows you to write your code avoid modification
            // while still extending that if you needed
            Console.WriteLine("***********CHAIN OF RESPONSABILITIES***********");
            int FRONT_END_HELP = 1;
            int INTERMEDIATELAYER = 2;
            int GENERAL_HELP = 3;
            Application app = new Application();
            IntermediateLayer intLayer = new IntermediateLayer(app);
            FrontEnd frontEnd = new FrontEnd(intLayer);
            frontEnd.GetHelp(FRONT_END_HELP);
        }
        static void Main(string[] args)
        {
            TestOutStrategyPattern();
            TestOutDecoratorPattern();
            TestOutChainOfResposabilityPattern();
            Console.ReadLine();
        }
    }
}
