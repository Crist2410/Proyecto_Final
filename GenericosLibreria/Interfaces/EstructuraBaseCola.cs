using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibreriaGenerica.Estruturas;

namespace LibreriaGenerica.Interfaces
{
    public abstract class EstructuraBaseCola<T>
    {
        protected abstract void Insertar(T Valor, Delegate Delegado, Nodo<T> NodoRaiz);
        protected abstract void Borrar(Nodo<T> NodoRaiz, int Inicio);
        protected abstract T Obtener();
    }
}