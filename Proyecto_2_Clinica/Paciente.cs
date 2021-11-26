using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_2_Clinica
{
    class Paciente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string obraSocial;
        private int nroAfiliado;
        private string diagnostico;

        public Paciente()
        {

        }

        public Paciente(string nom, string apell, int xDni, string xObraSocial, int xNroAfiliado, string xDiagnostico)
        {
            nombre = nom;
            apellido = apell;
            dni = xDni;
            obraSocial = xObraSocial;
            nroAfiliado = xNroAfiliado;
            diagnostico = xDiagnostico;
            
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
        public string ObraSocial
        {
            set { obraSocial = value; }
            get { return obraSocial; }
        }
        public int NroAfiliado
        {
            set { nroAfiliado = value; }
            get { return nroAfiliado; }
        }
        public string Diagnostico
        {
            set { diagnostico = value; }
            get { return diagnostico; }
        }

    }
}
