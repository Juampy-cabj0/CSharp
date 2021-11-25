using System;
using System.Collections;

namespace Parcial_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aeropuerto aeropuerto1 = new Aeropuerto("Ministro Pistarini","Ezeiza");

            Console.WriteLine("--- AEROPUERTO MINISTRO PISTARINI ---");
            Console.WriteLine("");
            Console.WriteLine("--- CARGA DE VUELOS ---");
            Console.WriteLine("");
            Console.WriteLine("Ingrese los siguientes datos separados por TAB: ");
            Console.WriteLine("CODIGO_DE_VUELO <TAB> FECHA_SALIDA <TAB> HORA_SALIDA <TAB> ORIGEN <TAB> DESTINO <TAB> DURACION <ENTER>");
            string datosVuelo = Console.ReadLine();

            while (datosVuelo != "")
            {
                string[] vecDatosVuelo = datosVuelo.Split(new char[]{(char)9});
                string codigo = vecDatosVuelo[0];
                string fechaS = vecDatosVuelo[1];
                int horaS = int.Parse(vecDatosVuelo[2]);
                string origen = vecDatosVuelo[3];
                string destino = vecDatosVuelo[4];
                int duracion = int.Parse(vecDatosVuelo[5]);

                Vuelo v1 = new Vuelo(codigo,fechaS,horaS,origen,destino,duracion);
                aeropuerto1.agregarVuelo(v1);
                
                for (int i = 0; i < 10; i++)
                {
                    int numasiento = 100 + i;
                    string estado = "disponible";
                    int dniPasajero = 0;
                    string apellidoPasajero = "";

                    Asiento a1 = new Asiento(numasiento,estado,dniPasajero,apellidoPasajero);
                    v1.agregarAsiento(a1);
                }
                Console.WriteLine("--- VUELO AGREGADO ---");
                Console.WriteLine("");
                Console.WriteLine("Para agregar otro Vuelo ingrese los datos separados por TAB: ");
                Console.WriteLine("CODIGO_DE_VUELO <TAB> FECHA_SALIDA <TAB> HORA_SALIDA <TAB> ORIGEN <TAB> DESTINO <TAB> DURACION <ENTER>, o presione ENTER para finalizar.");
                datosVuelo = Console.ReadLine();
            }

            int vuelosNuevaYork = 0;

            Console.WriteLine("--- VENTA DE PASAJES ---");
            Console.WriteLine("");
            Console.WriteLine("Ingrese Codigo de Vuelo, o 'ENTER' para finalizar:");
            string codV = Console.ReadLine();
            while (codV != "")
            {
                Console.WriteLine("Ingrese Numero de Asiento (ejemplo, 101): ");
                string numA = Console.ReadLine();
                
                string codValor = aeropuerto1.checkVuelo(codV);
                string asientoValor = aeropuerto1.checkAsiento(codV, numA);
                try
                {
                    if (codValor == "")
                    {
                        throw new VueloNoExiste();
                    }
                    if (asientoValor != "disponible")
                    {
                        throw new AsientoNoDisponible();
                    }
                }
                catch (VueloNoExiste)
                {
                    Console.WriteLine("El Vuelo ingresado NO existe, intente nuevamente.");
                }
                catch (AsientoNoDisponible)
                {
                    Console.WriteLine("Lo sentimos, el Asiento solicitado se encuentra Ocupado, intente con otro.");
                }

                string destinoPasaje = aeropuerto1.checkDestino(codV);
                if (destinoPasaje == "nueva york" && asientoValor == "disponible")
                {
                    vuelosNuevaYork++;
                }
                    
                if (codValor != "" && asientoValor == "disponible")
                {
                    aeropuerto1.venderPasaje(codV, numA);
                }

                Console.WriteLine("");
                Console.WriteLine("Ingrese Codigo de Vuelo, o 'ENTER' para finalizar:");
                codV = Console.ReadLine();
            }
            
            // Para correr la siguientes funciones (mostrarApellidos y la recursiva mostrarVuelos10Horas) tuve que modificar 
            //el constructor del ArrayList listaVuelos y volverlo public, como puedo hacer para que funcione siendo private ??

            Console.WriteLine("--- RESULTADOS ---");
            Console.WriteLine("");
            aeropuerto1.mostrarApellidos(aeropuerto1.ListaVuelos);
            Console.WriteLine("");

            Console.WriteLine("La cantidad de Pasajes vendidos a Nueva York es: "+vuelosNuevaYork);
            Console.WriteLine("");
            
            mostrarVuelos10Horas(aeropuerto1.ListaVuelos, 0);
        }

        ///////// FUNCION RECURSIVA //////////
        public static void mostrarVuelos10Horas(ArrayList listaVuelos, int pos){
            if (pos < listaVuelos.Count)
            {
                if (((Vuelo)listaVuelos[pos]).Duracion < 10)
                {
                    Console.WriteLine("El Vuelo {0} tiene una Duracion de {1} horas (menor a 10hs).", ((Vuelo)listaVuelos[pos]).CodigoId, ((Vuelo)listaVuelos[pos]).Duracion);
                }
                mostrarVuelos10Horas(listaVuelos, pos+1);
            }
        }

        ///////// FIN DE LA FUNCION RECURSIVA //////////
    }

    ////////// FIN DEL MAIN /////////////

    ////////// EXCEPCIONES //////////////

    public class VueloNoExiste : Exception {}
    public class AsientoNoDisponible : Exception {}

    ////////// FIN DE EXCEPCIONES //////////////

    ////////// CLASS AEROPUERTO ////////////
    public class Aeropuerto
    {
        private string nombre;
        private string ubicacion;
        private ArrayList listaVuelos; 

        public Aeropuerto(string nombre, string ubicacion){
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            listaVuelos = new ArrayList();
        }

        public string Nombre{
            set{
                nombre = value;
            }
            get{
                return nombre;
            }
        }

        public string Ubicacion{
            set{
                ubicacion = value;
            }
            get{
                return ubicacion;
            }
        }

        public ArrayList ListaVuelos
        {
            set { listaVuelos = value; }
            get { return listaVuelos; }
        }

        public void agregarVuelo(Vuelo objVuelo){
            listaVuelos.Add(objVuelo);
        }

        public string checkVuelo(string codV){
            foreach (Vuelo elemVuelo in listaVuelos)
            {
                if (codV == elemVuelo.CodigoId)
                {
                   return elemVuelo.CodigoId;
                }
            }
            return "";
        }

        public string checkAsiento(string codV, string numA){
            foreach (Vuelo elemVuelo in listaVuelos)
            {
                if (codV == elemVuelo.CodigoId)
                {
                    string resultado = elemVuelo.checkEstadoAsiento(int.Parse(numA));
                    return resultado;
                }
            }
            return "";
        }

        public string checkDestino(string codV){
            foreach (Vuelo elemVuelo in listaVuelos)
            {
                if (codV == elemVuelo.CodigoId)
                {
                    string destino = elemVuelo.Destino;
                    return destino;
                }
            }
            return "";
        }

        public void venderPasaje(string codV, string numA){
            foreach (Vuelo elemVuelo in listaVuelos)
            {
                if (codV == elemVuelo.CodigoId)
                {
                    elemVuelo.reservarAsiento(int.Parse(numA));
                    Console.WriteLine("--- PASAJE VENDIDO ---");
                }
            }
        }

        public void mostrarApellidos(ArrayList listaVuelos){
            foreach (Vuelo elemVuelo in listaVuelos)
            {
                elemVuelo.mostrarApellidosVuelo();
            }
        }
    }

    //////// FIN DE CLASS AEROPUERTO /////////

    //////// CLASS VUELO ////////////
    public class Vuelo
    {
        private string codigoId;
        private string fechaSalida;
        private int horaSalida;
        private string origen;
        private string destino;
        private int duracion;
        private ArrayList listaAsientos;

        public Vuelo(string codigoId, string fechaSalida, int horaSalida, string origen, string destino, int duracion){
            this.codigoId = codigoId;
            this.fechaSalida = fechaSalida;
            this.horaSalida = horaSalida;
            this.origen = origen;
            this.destino = destino;
            this.duracion = duracion;
            this.listaAsientos = new ArrayList();
        }

        public string CodigoId{
            set{
                codigoId = value;
            }
            get{
                return codigoId;
            }
        }

        public string FechaSalida{
            set{
                fechaSalida = value;
            }
            get{
                return fechaSalida;
            }
        }

        public int HoraSalida{
            set{
                horaSalida = value;
            }
            get{
                return horaSalida;
            }
        }

        public string Origen{
            set{
                origen = value;
            }
            get{
                return origen;
            }
        }

        public string Destino{
            set{
                destino = value;
            }
            get{
                return destino;
            }
        }

        public int Duracion{
            set{
                duracion = value;
            }
            get{
                return duracion;
            }
        }

        public void agregarAsiento(Asiento objAsiento){
            listaAsientos.Add(objAsiento);
        }

        public string checkEstadoAsiento(int numA){
            foreach (Asiento elemAsiento in listaAsientos)
            {
                if (numA == elemAsiento.Numero && elemAsiento.Estado == "disponible")
                {
                    return elemAsiento.Estado;
                }
            }
            return "";
        }

        public void reservarAsiento(int numA){
            foreach (Asiento elemAsiento in listaAsientos)
            {
                if (numA == elemAsiento.Numero)
                {
                    Console.WriteLine("Ingrese su DNI:");
                    int dni = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese su Apellido:");
                    string ape = Console.ReadLine();
                    elemAsiento.Estado = "ocupado";
                    elemAsiento.DniPasajero = dni;
                    elemAsiento.ApellidoPasajero = ape;
                }
            }
        }

        public void mostrarApellidosVuelo(){
            ArrayList apellidos = new ArrayList();
            for (int i = 0; i < listaAsientos.Count; i++)
            {
                if (((Asiento)listaAsientos[i]).ApellidoPasajero != "")
                {
                    apellidos.Add(((Asiento)listaAsientos[i]).ApellidoPasajero);
                    apellidos.Sort(); // ordena alfabeticamente
                }
            }
            
            foreach (string ape in apellidos)
            {
                Console.WriteLine("Pasajero: "+ape);
            }
        }
    }

    ////////// FIN DE CLASS VUELO ////////////////

    ////////// CLASS ASIENTO //////////////
    public class Asiento
    {
        private int numero;
        private string estado;
        private int dniPasajero;
        private string apellidoPasajero;

        public Asiento(int numero, string estado, int dniPasajero, string apellidoPasajero){
            this.numero = numero;
            this.estado = estado;
            this.dniPasajero = dniPasajero;
            this.apellidoPasajero = apellidoPasajero;
        }

        public int Numero{
            set{
                numero = value;
            }
            get{
                return numero;
            }
        }

        public string Estado{
            set{
                estado = value;
            }
            get{
                return estado;
            }
        }

        public int DniPasajero{
            set{
                dniPasajero = value;
            }
            get{
                return dniPasajero;
            }
        }

        public string ApellidoPasajero{
            set{
                apellidoPasajero = value;
            }
            get{
                return apellidoPasajero;
            }
        }
    }

    //////// FIN DE CLASS ASIENTO //////////
}