using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_2_Clinica
{
    class Medico
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int matricula;
        private Turno turnos;
        private Turno[] turnosDias;
        private ArrayList listaPacientes;
        

        public Medico(string xNom, string xApell, int xDni, int xMatricula)
        {
            nombre = xNom;
            apellido = xApell;
            dni = xDni;
            matricula = xMatricula;
            turnosDias = new Turno[9];
            listaPacientes = new ArrayList();

            for (int i = 0; i < 9; i++)
            { //Se inicializa Turno
                Turno turnosInciales = new Turno(" ", 0);
                turnosDias[i] = turnosInciales;
            }
            (turnosDias[0]).Hora = "08:00";
            (turnosDias[1]).Hora = "08:30";
            (turnosDias[2]).Hora = "09:00";
            (turnosDias[3]).Hora = "09:30";
            (turnosDias[4]).Hora = "10:00";
            (turnosDias[5]).Hora = "10:30";
            (turnosDias[6]).Hora = "11:00";
            (turnosDias[7]).Hora = "11:30";
            (turnosDias[8]).Hora = "12:00";

        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Apellido 
        {
            set { apellido = value; }
            get { return apellido; }  
        }
        public int Dni
        {
            set { dni = value; }
            get { return dni; }
        }
        public int Matricula
        {
            set { matricula = value; }
            get { return matricula; }
        }
        public ArrayList ListaPac
        {
            set { listaPacientes = value; }
            get { return listaPacientes; }
        }
        public Turno[] Turno
        {
            set { turnosDias = value; }
            get { return turnosDias; }
        }


        public void darTurno(string nom_apePac, int dni, string unaHora)
        {
            bool ocupado = false;
            turnos = new Turno(nom_apePac, dni, unaHora);

            foreach  (Turno elemento in turnosDias)
            {
                if (elemento.Dni == dni)
                {
                    ocupado = true;
                    Console.WriteLine("\nLa persona ya cuenta con un turno.");
                    break;
                }
                if (elemento.Hora == unaHora && elemento.Dni != 0)
                {
                    Console.WriteLine("\nEl horario esta ocupado\n");
                    ocupado = true;
                    break;
                }
                
            }

            if (!ocupado)
            {
                switch (unaHora)
                {
                    case "08:00":
                        turnosDias[0] = turnos;
                        Console.WriteLine("\nEl turno ha sido registrado correctamente.\n");
                        break;

                    case "08:30":
                        turnosDias[1] = turnos;
                        Console.WriteLine("\nEl turno ha sido registrado correctamente.\n");
                        break;

                    case "09:00":
                        turnosDias[2] = turnos;
                        Console.WriteLine("\nEl turno ha sido registrado correctamente.\n");
                        break;

                    case "09:30":
                        turnosDias[3] = turnos;
                        Console.WriteLine("\nEl turno ha sido registrado correctamente.\n");
                        break;

                    case "10:00":
                        turnosDias[4] = turnos;
                        Console.WriteLine("\nEl turno ha sido registrado correctamente.\n");
                        break;

                    case "10:30":
                        turnosDias[5] = turnos;
                        Console.WriteLine("\nEl turno ha sido registrado correctamente.\n");
                        break;

                    case "11:00":
                        turnosDias[6] = turnos;
                        Console.WriteLine("\nEl turno ha sido registrado correctamente.\n");
                        break;

                    case "11:30":
                        turnosDias[7] = turnos;
                        Console.WriteLine("\nEl turno ha sido registrado correctamente.\n");
                        break;

                    case "12:00":
                        turnosDias[8] = turnos;
                        Console.WriteLine("\nEl turno ha sido registrado correctamente.\n");
                        break;

                    default:
                        Console.WriteLine("\nHORAIO FUERA DE RANGO O FORMATO INCORRECTO!!!\n\n" +
                            "Verifique cual es el error.\n");
                        break;
                }

            }

        }

        public void actDiagPac(int xDni, string diag)
        {
            bool existe = false;

            foreach (Paciente elemento in listaPacientes)
            {
                if (elemento.Dni == xDni)
                {
                    existe = true;

                    if (elemento.Diagnostico != diag)
                    {
                        elemento.Diagnostico = diag;
                        Console.WriteLine("El diagnóstico fue actualizado con éxito.");
                        
                    }

                    else
                    {
                        Console.WriteLine("El diagnóstico ingresado coicide con el ya antes registrado.");
                    }

                    break;
                }

            }

            if(!existe)
            {
                Console.WriteLine("El paciente no existe en la base de datos.");
            }

        }

        public void cancelarTurno(int xDni)
        {
            bool existe = false;

            foreach (Turno elemento in turnosDias)
            {

                if (elemento.Dni == xDni)
                {
                    existe = true;
                    elemento.NombrePac = " ";
                    elemento.Dni = 0;
                    break;

                }

            }

            if (existe)
            {
                Console.WriteLine("El turno ha sido cancelado con éxito.");
            }
            else
            {
                Console.WriteLine("La persona con el DNI ingresado no cuenta con un turno.");
            }


        }

        public Turno[] listaDeTurnos()
        {
            return turnosDias;
        }

        public void agregarPac(Paciente unPac)
        {
            bool existe = false;

            foreach (Paciente elemento in listaPacientes)
            {
                if (elemento.Dni == unPac.Dni || elemento.NroAfiliado == unPac.NroAfiliado)
                {
                    existe = true;
                    break;
                }
            }

            if (existe)
            {
                Console.WriteLine("\nEl DNI o Nro. de afiliado del paciente ingresado ya existe!\n" +
                                  "\n" +
                                  "Verífique la información ingresada. ");
            }
            else
            {
                listaPacientes.Add(unPac);
                Console.WriteLine("\nEl paciente fue regristrado correctamente en la base de datos.");
            }
            
        }

        public void eliminarPac(int dni)
        {
            int contPac = 0;

            foreach (Paciente item in listaPacientes)
            {
                if (item.Dni == dni)
                {
                    contPac++;
                }
            }
            
            if (contPac != 0)
            {
                listaPacientes.RemoveAt(contPac - 1);
                Console.WriteLine("\nEl paciente ha sido eliminado con éxito.");
            }

            else
            {
                Console.WriteLine("\nEl paciente ingresado no se encuentra en la base de datos.");
            }

        }

        public ArrayList todosPac()
        { 
            return listaPacientes;
        }


    }


}
