using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    /// <summary>
    /// The returned CustomerDataAccess class is our low-level component.
    /// </summary>
    public class DataAccessFactory
    {

        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }
}
