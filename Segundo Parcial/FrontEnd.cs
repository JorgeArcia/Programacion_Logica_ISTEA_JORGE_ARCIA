using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo_Parcial
{
    class FrontEnd
    {
        private BackEnd Back = new BackEnd();
   
        private string[] Membrete = new string[] { "IdProducto", "Producto", "Categoria", "Marca", "Precio", "Stock", "Vendidos", "Departamento", "Gama" };
        /// <summary>
        /// Presiona cualquier tecla para continual
        /// </summary>
        static void PresionarContinuar()
        {
            Console.WriteLine();
            Console.WriteLine("Presione para volver al menu principal.");
            Console.ReadKey();
        }
        /// <summary>
        /// Limpia la pantalla y muestra por consola un Array de String constante
        /// </summary>
        private static void PrintMenbrete()
        {
            string[] Menbrete = new string[] { "IdProducto", "Producto", "Categoria", "Marca", "Precio", "Stock", "Vendidos", "Departamento", "Gama" };
            Console.Clear();
            Console.WriteLine();
            Prints.PrintMenbrete(Menbrete);
        }
        /// <summary>
        /// Limpia la pantalla y muestra por consola un Array de String constante
        /// </summary>
        private static void PrintMenbreteFinal()
        {
            string[] Menbrete = new string[] { "IdProducto", "Producto", "Categoria", "Marca", "Precio", "Stock", "Vendidos","Facturacion"};
            Console.Clear();
            Console.WriteLine();
            Prints.PrintMenbrete(Menbrete);
        }
        /// <summary>
        /// Limpia la pantalla y muestra por consola un Array de String constante
        /// </summary>
        private static void PrintMenbreteFac()
        {
            string[] menbrete = new string[] { "IdProducto", "Producto", "Categoria", "Marca", "Precio", "Stock", "Vendidos" };
            Console.Clear();
            Prints.PrintMenbrete(menbrete);
        }
        /// <summary>
        /// Limpia la pantalla y muestra por consola un Array de String constante
        /// </summary>
        private static void PrintMenbreteFactFinal()
        {
            string[] menbrete = new string[] { "IdProducto", "Producto", "Categoria", "Marca", "Precio", "Stock", "Departamento", "Gama" , "Vendidos", "IdProducto", "Facturacion" };
            Console.Clear();
            Prints.PrintMenbrete(menbrete);
        }
        /// <summary>
        /// Muestra por consola los datos ingresados como parametros
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public void MostrarTodo(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            PrintMenbrete();
            Prints.PrintAllData(MatrizString, MatrizInt, Departamento, Gama);
            PresionarContinuar();
        }
        /// <summary>
        /// Pregunta al usuario que categoria quiere buscar y muestra por consola coincidencias
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public void MostrarSegunProducto(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            List<int> Idx = new List<int>();
            Idx = Validations.IndiceBuscadoMatriz("Percusion", "Guitarra", "Teclado", "categoria", MatrizString, 2);
            PrintMenbrete();
            Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Idx);

            PresionarContinuar();
        }
        /// <summary>
        /// Pregunta al usuario que marca de producto quiere buscar y muestra por consola coincidencias
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public void MostrarPorMarca(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            List<int> Indice = new List<int>();
            string Buscar;

            Console.Clear();
            Console.WriteLine("Ingrese la marca del productos que desea ver");
            Buscar = Validations.PedirString("Marca");

            PrintMenbrete();
            if (Validations.BuscarStringMatriz(MatrizString, Buscar, 3, out Indice))
            {
                Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Indice);
            }
            else
            {
                Console.WriteLine($"La marca ingresada {Buscar}. No se encuentra en nuestra base de datos.\n\nTe sugerimos nuestras marcas:Korg -- Mapex -- Yamaha -- Fender -- Ibanez");
            }
            PresionarContinuar();
        }
        /// <summary>
        /// Pregunta al usuario que departamento de producto quiere buscar y muestra por consola coincidencias
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public void MostrarPorDepartamento(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            List<int> Idx = new List<int>();

            Idx = Validations.IndiceBuscadoArry("Instrumento", "Accesorio", "Sonido", "departamento", Departamento);
            PrintMenbrete();
            Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Idx);

            PresionarContinuar();
        }
        /// <summary>
        /// Pregunta al usuario que gama de producto quiere buscar y muestra por consola coincidencias
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public void MostrarPorGama(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            List<int> Indice = new List<int>();

            Indice = Validations.IndiceBuscadoArry("Alta", "Media", "Baja", "gama", Gama);
            PrintMenbrete();
            Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Indice);

            PresionarContinuar();
        }
        /// <summary>
        /// Pregunta al usuario valores de stock de los productos quiere buscar y muestra por consola coincidencias
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public void MostrarPorStock(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            List<int> Indice = new List<int>();
            int Opcion;

            Console.Clear();
            Console.WriteLine("Ingrese el stock de productos que desea ver");
            Console.WriteLine("1-Sin Stock\n2-Stock menor a 20\n3-Stock mayor a 20");
            Opcion = Validations.ValidationInt("una opcion", 1, 3);

            PrintMenbrete();
            switch (Opcion)
            {
                case 1:
                    if (Validations.BuscarPorIntMatriz(MatrizInt, 0, 1, out Indice))
                    {
                        Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Indice);
                    }
                    break;
                case 2:
                    if (Validations.BuscarPorIntMatriz(MatrizInt, 20, 1, out Indice))
                    {
                        Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Indice);
                    }
                    break;
                    if (Validations.BuscarPorIntMatriz(MatrizInt, 21, 1, out Indice))
                    {
                        Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Indice);
                    }
                case 3:
                    break;
            }
            PresionarContinuar();
        }
        /// <summary>
        /// Busca el valor mayor dentro de una matriz Int dada por parametro y muestra coincidencias por consola
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public void MostrarMayor(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            List<int> Indice = new List<int>();
            int Mayor = Validations.IndiceDelMayor(MatrizInt, 2);

            Indice.Add(Mayor);
            Console.WriteLine("El producto mas vendido: ");
            Console.WriteLine();
            PrintMenbrete();
            Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Indice);
            PresionarContinuar();
        }
        /// <summary>
        /// Busca el valor menor dentro de una matriz Int dada por parametro y muestra coincidencias por consola
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public void MostrarMenor(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            List<int> Indice = new List<int>();
            int Menor = Validations.IndiceDelMenor(MatrizInt, 2);

            Indice.Add(Menor);
            Console.WriteLine("El producto mas vendido: ");
            Console.WriteLine();
            PrintMenbrete();
            Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Indice);
            PresionarContinuar();
        }
        /// <summary>
        /// Pregunta al usuario si quiere buscar por ID o nombre dentro de la matriz String de datos
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        /// <param name="NameOrId"></param>
        public void Buscar(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama, int NameOrId)
        {
            string[] Aux = new string[] { "Id", "Nombre" };
            string Buscar;
            List<int> Indice = new List<int>();

            Console.WriteLine($"Debera ingresar {Aux[NameOrId]} del producto a buscar.");
            Console.WriteLine();
            Buscar = Validations.PedirString($"{Aux[NameOrId]}");
            Console.WriteLine();

            PrintMenbrete();
            if (Validations.BuscarStringMatriz(MatrizString, Buscar, NameOrId, out Indice))
            {
                Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Indice);
            }
            else
            {
                Console.WriteLine($"ERROR. El {Aux[NameOrId]} del producto no esta en nuestra base de datos.");
            }
            PresionarContinuar();
        }
        /// <summary>
        /// Evalua si hay espacio disponible para agregar, si lo hay. pide al usuario los datos completos del modelo para agregar datos
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public void Agregar(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            List<int> Indice = new List<int>();
            string[] AuxDatosString = new string[4];
            int[] AuxDatosInt = new int[3];
            string AuxDepartamento = " ";
            string AuxGama = " ";

            if (Validations.BuscarStringMatriz(MatrizString, " ", 1, out Indice))
            {
                Console.WriteLine("Si se puede ingresar un producto mas. Debera ingresar toda la data.");
                Console.WriteLine();
                for (int c = 0; c < Membrete.Length; c++)
                {
                    for (int f = 0; f < AuxDatosString.Length; f++)
                    {
                        AuxDatosString[f] = Validations.PedirString(this.Membrete[c]);
                        c++;
                    }
                    for (int f = 0; f < AuxDatosInt.Length; f++)
                    {
                        AuxDatosInt[f] = Validations.ValidationInt(this.Membrete[c], 0, int.MaxValue);
                        c++;
                    }
                    AuxDepartamento = Validations.PedirString(this.Membrete[c]);
                    c++;
                    AuxGama = Validations.PedirString(this.Membrete[c]);
                    c++;
                }

                Back.Agregar(MatrizString, MatrizInt, Departamento, Gama, Indice, AuxDatosString, AuxDatosInt, AuxDepartamento, AuxGama,0);
                Console.WriteLine($"El producto {AuxDatosString[1]}. Fue agregado correctamente.");
            }
            else
            {
                Console.WriteLine("No es posible agregar el articulo por falta de espacio");
            }
            PresionarContinuar();
        }
        /// <summary>
        /// Pregunta al usuario si deseea escojer Nombre o Id
        /// </summary>
        /// <param name="IndiceColumna"></param>
        /// <returns></returns>
        private string NombreOId(out int IndiceColumna)
        {
            int AuxInt;
            IndiceColumna = 0;

            Console.Clear();
            Console.WriteLine("Tendra que seleccionar que tipo de dato quiere ingresar");
            Console.WriteLine("1-Ingresar Nombre\n2-Ingresar IdProducto");
            AuxInt = Validations.ValidationInt("opcion", 0, 3);

            if (AuxInt == 1)
            {
                IndiceColumna = 1;
                return Validations.PedirString("Nombre");
            }
            else
            {
                IndiceColumna = 0;
                return Validations.PedirString("IdProducto");
            }
        }
        /// <summary>
        /// Busca un producto por Id o Nombre y pregunta si quiere modificarlo, de ser asi modifica el producto seleccionado
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public void Modificar(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            string[] AuxDatosString = new string[4];
            int[] AuxDatosInt = new int[3];
            string AuxDepartamento = " ";
            string AuxGama = " ";
            int Indice;
            int AuxIdx = 0;
            string Buscar = this.NombreOId(out Indice);

            Console.Clear();
            PrintMenbrete();

            if (Validations.BuscarStringMatriz(MatrizString, Buscar, Indice, out List<int> Idx))
            {
                Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Idx);
                if (Idx.Count > 1)
                {
                    AuxIdx = Validations.ValidationInt("Cual producto desea modificar (Ingrese el order de producto descendente)", 1, Idx.Count);
                    Console.WriteLine($"El producto seleccionado es: {MatrizString[Idx[AuxIdx - 1], 1]}");
                }
                Console.WriteLine();
                Console.WriteLine("Quieres modificar este producto? [SI / NO]");
                if (Validations.ValidarSI(Console.ReadLine().Trim().ToLower()))
                {
                    for (int i = 0; i < this.Membrete.Length; i++)
                    {
                        for (int x = 0; x < AuxDatosString.Length; x++)
                        {
                            AuxDatosString[x] = Validations.PedirString(this.Membrete[i]);
                            i++;
                        }
                        for (int x = 0; x < AuxDatosInt.Length; x++)
                        {
                            AuxDatosInt[x] = Validations.ValidationInt(this.Membrete[i], 0, int.MaxValue);
                            i++;
                        }
                        AuxDepartamento = Validations.PedirString(this.Membrete[i]);
                        i++;
                        AuxGama = Validations.PedirString(this.Membrete[i]);
                        i++;
                    }

                    Back.Agregar(MatrizString, MatrizInt, Departamento, Gama, Idx, AuxDatosString, AuxDatosInt, AuxDepartamento, AuxGama, AuxIdx);
                    Console.WriteLine($"El producto {AuxDatosString[1]} fue agregado correctamente");
                }
            }
            else
            {
                if (Indice == 0)
                {
                    Console.WriteLine($"No existe el producto con Id {Buscar} en nuestra base de datos");
                }
                else
                {
                    Console.WriteLine($"No existe el producto con nombre {Buscar} en nuestra base de datos");
                }
            }
            PresionarContinuar();
        }
        /// <summary>
        /// Busca un producto por Nombre o Id si este existe, pregunta al usuario si desea elminarlo, de ser asi lo elimina donde los valores inciales String  = null, Int = 0
        /// </summary>
        /// <param name="MatrizString"></param>
        /// <param name="MatrizInt"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        public void Eliminar(string[,] MatrizString, int[,] MatrizInt, string[] Departamento, string[] Gama)
        {
            string[] AuxStringArr = new string[] { " ", " ", " ", " " };
            int[] AuxIntArr = new int[] { 0, 0, 0 };
            string AuxString = " ";
            int Indice;
            int AuxIdx = 0;
            string Buscar = this.NombreOId(out Indice);

            Console.Clear();
            PrintMenbrete();
            if (Validations.BuscarStringMatriz(MatrizString, Buscar, Indice, out List<int> Idx))
            {
                Prints.PrintData(MatrizString, MatrizInt, Departamento, Gama, Idx);
                Console.WriteLine();
                if (Idx.Count > 1)
                {
                    AuxIdx = Validations.ValidationInt("cual producto desea modificar", 1, Idx.Count);
                    Console.WriteLine($"El producto seleccionado es: {MatrizString[Idx[AuxIdx - 1], 1]}");
                }
                Console.WriteLine();
                Console.WriteLine("Quieres eliminar este producto? [SI / NO]");
                if (Validations.ValidarSI(Console.ReadLine().Trim().ToLower()))
                {
                    Back.Agregar(MatrizString, MatrizInt, Departamento, Gama, Idx, AuxStringArr, AuxIntArr, AuxString, AuxString, AuxIdx);
                    Console.WriteLine($"El producto fue eliminado correctamente");
                }
                else
                {
                    PresionarContinuar();
                }
            }
            else
            {
                if (Indice == 0)
                {
                    Console.WriteLine($"No existe el producto con Id {Buscar} en nuestra base de datos");
                }
                else
                {
                    Console.WriteLine($"No existe el producto con nombre {Buscar} en nuestra base de datos");
                }
            }
            PresionarContinuar();
        }
        /// <summary>
        /// Crea dandole valores a la matriz facturacion, busca el producto con el numero de facturacion mas algo y lo muestra por consola
        /// </summary>
        /// <param name="Producto"></param>
        /// <param name="Inventario"></param>
        /// <param name="Facturacion"></param>
        public void ProductoMayorFact(string[,] Producto, int[,] Inventario, int[,] Facturacion)
        {
            Back.Facturacion(Producto, Inventario, Facturacion);
            int Indx = Validations.BuscarIndexInt(Facturacion, 1);

            Console.Clear();
            PrintMenbreteFac();
            Prints.PrintData(Producto, Inventario, Indx);
            Console.WriteLine();
            Console.WriteLine($"El producto {Producto[Indx, 1]} facturo: {Facturacion[Indx, 1]}$");
            PresionarContinuar();
        }
        /// <summary>
        /// Muestra por consola todos los datos de los parametros ingresados en orden descendente
        /// </summary>
        /// <param name="Producto"></param>
        /// <param name="Inventario"></param>
        /// <param name="Facturacion"></param>
        public void FacturacionDescendente(string[,] Producto, int[,] Inventario, int[,] Facturacion)
        {
            Console.Clear();
            List<int> Indice = new List<int>();
            int[,] MatrizAux;

            Back.Facturacion(Producto, Inventario, Facturacion);
            MatrizAux = Back.OrdenarDescendente(Facturacion, 1);
            Indice = Back.Ordenar2Matrices(Producto, MatrizAux);

            PrintMenbreteFinal();
            Prints.PrintData(Producto, Inventario, Facturacion, Indice);
            PresionarContinuar();

        }
        /// <summary>
        /// Crea Matriz de facturacion y muestra por consola coincidencias con categoria dada por el usuario
        /// </summary>
        /// <param name="Producto"></param>
        /// <param name="Inventario"></param>
        /// <param name="Facturacion"></param>
        public void FacturaPorCategoria(string[,] Producto, int[,] Inventario, int[,] Facturacion)
        {
            int Opcion;
            List<int> Indice = new List<int>();
            int[,] MatrizAux;

            Back.Facturacion(Producto, Inventario, Facturacion);
            MatrizAux = Back.OrdenarDescendente(Facturacion, 1);
            Indice = Back.Ordenar2Matrices(Producto, MatrizAux);

            Console.Clear();
            Console.WriteLine("Ingrese la categoria de productos que desea ver");
            Console.WriteLine("1-Percusion\n2-Guitarra\n3-Teclado");
            Opcion = Validations.ValidationInt("una opcion", 1, 3);

            PrintMenbreteFinal();
            switch (Opcion)
            {
                case 1:
                    if (Validations.BuscarStringMatriz(Producto, "Percusion", 2, out Indice))
                    {
                        Prints.PrintData(Producto, Inventario, Facturacion, Indice);
                    }
                    break;
                case 2:
                    if (Validations.BuscarStringMatriz(Producto, "Guitarra", 2, out Indice))
                    {
                        Prints.PrintData(Producto, Inventario, Facturacion, Indice);
                    }
                    break;
                case 3:
                    if (Validations.BuscarStringMatriz(Producto, "Teclado", 2, out Indice))
                    {
                        Prints.PrintData(Producto, Inventario, Facturacion, Indice);
                    }
                    break;
            }
            PresionarContinuar();

        }
        /// <summary>
        /// Crea matriz facturacion y muestra por consola todos los datos ingresados como parametro
        /// </summary>
        /// <param name="Producto"></param>
        /// <param name="Inventario"></param>
        /// <param name="Departamento"></param>
        /// <param name="Gama"></param>
        /// <param name="Facturacion"></param>
        public void MostrarTodoFacturacion(string[,] Producto, int[,] Inventario, string[] Departamento, string[] Gama, int[,] Facturacion)
        {
            Console.Clear();
            List<int> Indice = new List<int>();

            Back.Facturacion(Producto, Inventario, Facturacion);
            Indice = Back.Ordenar2Matrices(Producto, Facturacion);

            PrintMenbreteFactFinal();
            Prints.PrintData(Producto,Inventario,Departamento,Gama,Facturacion);
            PresionarContinuar();
        }
    }
}