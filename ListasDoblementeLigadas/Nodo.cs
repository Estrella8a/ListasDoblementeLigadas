using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    public class Nodos
    {
        public string Valor { get; set; }
        public Nodos EnlaceAnterior { get; set; }
        public Nodos EnlaceSiguiente { get; set; }

        public Nodos(string valor = "", Nodos enlaceA = null, Nodos enlaceS = null)
        {
            Valor = valor;
            EnlaceAnterior = enlaceA;
            EnlaceSiguiente = enlaceS;
        }
    }
}