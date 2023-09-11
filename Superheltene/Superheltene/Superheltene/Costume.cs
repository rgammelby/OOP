using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheltene
{
    internal class Costume
    {
        private bool _cape;
        private bool _mask;
        private string _colour1;
        private string _colour2;
        private string _colour3;

        public bool Cape
        {
            get { return _cape; }
            private set { _cape = value; }
        }

        public bool Mask
        { 
            get { return _mask; }
            private set {  _mask = value; } 
        }

        public string Colour1 
        { 
            get { return _colour1; } 
            private set {  _colour1 = value; } 
        }

        public string Colour2 
        { 
            get { return _colour2; } 
            private set { _colour2 = value; } 
        }

        public string Colour3 
        { 
            get { return _colour3; } 
            private set { _colour3 = value; } 
        }
    }
}
