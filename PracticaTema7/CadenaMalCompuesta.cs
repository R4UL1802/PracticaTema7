using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaTema7
{
    public class CadenaMalCompuesta:Exception
    {
        public CadenaMalCompuesta(string mensaje) : base(mensaje) { }
    }
}
