using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Domain.Exceptions
{
    public class DuplicateException : Exception
    {
        public DuplicateException(string nome) : base(nome)
        {
            
        }
    }
}