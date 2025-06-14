using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Grafo
    {
        public Vertice inicio_lista = null;
        public int[,] ma;

        public Grafo(int n)
        {
            ma = new int[n, n];
        }
        //METODOS PARA LISTA (insertar y mostrar)

        public void insertar(String l)
        {
            //1.Crear el nuevo nodo
            Vertice nuevo = new Vertice();
            nuevo.lugar = l;

            if (inicio_lista == null)
            {
                //la lista esta vacia
                //el nuevo debe guardarse en el primero
                inicio_lista = nuevo;
            }
            else
            {
                //2. buscar el ultimo
                Vertice temp = inicio_lista;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                //temp esta ubicado en el ultimo
                //3. ultimo.sig el nuevo
                temp.sig = nuevo;

            }
        }
        //mostrar
        public void Mostrar()
        {
            Vertice temp = inicio_lista;
            while (temp != null)
            {
                Console.WriteLine(temp.lugar);
                temp = temp.sig;
            }
        }
        //METODOS PARA MATRIZ 
        public void llenarMatriz()
        {
            ma = new int[,]
            {
                { 0,1,1,1,1,0 },
                { 1,0,1,1,0,1 },
                { 0,0,0,0,0,0 },
                { 0,0,0,0,0,0 },
                { 0,0,0,0,0,0 },
                { 1,0,0,0,0,0 }
            };
        }
        public void mostrarMatriz()
        {
            Vertice temp = inicio_lista;
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Red;
            while (temp != null)
            {
                Console.Write(temp.lugar + "\t");
                temp = temp.sig;
            }
            Console.WriteLine();
            Console.ResetColor();

            temp = inicio_lista;
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(temp.lugar + "\t");
                Console.ResetColor();
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    Console.Write(ma[i, j] + "\t");
                }
                Console.WriteLine();
                temp = temp.sig;
            }
        }

        //METODOS DE GRAFOS
        public void crearGrafo()
        {
            Vertice tempOrigen/*muestra las filas*/= inicio_lista;
            for (int i = 0; i < ma.GetLength(0); i++)//0 = filas, origen
            {
                Vertice tempDestino = inicio_lista;
                for (int j = 0; j < ma.GetLength(1); j++)//1 = columnas, destino
                {
                    if (ma[i, j] == 1)//si hay adyacencia / arista
                    {
                        //union
                        if (tempOrigen.arista1 == null)//está disponible
                        {
                            tempOrigen.arista1 = tempDestino;
                        }
                        else if (tempOrigen.arista2 == null)
                        {
                            tempOrigen.arista2 = tempDestino;
                        }
                        else if (tempOrigen.arista3 == null)
                        {
                            tempOrigen.arista3 = tempDestino;
                        }
                        else if (tempOrigen.arista4 == null)
                        {
                            tempOrigen.arista4 = tempDestino;
                        }
                        else if (tempOrigen.arista5 == null)
                        {
                            tempOrigen.arista5 = tempDestino;
                        }
                        else if (tempOrigen.arista6 == null)
                        {
                            tempOrigen.arista6 = tempDestino;
                        }
                    }
                    tempDestino = tempDestino.sig; //avanzar al siguiente destino
                }
                tempOrigen = tempOrigen.sig; //avanzar al siguiente origen
            }
        }

        public void navegarGrafo(Vertice actual)
        {
            //Console.Clear();
            Console.WriteLine("Recorriendo el grafo");
            Console.WriteLine("Vertice actual: " + actual.lugar);
            Console.WriteLine("Aristas/Vertices conectados: ");
            if (actual.arista1 != null) { Console.WriteLine("1. -> [" + actual.arista1.lugar + "]"); }
            if (actual.arista2 != null) { Console.WriteLine("2. -> [" + actual.arista2.lugar + "]"); }
            if (actual.arista3 != null) { Console.WriteLine("3. -> [" + actual.arista3.lugar + "]"); }
            if (actual.arista4 != null) { Console.WriteLine("4. -> [" + actual.arista4.lugar + "]"); }
            if (actual.arista5 != null) { Console.WriteLine("5. -> [" + actual.arista5.lugar + "]"); }
            if (actual.arista6 != null) { Console.WriteLine("6. -> [" + actual.arista6.lugar + "]"); } 

            Console.WriteLine("\n7. Volver al inicio del grafo \n0. Salir");//agrego la opción 6 que siempre va a estar ahí como la opción 0
            Console.Write("Seleccione una opción: ");
            int op = int.Parse(Console.ReadLine());


            switch (op)
            {
                case 1: if (actual.arista1 != null) { Console.Clear(); mostrarMatriz(); navegarGrafo(actual.arista1); } else { Console.WriteLine("No es una opción válida"); } break;
                case 2: if (actual.arista2 != null) { Console.Clear(); mostrarMatriz(); navegarGrafo(actual.arista2); } else { Console.WriteLine("No es una opción válida"); } break;
                case 3: if (actual.arista3 != null) { Console.Clear(); mostrarMatriz(); navegarGrafo(actual.arista3); } else { Console.WriteLine("No es una opción válida"); } break;
                case 4: if (actual.arista4 != null) { Console.Clear(); mostrarMatriz(); navegarGrafo(actual.arista4); } else { Console.WriteLine("No es una opción válida"); } break;
                case 5: if (actual.arista5 != null) { Console.Clear(); mostrarMatriz(); navegarGrafo(actual.arista5); } else { Console.WriteLine("No es una opción válida"); } break;
                case 6: if (actual.arista6 != null) { Console.Clear(); mostrarMatriz(); navegarGrafo(actual.arista6); } else { Console.WriteLine("No es una opción válida"); } break;
                case 7: Console.Clear(); mostrarMatriz(); navegarGrafo(inicio_lista); break; //vuelvo al inicio del grafo llamando a la función mostrarMatriz() con el parámetro del primer vértice
                case 0: Console.WriteLine("Saliendo..."); break;
                default: Console.WriteLine("Opción no válida"); break;
            }
            Console.ReadKey();
        }
    }
}
