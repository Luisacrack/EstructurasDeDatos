using System;
using EstructurasDeDatos;

namespace EstructurasDeDatos
{
    public class Program
    {
         
        public static void Main(string[] args)
        {
            bool salir = false;

            Console.WriteLine("Bienvenido a La lista de armadura de IronMan");
            ListArmorIronman armadura = new ListArmorIronman();
            Item Casco = new Item("Casco de Iron Man", 1, "Este casco Iconico tiene super durabilidad y soporta las bajas temperaturas");
            Item Guanteles = new Item("Guanteles Mark85", 2, "Están equipados con repulsores de energía en las palmas para volar y atacar, además de sistemas de armas, sensores y protección reforzada.");
            Item BotasPropulsoras = new Item("BotasPropulsoras", 3, "Las botas de Iron Man forman parte integral de su armadura y están diseñadas para propulsión y estabilidad en vuelo.");

            armadura.AddNewNode(Casco);
            armadura.AddNewNode(Guanteles);
            armadura.AddNewNode(BotasPropulsoras);
            armadura.MostrarItems();



            while (!salir)
            {
                Console.WriteLine("Bienvenido al Menu");
                Console.WriteLine(" Presiona 1 si quieres AGREGAR un nuevo componente");
                Console.WriteLine(" Presiona 2 si quieres ELIMINAR un componente Dañado");
                Console.WriteLine(" Presiona 3 si quieres  un MOSTRAR los componentes de la Lista");
                Console.WriteLine(" Presiona 4 si quieres SALIR");
                string? opcionUsuario = Console.ReadLine();

                int num;
                Console.WriteLine();

                bool esNumeroValido = int.TryParse(opcionUsuario, out num);
                
                if (esNumeroValido)
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Agregarnuevo componente");
                            Console.Write("Nombre del Componente que quieres agregar : ");
                            string? nombre = Console.ReadLine()??"";

                            Console.WriteLine("Cantidad de el componente que quieres agregar : ");
                            string cantidadString = Console.ReadLine();

                            int cantidad = int.Parse(cantidadString);

                            Console.WriteLine("Ingresa la Descripcion del nuevo componente");
                            string? descripcion = Console.ReadLine() ??"";

                            armadura.AgregarComponente(nombre, cantidad, descripcion);
                            break;

                        case 2:
                            Console.WriteLine("Eliminar Componente Dañado");
                            Console.Write("ingresa el nombre del componente que deseas Eliminar");
                            string? nombreEliminar = Console.ReadLine() ?? "";
                            if (!string.IsNullOrEmpty(nombreEliminar))
                            {
                                armadura.EliminarComponente(nombreEliminar);
                            }
                            else
                            {
                                Console.WriteLine("No se ha ingresado un nombre a eliminar valido");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Mostrar Los componentes de la lista");
                            armadura.MostrarItems();
                            break;
                        case 4:
                            Console.WriteLine("HAZ SALIDO DEL MENU ADIOS");
                            salir=true;
                            break;
                    }
                } 

            }
             
              
        }
    }
}
