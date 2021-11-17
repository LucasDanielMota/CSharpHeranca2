using System;
using System.Collections.Generic;
using System.Text;

namespace EletroEletronico
{
    class PS4 : EletroEletronico
    {
        public bool possui4k;
        public PS4(string marca, string modelo, int voltagem, bool ligado, bool possui4k) : base(marca, modelo, voltagem, ligado)
        {
            this.possui4k = possui4k;
        }

        public override string ToString()
        {
            
            return String.Format("PS4{{marca={0}, modelo={1}, voltagem={2}, ligado={3}, possui4k={4}}}",
                marca, modelo, voltagem, ligado, possui4k);
            
        }
    }
}
