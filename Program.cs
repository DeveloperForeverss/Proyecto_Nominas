namespace ejercicio_1
{
    using System;
    using System.Collections.Generic;

    namespace SistemaNomina
    {
        class Program
        {
            static List<empleado> empleados = new List<empleado>();

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("----- Menú Principal -----");
                    Console.WriteLine("1. Agregar Empleado");
                    Console.WriteLine("2. Ver Empleados");
                    Console.WriteLine("3. Eliminar Empleado");
                    Console.WriteLine("4. Ver Nómina Completa");
                    Console.WriteLine("5. Reporte: Empleados Mujeres");
                    Console.WriteLine("6. Reporte: Empleados con Licencia");
                    Console.WriteLine("7. Reporte: Empleados con Sueldo > 50,000");
                    Console.WriteLine("8. Salir");
                    Console.Write("Seleccione una opción: ");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Agregarempleado();
                            break;
                        case 2:
                            Mostrarempleados();
                            break;
                        case 3:
                            Eliminarempleado();
                            break;
                        case 4:
                            MostrarNominas_Sueldo();
                            break;
                        case 5:
                            MostrarMujerempleados();
                            break;
                        case 6:
                            MostrarLicenciadempleados();
                            break;
                        case 7:
                            MostrarAltoSalarioempleados();
                            break;
                        case 8:
                            Console.WriteLine("Saliendo del sistema...");
                            return;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                            break;
                    }
                }
            }

            static void Agregarempleado()
            {
                Console.WriteLine("----- Agregar Empleado -----");
                empleado empleado = new empleado();

                Console.Write("Nombre: ");
                empleado.PrimerNombre = Console.ReadLine();

                Console.Write("Apellido: ");
                empleado.Apellido = Console.ReadLine();

                Console.Write("Edad: ");
                empleado.Edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sexo (M/F): ");
                empleado.Genero = Convert.ToChar(Console.ReadLine());

                Console.Write("Fecha de Nacimiento (YYYY-MM-DD): ");
                empleado.Fecha_Nacimiento = DateTime.Parse(Console.ReadLine());

                Console.Write("¿Posee Licencia? (true/false): ");
                empleado.TLicencia = Convert.ToBoolean(Console.ReadLine());

                Console.Write("Sueldo Bruto: ");
                empleado.SalarioBruto = Convert.ToDecimal(Console.ReadLine());

                // Calcula los valores de la nómina (TSS, Impuesto sobre la renta, Sueldo Neto) aquí

                empleados.Add(empleado);
                Console.WriteLine("Empleado agregado correctamente.");
            }

            static void Mostrarempleados()
            {
                Console.WriteLine("----- Ver Empleados -----");
                foreach (var empleado in empleados)
                {
                    Console.WriteLine($"Nombre: {empleado.PrimerNombre} {empleado.Apellido}");
                    Console.WriteLine($"Edad: {empleado.Edad}");
                    Console.WriteLine($"Sexo: {empleado.Genero}");
                    Console.WriteLine($"Fecha de Nacimiento: {empleado.Fecha_Nacimiento.ToShortDateString()}");
                    Console.WriteLine($"Posee Licencia: {(empleado.TLicencia ? "Sí" : "No")}");
                    Console.WriteLine($"Sueldo Bruto: {empleado.SalarioBruto}");
                    Console.WriteLine(); // Espacio entre empleados
                }
            }

            static void Eliminarempleado()
            {
                Console.WriteLine("----- Eliminar Empleado -----");
                Console.Write("Ingrese el índice del empleado que desea eliminar: ");
                int index = Convert.ToInt32(Console.ReadLine());

                if (index >= 0 && index < empleados.Count)
                {
                    empleados.RemoveAt(index);
                    Console.WriteLine("Empleado eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("Índice inválido. No se eliminó ningún empleado.");
                }
            }

            static void MostrarNominas_Sueldo()
            {
                Console.WriteLine("----- Nómina Completa -----");
                foreach (var empleado in empleados)
                {
                    // Muestra los detalles de la nómina de cada empleado aquí
                }
            }

            static void MostrarMujerempleados()
            {
                Console.WriteLine("----- Empleados Mujeres -----");
                foreach (var empleado in empleados)
                {
                    if (empleado.Genero == 'F')
                    {
                        Console.WriteLine($"Nombre: {empleado.PrimerNombre} {empleado.Apellido}");
                        Console.WriteLine($"Edad: {empleado.Edad}");
                        Console.WriteLine(); // Espacio entre empleados
                    }
                }
            }

            static void MostrarLicenciadempleados()
            {
                Console.WriteLine("----- Empleados con Licencia -----");
                foreach (var empleado in empleados)
                {
                    if (empleado.TLicencia)
                    {
                        Console.WriteLine($"Nombre: {empleado.PrimerNombre} {empleado.Apellido}");
                        Console.WriteLine($"Edad: {empleado.Edad}");
                        Console.WriteLine(); // Espacio entre empleados
                    }
                }
            }

            static void MostrarAltoSalarioempleados()
            {
                Console.WriteLine("----- Empleados con Sueldo > 50,000 -----");
                foreach (var empleado in empleados)
                {
                    if (empleado.SalarioBruto > 50000)
                    {
                        Console.WriteLine($"Nombre: {empleado.PrimerNombre} {empleado.Apellido}");
                        Console.WriteLine($"Edad: {empleado.Edad}");
                        Console.WriteLine($"Sueldo Bruto: {empleado.SalarioBruto}");
                        Console.WriteLine(); // Espacio entre empleados
                    }
                }
            }
        }

        class empleado
        {
            public string PrimerNombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }
            public char Genero { get; set; }
            public DateTime Fecha_Nacimiento { get; set; }
            public bool TLicencia { get; set; }
            public decimal SalarioBruto { get; set; }
            public decimal SalarioNeto { get; set; }
            public decimal TSS { get; set; }
            public decimal Impuesto_Sobre_R { get; set; }
        }
    }


}