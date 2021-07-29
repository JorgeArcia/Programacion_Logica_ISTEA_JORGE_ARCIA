using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo_Parcial
{
    class Validations
    {
        public List<int> Indice = new List<int>();
        /// <summary>
        /// Valida si el valor String ingresado puede ser convertido en Int y esta dentro del max y min
        /// </summary>
        /// <param name="text">Dato a convertir en int</param>
        /// <param name="min">Valor minimo</param>
        /// <param name="max">Valor maximo</param>
        /// <returns>Valor entero</returns>
        public static int ValidationInt(string text, int min, int max)
        {
            Console.WriteLine();
            string AuxString = PedirString(text);
            int aux;
            while (!int.TryParse(AuxString, out aux) || (aux < min || aux > max))
            {
                Console.WriteLine($"ERROR. reingrese {text} valido.");
                AuxString = Console.ReadLine().Trim();
            }
            return aux;
        }
        /// <summary>
        /// Valida si el valor String ingresado puede ser convertido en decimal y esta dentro del max y min
        /// </summary>
        /// <param name="text"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Valor decimal</returns>
        public static decimal ValidationDecimal(string text, int min, decimal max)
        {
            Console.WriteLine();
            string AuxString = PedirString(text);
            decimal aux;
            while (!decimal.TryParse(AuxString, out aux) || aux < min || aux > max)
            {
                Console.WriteLine($"ERROR. reingrese {text} valido.");
            }
            return aux;
        }
        /// <summary>
        /// Pide una String y valida que no tenga valor nulo
        /// </summary>
        /// <param name="Text"></param>
        /// <returns>Valor String</returns>
        public static string PedirString(string Text)
        {
            string aux;

            Console.Write($"Ingrese {Text}: ");
            aux = Console.ReadLine().Trim().ToLower();
            while (aux == null)
            {
                Console.WriteLine($"ERROR. Ingrese {Text}: ");
            }
            return aux;
        }
        /// <summary>
        /// Recibe una string como parametro
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="CantCaracteres"></param>
        /// <returns>La string recibida como int</returns>
        public static int ConvertIntString(string dato)
        {
            int aux = 0;
            if (dato == " ")
            {
                return 0;
            }
            else
            {
                int.TryParse(dato, out aux);
            }
            return aux;
        }
        /// <summary>
        /// Recibe un texto como parametro y comprueba que la respuesta SI o NO
        /// </summary>
        /// <param name="newdato"></param>
        /// <returns>True si es SI y False si es NO</returns>
        public static bool ValidarSI(string newdato)
        {
            bool aux2 = false;
            int aux = 0;
            while (aux == 0)
            {
                if (newdato == "si")
                {
                    aux = 1;
                    aux2 = true;
                }
                else if (newdato == "no")
                {
                    aux = 1;
                    aux2 = false;
                }
                else
                {
                    Console.WriteLine("ERROR. Escriba SI o NO.");
                    aux = 0;
                    newdato = Console.ReadLine().Trim().ToLower();
                }
            }
            return aux2;
        }
        /// <summary>
        /// Busca un valor string dentro de la matriz dada como parametro. Tiene una lista out con los indices de fila de coincidencia
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="Buscar"></param>
        /// <param name="IndexBuscar"></param>
        /// <param name="Indice"></param>
        /// <returns>Si se consigue la string retornara True, de lo contrario False</returns>
        public static bool BuscarStringMatriz(string[,] MatrizString, string Buscar, int IndexBuscar, out List<int> Indice)
        {
            bool AuxBool = false;
            Indice = new List<int>();

            for (int i = 0; i < MatrizString.GetLength(0); i++)
            {
                if (MatrizString[i, IndexBuscar].ToLower().Contains(Buscar.ToLower()))
                {
                    AuxBool = true;
                    Indice.Add(i);
                }
            }
            return AuxBool;
        }
        /// <summary>
        /// Busca un valor string dentro de un array dado como parametro. Tiene una lista out con los indices de fila de coincidencia
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="Buscar"></param>
        /// <param name="Indice"></param>
        /// <returns>Si se consigue la string retornara True, de lo contrario False</returns>
        public static bool BuscarStringArray(string[] MatrizString, string Buscar, out List<int> Indice)
        {
            bool AuxBool = false;
            Indice = new List<int>();

            for (int i = 0; i < MatrizString.GetLength(0); i++)
            {
                if (MatrizString[i].ToLower().Contains(Buscar.ToLower()))
                {
                    AuxBool = true;
                    Indice.Add(i);
                }
            }
            return AuxBool;
        }
        /// <summary>
        /// Busca un valor decimal dentro de la matriz decimal. Tiene una lista out con los indices de fila de coincidencia
        /// </summary>
        /// <param name="MatrizInt"></param>
        /// <param name="Buscar"></param>
        /// <param name="IndexBuscar"></param>
        /// <param name="Indice"></param>
        /// <returns>Si se consigue el valor decimal retornara True, de los contrario False</returns>
        public static bool BuscarPorIntMatriz(int[,] MatrizInt, int Buscar, int IndexBuscar, out List<int> Indice)
        {
            bool AuxBool = false;
            Indice = new List<int>();

            for (int i = 0; i < MatrizInt.GetLength(0); i++)
            {
                if (Buscar == 0 && MatrizInt[i, IndexBuscar] == Buscar)
                {
                    AuxBool = true;
                    Indice.Add(i);
                }
                else if (Buscar == 20 && MatrizInt[i, IndexBuscar] <= Buscar)
                {
                    AuxBool = true;
                    Indice.Add(i);
                }
                else if (Buscar == 21 && MatrizInt[i, IndexBuscar] >= Buscar)
                {
                    AuxBool = true;
                    Indice.Add(i);
                }
            }
            return AuxBool;
        }
        /// <summary>
        /// Busca el valor mayor Int dentro de la matriz Int
        /// </summary>
        /// <param name="MatrizDecimal"></param>
        /// <param name="Indice"></param>
        /// <returns>El indice (Fila) del decimal mayor</returns>
        public static int IndiceDelMayor(int[,] MatrizInt, int Indice)
        {
            int Mayor = MatrizInt[0, Indice];
            int IndexMayor = 0;

            for (int i = 1; i < MatrizInt.GetLength(0); i++)
            {
                if (MatrizInt[i, Indice] > Mayor)
                {
                    Mayor = MatrizInt[i, Indice];
                    IndexMayor = i;
                }
            }

            return IndexMayor;
        }
        /// <summary>
        /// Busca el valor menor dentro de la columna dada como parametro
        /// </summary>
        /// <param name="MatrizInt"></param>
        /// <param name="Indice"></param>
        /// <returns>Retorna el indice de conincidencia</returns>
        public static int IndiceDelMenor(int[,] MatrizInt, int Indice)
        {
            int Menor = MatrizInt[0, Indice];
            int IndexMenor = 0;

            for (int i = 1; i < MatrizInt.GetLength(0); i++)
            {
                if (MatrizInt[i, Indice] < Menor && MatrizInt[i, Indice] != 0)
                {
                    Menor = MatrizInt[i, Indice];
                    IndexMenor = i;
                }
            }

            return IndexMenor;
        }
        /// <summary>
        /// Busca 
        /// </summary>
        /// <param name="MatrizInt"></param>
        /// <param name="Indice"></param>
        /// <returns></returns>
        public static int BuscarIndexInt(int[,] MatrizInt, int Indice)
        {
            int Mayor = MatrizInt[0, Indice];
            int IndexMayor = 0;

            for (int i = 1; i < MatrizInt.GetLength(0); i++)
            {
                if (MatrizInt[i, Indice] > Mayor)
                {
                    Mayor = MatrizInt[i, Indice];
                    IndexMayor = i;
                }
            }

            return IndexMayor;
        }
        /// <summary>
        /// Recibe como parametro 3 opiones a mostrar por consola
        /// </summary>
        /// <param name="Opcion1"></param>
        /// <param name="Opcion2"></param>
        /// <param name="Opcion3"></param>
        /// <param name="Texto"></param>
        /// <returns>Retorna opcion escojida</returns>
        public static int MostrarOpciones(string Opcion1, string Opcion2, string Opcion3, string Texto)
        {
            Console.Clear();
            Console.WriteLine($"Ingrese la {Texto} de productos que desear ver.");
            Console.WriteLine($"1-{Opcion1}\n2-{Opcion2}\n3-{Opcion3}");
            return ValidationInt("una opcion", 1, 3);
        }
        /// <summary>
        /// Busca un String dado como parametro dentro de un array de String
        /// </summary>
        /// <param name="Opcion1"></param>
        /// <param name="Opcion2"></param>
        /// <param name="Opcion3"></param>
        /// <param name="Texto"></param>
        /// <param name="ArrayString"></param>
        /// <returns>Lista de indices de coincidencia</returns>
        public static List<int> IndiceBuscadoArry(string Opcion1, string Opcion2, string Opcion3, string Texto, string[] ArrayString)
        {
            List<int> Idx = new List<int>();
            string[] AuxArr = new string[] { Opcion1, Opcion2, Opcion3 };
            int Opc = MostrarOpciones(Opcion1, Opcion2, Opcion3, Texto);

            switch (Opc)
            {
                case 1:
                    if (Validations.BuscarStringArray(ArrayString, AuxArr[0], out Idx))
                    {
                        return Idx;
                    }
                    break;
                case 2:
                    if (Validations.BuscarStringArray(ArrayString, AuxArr[1], out Idx))
                    {
                        return Idx;
                    }
                    break;
                case 3:
                    if (Validations.BuscarStringArray(ArrayString, AuxArr[2], out Idx))
                    {
                        return Idx;
                    }
                    break;
            }
            return null;
        }
        /// <summary>
        /// Busca un String dado como parametro dentro de una matriz String
        /// </summary>
        /// <param name="Opcion1"></param>
        /// <param name="Opcion2"></param>
        /// <param name="Opcion3"></param>
        /// <param name="Texto"></param>
        /// <param name="MatrizString"></param>
        /// <param name="Indice"></param>
        /// <returns>Lista de indices de coincidencia</returns>
        public static List<int> IndiceBuscadoMatriz(string Opcion1, string Opcion2, string Opcion3, string Texto, string[,] MatrizString, int Indice)
        {
            List<int> Idx = new List<int>();
            string[] AuxArr = new string[] { Opcion1, Opcion2, Opcion3 };
            int Opc = MostrarOpciones(Opcion1, Opcion2, Opcion3, Texto);

            switch (Opc)
            {
                case 1:
                    if (Validations.BuscarStringMatriz(MatrizString, AuxArr[0], Indice, out Idx))
                    {
                        return Idx;
                    }
                    break;
                case 2:
                    if (Validations.BuscarStringMatriz(MatrizString, AuxArr[1], Indice, out Idx))
                    {
                        return Idx;
                    }
                    break;
                case 3:
                    if (Validations.BuscarStringMatriz(MatrizString, AuxArr[2], Indice, out Idx))
                    {
                        return Idx;
                    }
                    break;
            }
            return null;
        }
    }
}



