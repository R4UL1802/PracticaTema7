using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaTema7
{
    public class ProteinaIncorrecta:Exception
    {
        public ProteinaIncorrecta(string mensaje) : base(mensaje) { }
    }
}
