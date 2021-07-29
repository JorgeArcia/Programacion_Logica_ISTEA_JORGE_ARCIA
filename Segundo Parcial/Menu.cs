using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo_Parcial
{
    class Menu
    {
        private FrontEnd Front = new FrontEnd();
        /// <summary>
        /// Muestra por consola portada de bienvenida
        /// </summary>
        private void Portada()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************\n" +
                              "************************************\n" +
                              "**                                **\n" +
                              "**          Bienvenido            **\n" +
                              "**                                **\n" +
                              "**       Allegro Instrumentos     **\n" +
                              "**                                **\n" +
                              "************************************\n" +
                              "************************************");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Presione para entrar.");
            Console.ReadKey();
        }
        /// <summary>
        /// Confirmacion de salida del programa
        /// </summary>
        /// <returns>True o False para salir del programa</returns>
        private bool ConfirmExit()
        {
            bool Auxbool = true;
            string AuxString;

            Console.Clear();

            Console.WriteLine("Salir de la App? [SI/NO]");
            AuxString = Console.ReadLine().ToLower().Trim();

            int aux = 0;
            while (aux == 0)
            {

                if (AuxString == "si")
                {
                    aux = 1;
                    break;
                }
                else if (AuxString == "no")
                {
                    aux = 1;
                    Auxbool = false;
                }
                else
                {
                    Console.WriteLine("ERROR. Escriba SI o NO.");
                    aux = 0;
                    AuxString = Console.ReadLine().Trim().ToLower();
                }
            }
            Console.WriteLine("Hasta luego");
            return Auxbool;
        }
        /// <summary>
        /// Carga los datos escritos a una matriz
        /// </summary>
        /// <returns>Nueva matriz de datos ingresados</returns>
        private string[,] CargarMatrizProducto()
        {
            string[,] Productos = { {"12","Bateria Stage Custom","Percusion","Yamaha"},
                                     {"4","Guitarra Telecaster","Guitarra","Fender"},
                                     {"16","Bateria Vintage Rock","Percusion","Mapex"},
                                     {" "," "," ",""},
                                     {"68","Parche Bombo 22","Percusion","Yamaha"},
                                     {"65","Púa Vintage","Guitarra","Fender"},
                                     {"21","Teclado Kronos","Teclado","Korg"},
                                     {" "," "," ",""},
                                     {"19","Doble bombo","Percusion","Mapex"},
                                     {"69","Amplificador 25W","Guitarra","Ibanez"},
                                     {" "," "," ",""},
                                     {"78","Soporte Teclado","Teclado","Korg"} };

            return Productos;
        }
        /// <summary>
        /// Carga los datos Int escritos a una matriz Int
        /// </summary>
        /// <returns>Nueva matriz de datos ingresado</returns>
        private int[,] CargarMatrizContable()
        {
            int[,] Contable = { {2100,10,2},
                                {1700,14,7},
                                {2600,7,3},
                                {0,0,0},
                                {125,63,24},
                                {75,150,65},
                                {2600,5,1},
                                {0,0,0},
                                {850,25,12},
                                {1100,17,8},
                                {0,0,0},
                                {250,35,19},};

            return Contable;
        }
        /// <summary>
        /// Carga los datos Int escritos a Array String
        /// </summary>
        /// <returns>Nueva array de datos ingresado</returns>
        private string[] CargarDepartamento()
        {
            string[] Seccion = {"Instrumento",
                                "Instrumento",
                                "Instrumento",
                                " ",
                                "Accesorio",
                                "Accesorio",
                                "Instrumento",
                                " ",
                                "Accesorio",
                                "Sonido",
                                " ",
                                "Accesorio"};

            return Seccion;
        }
        /// <summary>
        /// Carga los datos String escritos a Array String
        /// </summary>
        /// <returns></returns>
        private string[] CargarGama()
        {
            string[] Seccion = {"Alta",
                                "Media",
                                "Media",
                                " ",
                                "Alta",
                                "Baja",
                                "Alta",
                                " ",
                                "Baja",
                                "Baja",
                                " ",
                                "Media"};

            return Seccion;
        }
        /// <summary>
        /// Carga los datos iniciales de una matriz luego a suministrarle informacion
        /// </summary>
        /// <returns>Matriz de Int inicializada en 0</returns>
        private int[,] CargarFacturacion()
        {
            int[,] Facturacion = { {0,0},
                                   {0,0},
                                   {0,0},
                                   {0,0},
                                   {0,0},
                                   {0,0},
                                   {0,0},
                                   {0,0},
                                   {0,0},
                                   {0,0},
                                   {0,0},
                                   {0,0},};

            return Facturacion;
        }

        /// <summary>
        /// Ejecuta el Menu
        /// </summary>
        public void AllegroMenu()
        {
            #region MyRegion
            int Opcion, SubOpcion;
            bool Salida = false;
            const int CantidadProductos = 25;

            string[,] DetalleProducto = new string[CantidadProductos, 4];
            int[,] Contable = new int[CantidadProductos, 3];
            int[,] Facturacion = new int[CantidadProductos, 2];
            string[] Departamento = new string[CantidadProductos];
            string[] Gama = new string[CantidadProductos];
            #endregion
            
            DetalleProducto = CargarMatrizProducto();
            Contable = CargarMatrizContable();
            Departamento = CargarDepartamento();
            Gama = CargarGama();
            Facturacion = CargarFacturacion();

            Portada();

            while (Salida == false)
            {
                Console.Clear();
                Prints.MostrarMenu();
                Opcion = Validations.ValidationInt("una opcion", 1, 7);

                switch (Opcion)
                {
                    case 1:
                        Prints.MenuMostrar();
                        SubOpcion = Validations.ValidationInt("una opcion", 1, 8);

                        switch (SubOpcion)
                        {
                            case 1:
                                Front.MostrarTodo(DetalleProducto, Contable, Departamento, Gama);
                                break;
                            case 2:
                                Front.MostrarSegunProducto(DetalleProducto, Contable, Departamento, Gama);
                                break;
                            case 3:
                                Front.MostrarPorMarca(DetalleProducto, Contable, Departamento, Gama);
                                break;
                            case 4:
                                Front.MostrarPorDepartamento(DetalleProducto, Contable, Departamento, Gama);
                                break;
                            case 5:
                                Front.MostrarPorGama(DetalleProducto, Contable, Departamento, Gama);
                                break;
                            case 6:
                                Front.MostrarPorStock(DetalleProducto, Contable, Departamento, Gama);
                                break;
                            case 7:
                                Front.MostrarMayor(DetalleProducto, Contable, Departamento, Gama);
                                break;
                            case 8:
                                Front.MostrarMenor(DetalleProducto, Contable, Departamento, Gama);
                                break;
                        }
                        break;
                    case 2:
                        Prints.MenuBuscar();
                        SubOpcion = Validations.ValidationInt("una opcion", 1, 2);
                        Front.Buscar(DetalleProducto, Contable, Departamento, Gama, SubOpcion - 1);
                        break;
                    case 3:
                        Front.Agregar(DetalleProducto, Contable, Departamento, Gama);
                        break;
                    case 4:
                        Front.Modificar(DetalleProducto, Contable, Departamento, Gama);
                        break;
                    case 5:
                        Front.Eliminar(DetalleProducto, Contable, Departamento, Gama);
                        break;
                    case 6:
                        Prints.MenuFacturacion();
                        SubOpcion = Validations.ValidationInt("una opcion", 1, 4);

                        switch (SubOpcion)
                        {
                            case 1:
                                Front.ProductoMayorFact(DetalleProducto,Contable,Facturacion);
                                break;
                            case 2:
                                Front.FacturaPorCategoria(DetalleProducto,Contable,Facturacion);
                                break;
                            case 3:
                                Front.FacturacionDescendente(DetalleProducto, Contable, Facturacion);
                                Console.ReadKey();
                                break;
                            case 4:
                                Front.MostrarTodoFacturacion(DetalleProducto,Contable,Departamento,Gama,Facturacion);
                                break;
                        }
                        break;
                    case 7:
                        Salida = ConfirmExit();
                        break;
                }
            }
        }
    }
}
