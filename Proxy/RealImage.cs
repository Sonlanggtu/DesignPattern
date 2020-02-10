using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class RealImage : IImage
    {
        private String _fileName;

        public RealImage(String fileName)
        {
            this._fileName = fileName;
            loadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Display " + _fileName);   
        }

        public void loadFromDisk(String fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }
}
