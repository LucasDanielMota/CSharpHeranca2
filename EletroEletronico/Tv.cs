using System;
using System.Collections.Generic;
using System.Text;

namespace EletroEletronico
{
    public class Tv : EletroEletronico
    {
        public double canal = 12.0;
        public int volume = 100;

        public Tv(string marca, string modelo, int voltagem, bool ligado) : base(marca, modelo, voltagem, ligado)
        {

        }

        public override string ToString()
        {
            return "TV{marca=" +
                marca +", modelo="+
                modelo+", canal="+
                canal + ", volume="+
                volume +
                "}";
        }
    }
}
