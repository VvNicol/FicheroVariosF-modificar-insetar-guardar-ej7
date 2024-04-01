namespace FicheroVariosF_modificar_insetar_guardar_ej7.Servicio
{
    
    internal class MenuImplementacion : MenuInterface
    {   
        static string archivo = "miArchivo.txt";
        public int MenuArchivoFichero()
        {
            Console.WriteLine("MI ARCHIVO");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Insertar linea");
            Console.WriteLine("2.Modificar linea");
            Console.WriteLine("3.Leer archivo");

            int opcionArchivo = Convert.ToInt32(Console.ReadLine());
            return opcionArchivo;
        }

        public void ArchivoFichero()
        {
            ArchivoFicheroInterface aa = new ArchivoFicheroImplementacion();

            bool esCerrado = false;
            int opcionElegida;

            using (StreamWriter sw = new StreamWriter(archivo))
            {
                sw.WriteLine("Texto 0        ");
                sw.WriteLine("Texto 1        ");
                sw.WriteLine("Texto 2        ");
                sw.WriteLine("Texto 3        ");
                sw.WriteLine("Texto 4        ");
                sw.WriteLine("Texto 5        ");
                sw.WriteLine("Texto 6        ");
                sw.WriteLine("Texto 7        ");
                sw.WriteLine("Texto 8        ");
                sw.WriteLine("Texto 9        ");
            }

            do
            {
                opcionElegida = MenuArchivoFichero();
                switch (opcionElegida)
                {
                    case 0:
                        esCerrado = true;
                        break;
                    case 1:
                        aa.insertarLinea();
                        break;
                    case 2:
                        aa.modificarLinea();
                        break;
                    case 3:
                        aa.leerFichero();
                        break;
             
                    default:
                        Console.WriteLine("La opcion no existe");
                        break;
                }

            } while (!esCerrado);
        }

        public int MenuPrincipal()
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Fichero -miTexto");
            Console.WriteLine("2.Fichero -miArchivo");

            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion; 
        }

        public int MenuTextoFichero()
        {
            Console.WriteLine("MI TEXTO");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Insertar linea");
            Console.WriteLine("2.Modificar linea");
            Console.WriteLine("3.Leer archivo");

            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        public void TextoFichero()
        {
            TextoFicheroInterface ti = new TextoFicheroImplementacion();

            bool esCerrado = false;
            int opcionElegida;

            do
            {
                opcionElegida = MenuTextoFichero();
                switch (opcionElegida)
                {
                    case 0:
                        esCerrado = true;
                        break;
                    case 1:
                        ti.insertarLinea();
                        break;
                    case 2:
                        ti.modificarLinea();
                        break;

                    default:
                        Console.WriteLine("La opcion no existe");
                        break;
                }

            } while (!esCerrado);
        }
    }
}