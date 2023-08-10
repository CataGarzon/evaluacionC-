using System;
using System.Collections.Generic;

namespace EvaluacionCatalina
{
    class Program
    {
        static void Main(string[] args)
        {
            orden Orden = new orden();
            habitacion Habitacion = new habitacion();
            List<paciente> pacientes = new List<paciente>();
            List<Medico> medicos = new List<Medico>();


            bool salir = false;


       

            static void MostrarOpcionesMenu()
            {
                Console.WriteLine("Bienvenido al sistema del hospital.\nEste es nuestro menú: ");
                Console.WriteLine("-1. Crear Médico");
                Console.WriteLine("-2. Crear Paciente");
                Console.WriteLine("-3. Crear Habitación");
                Console.WriteLine("-4. Crear Orden");
                Console.WriteLine("-5. Generar Orden de Salida");
                Console.WriteLine("-6. Facturar Orden");
                Console.WriteLine("-7. Reportes");
            }
            MostrarOpcionesMenu();



            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)

            {
                case 1:
                    Console.WriteLine("Opción 1: Crear Médico");
                    medicos.Add(CrearMedico());

                    Console.WriteLine("1. Volver al menú");
                    Console.WriteLine("2. Salir");

                    int subOption = int.Parse(Console.ReadLine());

                    if (subOption == 1)
                    {
                        MostrarOpcionesMenu();
                    }
                    else if (subOption == 2)
                    {
                        salir = true; 
                    }
                    break;
                case 2:
                    Console.WriteLine("Opción 2: Crear Paciente");
                    pacientes.Add(CrearPaciente());
                    break;
                case 3:
                    Console.WriteLine("Opción 3: Crear Habitación");
       
                    break;
                case 4:
                    Console.WriteLine("Opción 4: Crear Orden");
                  
                    break;
                case 5:
                    Console.WriteLine("Opción 5: Generar Orden de Salida");
                  
                    break;
                case 6:
                    Console.WriteLine("Opción 6: Facturar Orden");
                    Console.WriteLine("ingrese el numero de la orden: ");
                    break;
                case 7:
                    Console.WriteLine("Opción 7:reportes");
                    Console.WriteLine("1 Listar Todos los Pacientes:");
                    Console.WriteLine("2 Listar Todos los Médicos:");
                    Console.WriteLine("3 Listar Todas las Ordenes:");
                    Console.WriteLine("4 Listar Orden por número:");
                    Console.WriteLine("5 Listar Ordenes por médico:");
                    Console.WriteLine("6 Listar Ordenes Creadas:");
                    Console.WriteLine("7 Listar Ordenes con Autorización de Salida");
                    Console.WriteLine("8 Listar Ordenes Facturadas");
                    Console.WriteLine("9 Listar Ordenes fecha");

                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Información de los pacientes:");
                            MostrarPacientes(pacientes);

                            Console.WriteLine("1 volver al menu");
                            Console.WriteLine("2 Salir");

                            opcion = int.Parse(Console.ReadLine());

                            if (opcion == 1)
                            {
                                MostrarOpcionesMenu();
                            }
                            break;
                        case 2:
                            Console.WriteLine("Información de los médicos:");
                            MostrarMedicos(medicos);
                            break;
                    }
                    break;
                    case 8:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

            static Medico CrearMedico()
            {
                Console.Write("Ingrese número de identificación: ");
                int numeroIdentificacion = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el nombre del médico: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese los apellidos del médico: ");
                string apellidos = Console.ReadLine();

                Console.Write("Ingrese el teléfono del médico: ");
                string telefono = Console.ReadLine();

                Console.Write("Ingrese la fecha de nacimiento del médico (YYYY-MM-DD): ");
                DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

                Console.Write("Ingrese el número de licencia del médico: ");
                string numeroLiciencia = Console.ReadLine();

                Console.Write("Ingrese la especialidad del médico: ");
                string especialidad = Console.ReadLine();

                return new Medico(numeroIdentificacion, nombre, apellidos, telefono, fechaNacimiento, numeroLiciencia, especialidad);
            }

       

            static paciente CrearPaciente()
            {
                Console.Write("Ingrese número de identificación: ");
                int numeroIdentificacion = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el nombre del paciente: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese los apellidos del paciente: ");
                string apellidos = Console.ReadLine();

                Console.Write("Ingrese el teléfono del paciente: ");
                string telefono = Console.ReadLine();

                Console.Write("Ingrese la fecha de nacimiento del paciente (YYYY-MM-DD): ");
                DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

                Console.Write("Ingrese la dirección del paciente: ");
                string direccion = Console.ReadLine();

                Console.Write("Ingrese el nombre del familiar: ");
                string nombreFamiliar = Console.ReadLine();

                Console.Write("Ingrese el teléfono del familiar: ");
                string telefonoFamilia = Console.ReadLine();

                return new paciente(numeroIdentificacion, nombre, apellidos, telefono, fechaNacimiento, direccion, nombreFamiliar, telefonoFamilia);
            }
            static void MostrarMedicos(List<Medico> medicos)
        {
            foreach (var medico in medicos)
            {
                Console.WriteLine($"ID: {medico.NumeroIdentificacion}, Nombre: {medico.Nombre}, Apellidos: {medico.Apellidos}, Teléfono: {medico.Telefono}, Fecha Nacimiento: {medico.FechaNacimiento}, Número de Licencia: {medico.NumeroLiciencia}, Especialidad: {medico.Especialidad}");
            }
        }
            static void MostrarPacientes(List<paciente> pacientes)
            {
                foreach (var paciente in pacientes)
                {
                    Console.WriteLine($"ID: {paciente.NumeroIdentificacion}, Nombre: {paciente.Nombre}, Apellidos: {paciente.Apellidos}, Teléfono: {paciente.Telefono}, Fecha Nacimiento: {paciente.FechaNacimiento}, Dirección: {paciente.Direccion}, Nombre Familiar: {paciente.NombreFamiliar}, Teléfono Familiar: {paciente.TelefonoFamiliar}");
                }
            }

            Console.WriteLine();
        }

    }
}
