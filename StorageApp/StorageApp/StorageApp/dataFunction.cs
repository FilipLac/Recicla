using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp
{
    internal class dataFunction
    {
        public bool defaultCheck(string name, string type, string description, string boxcolor, string color, string age, decimal boxnumber, decimal price, decimal quantity)
        {
            if (name == "placehold" || name == "" || name == null)
            {
                return false;
            }
            else if (type == "placehold" || type == "" || type == null)
            {
                return false;
            }
            else if (description == "placehold" || description == "" || description == null)
            {
                return false;
            }
            else if (boxcolor == "placehold" || boxcolor == "" || boxcolor == null)
            {
                return false;
            }
            else if (color == "placehold" || color == "" || color == null)
            {
                return false;
            }
            else if (age == "placehold" || age == "" || age == null)
            {
                return false;
            }
            else if (boxnumber == 0)
            {
                return false;
            }
            else if (boxnumber == 0)
            {
                return false;
            }
            else if (quantity == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
