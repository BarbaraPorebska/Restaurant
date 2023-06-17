using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_C_.domain
{
    internal class ClothType
    {
        public Type ClothingType { get; set; }
        public Position HangerPosition { get; set; }
        public enum Type {
            Shirt,
            Blouse, 
            Trousers,
            Skirt
        }

        public enum Position
        {
            Upper,
            Lower
        }
    }
}
