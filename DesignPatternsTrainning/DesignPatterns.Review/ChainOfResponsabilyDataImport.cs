using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Review
{
    public interface IHandler
    {
        void Process(string fileName, string fileContent);
    }
    class FileFormatHandler: IHandler
    {
        IHandler _nextHandler;
        public FileFormatHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public void Process(string fileName, string fileContent)
        {
            string ext = Path.GetExtension(fileName);
            if (ext != ".txt" && ext != ".csv")
            {
                throw new Exception("Invalid file type!");
            }
            else
            {
                _nextHandler.Process(fileName, fileContent);
            }
        }
    }
    class FileStorageHandler : IHandler
    {
        IHandler _nextHandler;
        public FileStorageHandler (IHandler handler)
        {
            _nextHandler = handler;
        }

        public void Process(string fileName, string fileContent)
        {
            Console.Write("Storing data");
            _nextHandler.Process(fileName, fileContent);
        }
    }
}
