using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaGenerica.Estruturas
{
    public class TablaHash<T>
    {
        int TotalPocisiones = 10;
        T[] Tabla = new T[10];
        
        private int ContarVocales(char Letra, string Texto, int Numero)
        {
            int Cantidad = 0;
            foreach (char Pivote in Texto)
                if (Pivote == Letra)
                    Cantidad++;
            return Cantidad * Numero;
        }
        private int Divisor(string Texto)
        {
            int Contador = 1;
            int Cantidad = 0;
            foreach (char Pivote in Texto)
            {
                if (Pivote == 'a')
                    Cantidad += (5 * Contador);
                if (Pivote == 'e')
                    Cantidad += (3 * Contador);
                if (Pivote == 'i')
                    Cantidad += (7 * Contador);
                if (Pivote == 'o')
                    Cantidad += (2 * Contador);
                if (Pivote == 'u')
                    Cantidad += (1 * Contador);
                Contador++;
            }
            return Cantidad * Texto.Length;
        }
        public int ObtenerValorHash(string Nombre)
        {
            string DatoHash = Nombre.ToLower();
            int Valor = (DatoHash.Length) * 19;
            //Vocales
            if (DatoHash.Contains('a'))
                Valor *= ContarVocales('a', DatoHash, 3);
            if (DatoHash.Contains('e'))
                Valor *= ContarVocales('e', DatoHash, 5);
            if (DatoHash.Contains('i'))
                Valor *= ContarVocales('i', DatoHash, 7);
            if (DatoHash.Contains('o'))
                Valor *= ContarVocales('o', DatoHash, 11);
            if (DatoHash.Contains('u'))
                Valor *= ContarVocales('u', DatoHash, 13);
            //Consonantes
            if (DatoHash.Contains('s'))
                Valor += 499;
            if (DatoHash.Contains('r'))
                Valor += 503;
            if (DatoHash.Contains('c'))
                Valor += 521;
            if (DatoHash.Contains('n'))
                Valor += 547;
            if (DatoHash.Contains('d'))
                Valor += 653;
            if (DatoHash.Contains('l'))
                Valor += 661;
            Valor %= Divisor(DatoHash);
            Valor %= TotalPocisiones;
            return Valor;
        }
        public bool Añadir(T Valor, int Posicion, Delegate Delegado)
        {
            if (ChequeoIngresar(Valor, Posicion))
            {
                Tabla[Posicion] = Valor;
            }
            return true;
        }
        
        public bool ChequeoIngresar(T Valor, int Posicion)
        {
            if(Tabla[Posicion] == null)
                return true;
            else
                return false;
        }
        public T Buscar(T Valor, string Texto, Delegate Delegado)
        {
            int Posicion = ObtenerValorHash(Texto);
            if (Convert.ToInt32(Delegado.DynamicInvoke(Valor, Tabla[Posicion])) == 0)
                return Tabla[Posicion];
            else
                return default(T);
        }
        public void Borrar(T Valor, string Texto)
        {
            int Posicion = ObtenerValorHash(Texto);
            Tabla[Posicion] = default;
        }
        public List<T> Mostrar()
        {
            List<T> AuxLista = new List<T>();
            foreach (var Posicion in Tabla)
                if (Posicion != null)
                    AuxLista.Add(Posicion);
            return AuxLista;
        }

    }
}