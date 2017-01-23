using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Review
{
    public interface IComputer
    {
        string Description();
        decimal Price { get; set; }
    }

    /// <summary>
    /// Decorator Pattern:
    /// Make your code closed for modification, but open for extension.
    /// Attach additional responsabilities to an object dynamically,
    /// decorator provide a flexible alternative to subclassing for extending funcionality
    /// Core component
    /// </summary>
    public class Computer: IComputer
    {
        public decimal Price { get; set; }

        public string Description()
        {
            return "Computer";
        }

    }

    /// <summary>
    /// this the abstract class that all computer class wrappers have to extend
    /// </summary>
    public abstract class ComputerDecorator: IComputer
    {
        //  when the class is extending, that wrappers will have to provide
        // their own version of the description method
        public abstract string Description();

        public abstract decimal Price { get; set; }

    }

    // Concrete wrapper for Disk
    public class Disk : ComputerDecorator
    {
        // Decorate a cumputer
        IComputer _computer;
        public Disk(IComputer computer)
        {

            _computer = computer;
        }

        public override string Description()
        {
            return _computer.Description() + " and add Disk";
        }

        public override decimal Price { get; set; }

    }

    public class DVDWriter : ComputerDecorator
    {
        // Decorate a cumputer
        IComputer _computer;
        public DVDWriter(IComputer computer)
        {
            _computer = computer;
        }

        public override string Description()
        {
            return _computer.Description() + " and add DVDWriter";
        }

        public override decimal Price { get; set; }

    }

    public class Monitor : ComputerDecorator
    {
        IComputer _computer;
        // what is wrapping
        public Monitor(IComputer computer)
        {
            _computer = computer;
        }
        public override string Description()
        {
            return _computer.Description() + " Add a monitor";
        }

        public override decimal Price { get; set; }

    }
}
