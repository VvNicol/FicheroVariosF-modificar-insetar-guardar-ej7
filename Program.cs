using FicheroVariosF_modificar_insetar_guardar_ej7.Servicio;

namespace FicheroVariosF_modificar_insetar_guardar_ej7
{
    internal class Program
    {
        static string textofichero = "miTexto.txt";
        

        static void Main(string[] args)
        {
            MenuInterface mi = new MenuImplementacion();
            
            bool esCerrado = false;
            int opcionElegida;

            

            try
            {
                do
                {
                    opcionElegida = mi.MenuPrincipal();
                    switch (opcionElegida)
                    {
                        case 0:
                            esCerrado = true;
                            break;
                        case 1:
                            mi.MenuTextoFichero();
                            break;
                        case 2:
                            mi.MenuArchivoFichero();
                            break;                      
                        default: Console.WriteLine("La opcion no existe");
                            break;
                    }

                } while (!esCerrado);

            }
            catch (IOException io)
            {
                Console.WriteLine("Error al leer o escribir : " + io.Message);
            }
        }
    }
}
