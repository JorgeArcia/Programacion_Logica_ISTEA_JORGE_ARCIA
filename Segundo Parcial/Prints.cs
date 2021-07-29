using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo_Parcial
{
    class Prints
    {
        /// <summary>
        /// Muestra por consola un Array de string con color de fondo y color de fuente
        /// </summary>
        /// <param name="Menbrete"></param>
        public static void PrintMenbrete(string[] Menbrete)
        {
            for (int i = 0; i < Menbrete.Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                if (i != 1)
                {
                    Console.Write($"|{Menbrete[i],15}");
                }
                else
                {
                    Console.Write($"|{Menbrete[i],22}");
                }
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Muestra Menu prinpical de opciones
        /// </summary>
        public static void MostrarMenu()
        {
            Console.WriteLine("****Bienvenido a Allegro Instrumentos.S.A*****");
            Console.WriteLine();
            Console.WriteLine("1- Mostrar Producto");
            Console.WriteLine("2- Buscar Producto");
            Console.WriteLine("3- Agregar nuevo Producto");
            Console.WriteLine("4- Modificar Producto");
            Console.WriteLine("5- Eliminar Producto del sistema");
            Console.WriteLine("6- Facturacion");
            Console.WriteLine("7- Salir");
            Console.WriteLine();
        }
        /// <summary>
        /// Muestra Menu de opciones de la opcion (1-Mostrar)
        /// </summary>
        public static void MenuMostrar()
        {
            Console.Clear();
            Console.WriteLine("1.1- Mostrar todo");
            Console.WriteLine("1.2- Mostrar segun categoria");
            Console.WriteLine("1.3- Mostrar segun marca");
            Console.WriteLine("1.4- Mostrar por departamento");
            Console.WriteLine("1.5- Mostrar por gama");
            Console.WriteLine("1.6- Mostrar por stock");
            Console.WriteLine("1.7- Producto mas vendido");
            Console.WriteLine("1.8- Producto menos vendido");
        }
        /// <summary>
        /// Muestra Menu de opciones de la opcion (2-Buscar Producto)
        /// </summary>
        public static void MenuBuscar()
        {
            Console.Clear();
            Console.WriteLine("2.1- Buscar producto por IdProducto");
            Console.WriteLine("2.2- Buscar producto por Nombre");
        }
        /// <summary>
        /// Muestra menu de opciones de la opcion (6-Facturacion)
        /// </summary>
        public static void MenuFacturacion()
        {
            Console.Clear();
            Console.WriteLine("6.1- Mostrar producto que mas facturo");
            Console.WriteLine("6.2- Mostrar facturacion por categoria");
            Console.WriteLine("6.3- Mostrar facturacion por producto ordenada de menor a mayor");
            Console.WriteLine("6.4- Mostrar toda la informacion de facturacion");
        }
        /// <summary>
        /// Muestra en por consola todos los datos originales de los parametros ingresados
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public static void PrintAllData(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            for (int f = 0; f < MatrizString.GetLength(0); f++)
            {
                for (int c = 0; c < MatrizString.GetLength(1); c++)
                {
                    if (c != 1)
                    {
                        Console.Write($"|{MatrizString[f, c],-15}");
                    }
                    else
                    {
                        Console.Write($"|{MatrizString[f, c],-22}");
                    }
                }
                for (int c = 0; c < MatrizInt.GetLength(1); c++)
                {
                    Console.Write($"|{MatrizInt[f, c],-15}");
                }

                Console.Write($"|{Departamento[f],-15}");
                Console.Write($"|{Gama[f]}");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Muestra por consola los datos ingresados como parametro con el indice dado por una lista
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        /// <param name="Indice"></param>
        public static void PrintData(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama, List<int> Indice)
        {
            for (int f = 0; f < Indice.Count; f++)
            {
                for (int c = 0; c < MatrizString.GetLength(1); c++)
                {
                    if (c != 1)
                    {
                        Console.Write($"|{MatrizString[Indice[f], c],-15}");
                    }
                    else
                    {
                        Console.Write($"|{MatrizString[Indice[f], c],-22}");
                    }
                }
                for (int c = 0; c < MatrizInt.GetLength(1); c++)
                {
                    Console.Write($"|{MatrizInt[Indice[f], c],-15}");
                }

                Console.Write($"|{Departamento[Indice[f]],-15}");
                Console.Write($"|{Gama[Indice[f]]}");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Muestra por consola los datos ingresados como parametro con un indice tipo Int dado
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Indice"></param>
        public static void PrintData(string[,] MatrizString, int[,] MatrizInt, int Indice)
        {
            for (int c = 0; c < MatrizString.GetLength(1); c++)
            {
                if (c != 1)
                {
                    Console.Write($"|{MatrizString[Indice, c],-15}");
                }
                else
                {
                    Console.Write($"|{MatrizString[Indice, c],-22}");
                }
            }
            for (int c = 0; c < MatrizInt.GetLength(1); c++)
            {
                Console.Write($"|{MatrizInt[Indice, c],-15}");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Muestra por consola los datos ingresados como parametro con un indice dado por una Lista
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="MatrizIntFact"></param>
        /// <param name="Idx"></param>
        public static void PrintData(string[,] MatrizString, int[,] MatrizInt, int[,] MatrizIntFact, List<int> Idx)
        {
            for (int f = 0; f < Idx.Count; f++)
            {
                for (int c = 0; c < MatrizString.GetLength(1); c++)
                {
                    if (c != 1)
                    {
                        Console.Write($"|{MatrizString[Idx[f], c],-15}");
                    }
                    else
                    {
                        Console.Write($"|{MatrizString[Idx[f], c],-22}");
                    }
                }
                for (int c = 0; c < MatrizInt.GetLength(1); c++)
                {
                    Console.Write($"|{MatrizInt[Idx[f], c],-15}");
                }
                Console.Write($"|{MatrizIntFact[Idx[f],1]} $");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Muestra por consola todos los datos ingresados como parametro
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        /// <param name="Facturacion"></param>
        public static void PrintData(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama,int[,] Facturacion)
        {
            for (int f = 0; f < MatrizString.GetLength(0); f++)
            {
                for (int c = 0; c < MatrizString.GetLength(1); c++)
                {
                    if (c != 1)
                    {
                        Console.Write($"|{MatrizString[f, c],-15}");
                    }
                    else
                    {
                        Console.Write($"|{MatrizString[f, c],-22}");
                    }
                }
                for (int c = 0; c < MatrizInt.GetLength(1); c++)
                {
                    Console.Write($"|{MatrizInt[f, c],-15}");
                }

                Console.Write($"|{Departamento[f],-15}");
                Console.Write($"|{Gama[f],-15}");
                for (int c = 0; c < Facturacion.GetLength(1); c++)
                {
                    Console.Write($"|{Facturacion[f,c],-15}");
                }
                Console.WriteLine();
            }
        }
    }
}



