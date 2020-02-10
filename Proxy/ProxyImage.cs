using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private String _fileName;
        public ProxyImage(String fileName)
        {
            this._fileName = fileName;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(_fileName);
            }
            realImage.Display();
        }
    }
}
