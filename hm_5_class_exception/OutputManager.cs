using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_5_class_exception
{
    internal abstract class OutputManager
    {
        protected static void CheckInput(string propertyName, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new NameIsEmptyException($"{propertyName} can't be empty");
            }
        }
        public abstract override string ToString();
    }
}
