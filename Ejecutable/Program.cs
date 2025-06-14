using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejecutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo gf = new Grafo(6);

            gf.insertar("CAJ");
            gf.insertar("BAÑOS");
            gf.insertar("LC");
            gf.insertar("JSS");
            gf.insertar("PORC");
            gf.insertar("NAM");
            gf.llenarMatriz();
            Console.WriteLine("Matriz de Adyacencia:");
            gf.mostrarMatriz();
            gf.crearGrafo();
            gf.navegarGrafo(gf.inicio_lista);
        }
    }
}
