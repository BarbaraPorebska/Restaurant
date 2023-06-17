using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_C_.domain
{
    internal class Wardrobe
    {
        private List<Hanger> _contents;
        public int MaxCapacity { get; set; }
        public List<Hanger> Contents
        {
            get { return _contents; }
            set { _contents = value; }
        }

        public bool AddHanger(Hanger hanger)
        {
            if (_contents.Count() <= MaxCapacity - 1)
            {
                _contents.Add(hanger);
                return true;

            }
            else 
            {
                return false;
            }
        }

        public bool RemoveClothing(Guid clothID) 
        {
            return true;
        }

        //public Hanger GetEmptyHanger(bool doubleHanger) 
        //{ 

        //}
    }
}
