using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Review
{

    // chainning objects together 
    // Front End  -->  Intermediate Layer  --> Application

    public interface IHelp
    {
        void GetHelp(int helpConstant);
    }

    public class FrontEnd: IHelp 
    {
        IHelp _successor;
        const int FROM_END_HELP = 1;
        // pass the next object in the chain
        // 
        public FrontEnd(IHelp help)
        {
            this._successor = help;
        }

        public void GetHelp (int helpConstant)
        {
            // the front end can only handle help request about front end
            if(helpConstant != FROM_END_HELP)
            {
                // it should pass the hep request to the next object in the chain
                _successor.GetHelp(helpConstant);
            }
            else
            {
                Console.WriteLine("This the Frond end Layer");
            }
        }
    }
    public class IntermediateLayer : IHelp
    {
        IHelp _successor;
        const int INTERMEDIATE_LAYER_HELP = 2;
        // pass the next object in the chain
        // 
        public IntermediateLayer(IHelp help)
        {
            this._successor = help;
        }

        public void GetHelp(int helpConstant)
        {
            // the front end can only handle help request about front end
            if (helpConstant != INTERMEDIATE_LAYER_HELP)
            {
                // it should pass the hep request to the next object in the chain
                _successor.GetHelp(helpConstant);
            }
            else
            {
                Console.WriteLine("This is intermediate layer");
            }
        }
    }
    public class Application : IHelp
    {
        public Application()
        {
        }

        public void GetHelp(int helpConstant)
        {
            // the buck stops here
            Console.WriteLine("This is the application Layer");
        }
    }
}
