using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaTema7
{
   public class LongitudInsuficiente:Exception
    {
        public LongitudInsuficiente(string mensaje) : base(mensaje)
        {

        }
    }
}
