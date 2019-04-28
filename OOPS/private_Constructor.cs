using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class private_Constructor
    {
        private private_Constructor()
        {
        }

        private private_Constructor _instance;
        public static private_Constructor Instance
        {
            get
            {
                return _instance;
            }
            set
            {
                _instance = new private_Constructor();
            }
        }
        public void NormalMethod1()
        {
        }
        public static void StaticMethod1()
        {
        }
    }

    public class Class1
    {
    }
}
