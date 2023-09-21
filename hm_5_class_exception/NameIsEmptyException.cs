using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_5_class_exception
{
    public class NameIsEmptyException : Exception
    {
        public NameIsEmptyException(string message) : base(message) { }   
    }
}
