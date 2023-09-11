using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheltene
{
    /// <summary>
    /// Class <c>Superhero</c> models a superhero or villain.
    /// </summary>

    internal class Superhero
    {
        private string _ability = null;
        private string _equipment = null;
        private string _alias;
        private Superhero _archenemy;
        private bool _morality;
        private string _name;
        private string _issue = null;
        // TODO: Add costume.

        private const bool GOOD = true;
        private const bool EVIL = false;

        public string Ability 
        { 
            get { return _ability; } 
            private set { _ability = value; } 
        }

        public string Equipment 
        { 
            get { return _equipment; } 
            private set { _equipment = value; } 
        } 

        public string Alias 
        { 
            get { return _alias; } 
            private set {  _alias = value; } 
        }

        public Superhero Archenemy
        {
            get { return _archenemy; }
            private set { _archenemy = value; }
        }

        public bool Morality 
        { 
            get { return _morality; } 
            private set { _morality = value; } 
        }

        public string Name 
        { 
            get { return _name; } 
            private set { _name = value; } 
        }

        public string Issue
        {
            get { return _issue; }
            private set { _issue = value; }
        }
    }
}
