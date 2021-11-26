using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_2_Clinica
{
    class Turno
    {
        private string nombrePaciente;
        private string hora;
        private int dni;

        public Turno(string nomPac, int xDni, string xHora)
        {
            nombrePaciente = nomPac;
            hora = xHora;
            dni = xDni;
            
        }

        public Turno(string nomPac, int xDni)
        {
            nombrePaciente = nomPac;
            dni = xDni;
        }

        public string NombrePac
        {
            set { nombrePaciente = value; }
            get { return nombrePaciente; }
        }
        public string Hora
        {
            set { hora = value; }
            get { return hora; }
        }
        public int Dni
        {
            set { dni = value; }
            get { return dni; }
        }

    }
}
