using System;
using System.Collections.Generic;
using System.Text;

namespace EletroEletronico
{
    public abstract class EletroEletronico
    {
        public string marca;
        //public string Marca { get; set; }
        public string modelo;
        //public string Modelo { get; set; }
        public int voltagem;
        //public int Voltagem { get; set; }
        public bool ligado;
        //public bool Ligado { get; set; }
        public EletroEletronico(string marca, string modelo, int voltagem, bool ligado)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.voltagem = voltagem;
            this.ligado = ligado;
        }
        public override string ToString()
        {
            return String.Format("{4}{{marca={0}, modelo={1}, voltagem={2}, ligado={3}}}",
                marca, modelo, voltagem, ligado, this.GetType().Name);
        }
    }
}
