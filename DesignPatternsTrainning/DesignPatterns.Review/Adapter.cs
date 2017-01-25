using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Review
{

    interface IWriterMicroSD
    {
        int NumberOfPins { get; set; }
        // IMicroSD microSD { get; set; }
        void Read();

        void Insert(IMicroSD microSD);

    }


    class WriterMicroSD_Samsung : IWriterMicroSD
    {

        int _numberOfPins;
        public int NumberOfPins
        {
            get
            {
                return _numberOfPins;
            }

            set
            {
                this._numberOfPins = value;
            }
        }

        public void Insert(IMicroSD microSD)
        {
            if (microSD.NumberOfPins == this._numberOfPins)
                Console.WriteLine("Contains a MICROSD");
        }

        public void Read()
        {
            Console.WriteLine("Ready for reading!");
        }
    }


    interface IMicroSD
    {

        int NumberOfPins { get; set; }
        string Model {get; set;}
        void Format();
    }

    public class Adapter
    {

    }
}
