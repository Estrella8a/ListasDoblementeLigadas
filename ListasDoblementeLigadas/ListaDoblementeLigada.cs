using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        private Nodos _nodoInicial;

        public Lista()
        {
            _nodoInicial = new Nodos();
        }

        public bool EstaVacio()
        {
            if (_nodoInicial.EnlaceSiguiente == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Vaciar()
        {
            _nodoInicial.EnlaceSiguiente = null;
            Console.WriteLine("Lista Vacia");
        }

        public string Recorrer()
        {
            string elementos = string.Empty;
            Nodos nodoActual = _nodoInicial;
            while (nodoActual.EnlaceSiguiente != null)
            {
                nodoActual = nodoActual.EnlaceSiguiente;
                elementos += $"{nodoActual.Valor}\n";
            }

            return elementos;
        }

        public void Agregar(string valor)
        {
            Nodos nodoActual = _nodoInicial;
            while (nodoActual.EnlaceSiguiente != null)
            {
                nodoActual = nodoActual.EnlaceSiguiente;
            }

            Nodos nodoNuevo = new Nodos(valor);
            nodoActual.EnlaceSiguiente = nodoNuevo;
            nodoNuevo.EnlaceAnterior = nodoActual;
        }
        public Nodos Buscar(string valor)
        {
            if (EstaVacio() == false)
            {
                Nodos nodoActual = _nodoInicial;
                while (nodoActual.EnlaceSiguiente != null)
                {
                    nodoActual = nodoActual.EnlaceSiguiente;
                    if (nodoActual.Valor == valor)
                    {
                        return nodoActual;
                    }
                }
            }
            return null;
        }

        public void Borrar(string valor)
        {
            if (EstaVacio() == false)
            {
                Nodos nodoActual = Buscar(valor);
                if (nodoActual != null)
                {
                    Nodos nodoAnterior = nodoActual.EnlaceAnterior;
                    nodoAnterior.EnlaceSiguiente = nodoActual.EnlaceSiguiente;

                    Nodos nodoSiguiente = nodoActual.EnlaceSiguiente;
                    nodoSiguiente.EnlaceAnterior = nodoActual.EnlaceAnterior;

                    nodoActual.EnlaceSiguiente = null;
                    nodoActual.EnlaceAnterior = null;
                }
            }
        }
    }
}