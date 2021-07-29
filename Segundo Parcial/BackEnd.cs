using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo_Parcial
{
    class BackEnd
    {
        /// <summary>
        /// Recibe todos los datos del modelo como parametro y tambien los datos nuevos a agregar dentro, con un indicie con los index
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizDecimal"></param>
        /// <param name="ArrayString1"></param>
        /// <param name="ArrayString2"></param>
        /// <param name="Indice"></param>
        /// <param name="DataString"></param>
        /// <param name="DataDecimal"></param>
        /// <param name="Dato1"></param>
        /// <param name="Dato2"></param>
        /// <param name="AuxIdx"></param>
        public void Agregar(string[,] MatrizString, int[,] MatrizInt, string[] ArrayString1, string[] ArrayString2, List<int> Indice,
                            string[] DataString, int[] DataInt, string Dato1, String Dato2, int AuxIdx)
        {
            for (int i = 0; i < MatrizString.GetLength(1); i++)
            {
                MatrizString[Indice[AuxIdx - 1], i] = DataString[i];
            }
            for (int i = 0; i < MatrizInt.GetLength(1); i++)
            {
                MatrizInt[Indice[AuxIdx - 1], i] = DataInt[i];
            }
            ArrayString1[Indice[AuxIdx - 1]] = Dato1;
            ArrayString2[Indice[AuxIdx - 1]] = Dato2;
        }
        /// <summary>
        /// Crea la matriz facturacion efectuando operacion matematica de matriz contable
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizIntContable"></param>
        /// <param name="MatrizIntFacturacion"></param>
        public void Facturacion(string[,] MatrizString, int[,] MatrizIntContable, int[,] MatrizIntFacturacion)
        {
            int AuxInt;

            for (int i = 0; i < MatrizString.GetLength(0); i++)
            {
                AuxInt = MatrizIntContable[i, 0] * MatrizIntContable[i, 2];
                for (int x = 0; x < MatrizIntFacturacion.GetLength(1); x++)
                {
                    switch (x)
                    {
                        case 0:
                            MatrizIntFacturacion[i, x] = Validations.ConvertIntString(MatrizString[i, 0]); //Validations.ValidationDecimal(MatrizString[i, 0], 0, decimal.MaxValue);
                            break;
                        case 1:
                            MatrizIntFacturacion[i, x] = AuxInt;
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// Ordena de manera Descendente una matriz Int ingresada como parametro
        /// </summary>
        /// <param name="MatrizInt"></param>
        /// <param name="Indice"></param>
        /// <returns></returns>
        public int[,] OrdenarDescendente(int[,] MatrizInt, int Indice)
        {
            int[,] MatrizAux = new int[MatrizInt.GetLength(0), MatrizInt.GetLength(1)];
            int[] Array0 = new int[MatrizInt.GetLength(0)];


            for (int i = 0; i < MatrizInt.GetLength(0); i++)
            {
                Array0[i] = MatrizInt[i, Indice];
            }
            Array.Sort(Array0);
            Array.Reverse(Array0);
            for (int i = 0; i < MatrizAux.GetLength(0); i++)
            {
                for (int x = 0; x < MatrizAux.GetLength(1); x++)
                {

                    for (int z = 0; z < MatrizAux.GetLength(0); z++)
                    {
                        if (Array0[i] == MatrizInt[z, 1])
                        {
                            MatrizAux[i, x] = MatrizInt[z, x];
                        }
                    }
                }
            }
            return MatrizAux;
        }
        /// <summary>
        /// Ordena una segunda matriz por los indices de la primera
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <returns></returns>
        public List<int> Ordenar2Matrices(string[,] MatrizString, int[,] MatrizInt)
        {
            List<int> Indice = new List<int>();

            string[,] MatrizAux = new string[MatrizString.GetLength(0), MatrizString.GetLength(1)];

            for (int i = 0; i < MatrizString.GetLength(0); i++)
            {

                for (int x = 0; x < MatrizString.GetLength(0); x++)
                {
                    if (MatrizString[x, 0] == MatrizInt[i, 0].ToString())
                    {
                        Indice.Add(x);
                    }
                }

            }
            return Indice;
        }
    }
}
