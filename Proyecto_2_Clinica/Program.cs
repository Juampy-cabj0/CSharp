using System;
using System.Collections;

namespace Proyecto_2_Clinica
{
    class Program
    {
        static void Main(string[] args)
        {
            Medico m1 = new Medico("Juan Pablo", "Mansilla", 34692667, 34667);

            Paciente pac;

            string nomYape, hora, diag;
            string nomPac, apePac, obraSocPac, diagnostico;
            string resp;
            int dni, nroAfiliado;



            Console.Write("*******************************************************\n" +
                          "*************** Bienvenido Dr. {0} ***************\n" +
                          "*******************************************************\n" +
                          "************** Elija la opción deseada: ***************\n" +
                          "\n", m1.Apellido);

            do
            {
                string op = Menu();

                switch (op)
                {
                    case "1":

                        bool existe = false; 

                        Console.Write("Ingrese su nombre y apellido: ");
                        nomYape = Console.ReadLine();

                        Console.Write("Ingrese su DNI (sin espacios ni puntos): ");
                        dni = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("\nEstos son los horarios disponibles: \n");

                        try
                        {
                            foreach (Turno item in m1.Turno)
                            {
                                if (item.NombrePac == " " && item.Dni == 0)
                                {
                                    Console.WriteLine("- {0} Hs", item.Hora);
                                    existe = true;
                                }
                            }

                            if (existe == false)
                            {
                                throw new NoHayTurnos();
                            }
                            else
                            {
                                Console.Write("\nElija el horario que desea para el turno (formato hh:mm): ");
                                hora = Console.ReadLine();

                                m1.darTurno(nomYape, dni, hora);
                            }
                            
                        }

                        catch (NoHayTurnos)
                        {
                            Console.WriteLine("No hay turnos disponibles!\n" +
                             "\n" +
                             "Vuelva a intentarlo en el día de mañana.\n");
                        }

                        break;

                    case "2":
                        Console.Write("Ingrese el DNI del pacienta al que desea cambiarle su diagnóstico: ");
                        dni = Int32.Parse(Console.ReadLine());

                        Console.Write("Ingrese el nuevo diagnóstico: ");
                        diag = Console.ReadLine();

                        m1.actDiagPac(dni, diag);

                        break;

                    case "3":
                        Console.Write("Ingrese el DNI del paciente que desea cancelar el turno: ");
                        dni = Int32.Parse(Console.ReadLine());

                        m1.cancelarTurno(dni);

                        break;

                    case "4":
                        int contTur = m1.Turno.Length;

                        if (contTur != 0)
                        {
                            Console.WriteLine("Listado de turnos dados:");

                            foreach (Turno item in m1.listaDeTurnos())
                            {

                                if (item.NombrePac != " " && item.Dni != 0)
                                {
                                    Console.WriteLine("\nNombre: {0}\n" +
                                                      "DNI: {1}\n" +
                                                      "Horario: {2}", item.NombrePac, item.Dni, item.Hora);
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Lista de turnos vacía!");
                        }
                        break;

                    case "5":

                        ArrayList listaObraSoc = new ArrayList();

                        foreach (Paciente item in m1.ListaPac)
                            {
                                if (listaObraSoc.IndexOf(item.ObraSocial) == -1)
                                {
                                    listaObraSoc.Add(item.ObraSocial);
                                }
                            }

                        Console.WriteLine("Lista de Obras Sociales de los pacientes:\n");
                        foreach (string item in listaObraSoc)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case "6":
                        Console.Write("Ingrese el nombre: ");
                        nomPac = Console.ReadLine();

                        Console.Write("Ingrese el apellido: ");
                        apePac = Console.ReadLine();

                        Console.Write("Ingrese el DNI: ");
                        dni = Int32.Parse(Console.ReadLine());

                        Console.Write("Ingrese la obra social: ");
                        obraSocPac = Console.ReadLine();

                        Console.Write("Ingrese el Nro de afiliado: ");
                        nroAfiliado = Int32.Parse(Console.ReadLine());

                        Console.Write("Ingrese el diagnóstico: ");
                        diagnostico = Console.ReadLine();

                        pac = new Paciente(nomPac, apePac, dni, obraSocPac, nroAfiliado, diagnostico);
                        m1.agregarPac(pac);

                        break;

                    case "7":
                        Console.Write("Ingrese el DNI del paciente que desea eliminar: ");
                        dni = Int32.Parse(Console.ReadLine());

                        m1.eliminarPac(dni);

                        break;

                    case "8":
                        int contPac = m1.ListaPac.Count;

                        if (contPac != 0)
                        {
                            Console.WriteLine("\nListado de pacientes: \n");

                            foreach (Paciente item in m1.todosPac()) //Muestro los pacientes en la listaPacientes de la clase Médico
                            {
                                Console.WriteLine(" Nombre: {0}\n " +
                                                  " Apellido: {1}\n " +
                                                  " DNI: {2}\n " +
                                                  " Obra Social: {3}\n " +
                                                  " Nro. Afiliado: {4}\n " +
                                                  " Diagnostico: {5}\n", item.Nombre, item.Apellido, item.Dni, item.ObraSocial, item.NroAfiliado, item.Diagnostico);
                            }
                        }

                        else
                        {
                            Console.WriteLine("Lista de pacientes vacía.");
                        }

                        break;

                    case "9":
                        Console.WriteLine("Gracias por utilizar el programa.\n");
                        resp = "n";
                        continue;

                    default:
                        {
                            Console.WriteLine("OPCIÓN INCORRECTA!!!");
                            break;
                        }

                }
                Console.Write("*********************************************************\n" +
                                  "\n" +
                                  "Desea seguir operando? (s/n): ");
                resp = Console.ReadLine();

                if (resp == "n")
                {
                    Console.WriteLine("\n Hasta pronto!");
                }
                else
                {
                    Console.Write("\n*********************************************************\n");
                }
                
                
            }

            while (resp == "s");

            

        }

        public static string Menu()
        {
            Console.Write("1) Agendar un turno\n" +
                          "2) Actualizar el diagnóstico de un paciente\n" +
                          "3) Cancelar un turno dado\n" +
                          "4) Listado de turnos dados\n" +
                          "5) Listado de Obra Social de los pacientes\n" +
                          "6) Agregar paciente\n" +
                          "7) Eliminar paciente\n" +
                          "8) Listado de pacientes\n" +
                          "9) Salir del programa\n" +
                          "\n" +
                          "Igrese la opción numérica deseada: ");
                          
            string opcion = Console.ReadLine();
            Console.WriteLine();
            return opcion;


        }


    }
}
