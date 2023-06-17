using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_C_.domain
{
    internal class Hanger
    {
        private Cloth _upperCloth; 
        private Cloth _lowerCloth;

        public bool DoubleHanger { get; set; }
        public Cloth Upper { 
            get { return _upperCloth; }  
            set { _upperCloth = value; }
        }
        public Cloth Lower {
            get { return _lowerCloth; }
            set { _lowerCloth = value; }
        }

        public bool Put(Cloth cloth)
        {
            if ((cloth.ClothType.HangerPosition == ClothType.Position.Upper) && (_upperCloth == null))
            {
                _upperCloth = cloth;
                return true;
            }
            if ((cloth.ClothType.HangerPosition == ClothType.Position.Lower) && (_lowerCloth == null) && DoubleHanger)
            {
                _lowerCloth = cloth;
                return true;
            }
            else
            { 
                return false; 
            }
        }
        public void RemoveAll()
        {
            _upperCloth = null;
            _lowerCloth = null;
        }

        public bool RemoveSingle(Guid clothID)
        {
            if (_upperCloth.ID == clothID)
            {
                _upperCloth = null;
                return true;
            }
            if (_lowerCloth.ID == clothID)
            {
                _lowerCloth = null;
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
