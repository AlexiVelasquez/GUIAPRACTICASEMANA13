using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GUIAPRACTICASEMANA13
{
    public class interfazmenu
    {
        public static int[] datos = new int[50];
        public static int contador = 0;
        

        static void Main(string[] args)
        {

            int opcion = interfazmenu.listaencuesta();

            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion=interfazmenu.listaencuesta();
                        break;
                    case 1:
                        Console.Clear();
                        opcion = interfazmenu.realizarencuesta();
                        break;
                    case 2:
                        Console.Clear();
                        opcion = interfazmenu.verdatos();
                        break;
                    case 3:
                        Console.Clear();
                        opcion=interfazmenu.eliminardatos();
                        break; 
                    case 4:
                        Console.Clear();
                        opcion = interfazmenu.ordernar();

                        break;
               
                }
            }
            while (opcion != 5);
        }


        public static int listaencuesta()
        {
            Console.Clear ();
            string texto = "================================\n" +
                    "Encuestas de Calidad\n" +
                "================================\n" +
                "1: Realizar Encuesta\n" +
                "2: Ver datos registrados\n" +
                "3: Eliminar un dato\n" +
                "4: Ordenar datos de menor a mayor\n" +
                "5: Salir\n" +
                "================================\n";
            Console.Write(texto);
            return operaciones.getEntero("Ingrese una opcion:", texto);


        }
        public static int realizarencuesta()
        {

            string texto = "===================================\n" +
            "Nivel de Satisfacción\n" +
            "===================================\n" +
            "¿Qué tan satisfecho está con la\n" +
            "atención de nuestra tienda?\n" +
            "1: Nada satisfecho\n" +
            "2: No muy satisfecho\n" +
            "3: Tolerable\n" +
            "4: Satisfecho\n" +
            "5: Muy satisfecho\n" +
            "===================================\n";
            Console.Write(texto);
            int ptosatisfaccion=operaciones.getEntero("Ingrese una opcion:", texto);
            datos[contador]= ptosatisfaccion;
            contador++;
            if (ptosatisfaccion <= 5)
            {
                Console.Clear();
                string texto2 = "===================================\n" +
                "Nivel de Satisfacción\n" +
                "===================================\n" +
                "¡Gracias por participar!\n " +
                "===================================\n" +
                "Presione un numero para\n";
                Console.Write(texto2);
                int opcion = operaciones.getEntero("regresar al menu....", texto);
                return 0;
            }

            return getOpcion();
        }
       public static int verdatos()
        {
            string texto = "===================================\r\n" +
                "Ver datos registrados\r\n" +
                "===================================\r\n";
            Console.Write(texto);
            for (int i = 0; i <contador; i++)
            {

                Console.Write("["+datos[i]+ "] ");
             
            }
            string texto2 = "\n===================================\n";
            Console.Write(texto2);
            int opcion = operaciones.getEntero("Presione un numero para regresar....", texto);
            return 0;



       }
        public static int eliminardatos()
        {
            string texto = "===================================\r\n" +
                "Eliminar un dato\r\n" +
                "===================================\r\n";
            Console.Write(texto);
            for (int i = 0; i <contador; i++)
            {

                Console.Write("["+datos[i]+ "] ");
             
            }
            string texto2 = "\n===================================\n";
            Console.Write(texto2);
            int posicion = operaciones.getEntero("Ingrese la posicion a eliminar: ", texto);

            string texto3 = "\n===================================\n";
            Console.Write(texto3);
            int[] nuevoArreglo = new int[datos.Length - 1];

            for (int i = 0; i < datos.Length - 1; i++)
            {

                if (posicion > i)
                {
                    nuevoArreglo[i] = datos[i];
                }
                else
                {
                    nuevoArreglo[i] = datos[i + 1];
                }
            }

            datos= nuevoArreglo;

            
            for (int i = 0; i < contador; i++)
            {
                Console.Write("[" + datos[i] + "] ");

            }
            string texto4 = "\n===================================\n";
            Console.Write(texto4);
            int opcion = operaciones.getEntero("\nPresione un numero para regresar....", texto);

            return 0;
            
         
        }
        public static  int ordernar()
        {
            int arregloOrdenar;
            string texto = "===================================\r\n" +
                "Ordenar datos\r\n" +
                "===================================\r\n";
            Console.Write(texto);
            for (int i = 0; i < contador; i++)
            {

                Console.Write("[" + datos[i] + "] ");

            }
            string texto2 = "\n===================================\n";
            Console.Write(texto2);
            int posicion = operaciones.getEntero("Ingrese la posicion a eliminar: ", texto);

            string texto3 = "\n===================================\n";
            Console.Write(texto3);
            int[] nuevoArreglo = new int[datos.Length - 1];

            for (int i = 0; i < datos.Length - 1; i++)
            {

                if (posicion > i)
                {
                    nuevoArreglo[i] = datos[i];
                }
                else
                {
                    nuevoArreglo[i] = datos[i + 1];
                }
            }
            datos = nuevoArreglo;

            /*for (int i = 0; i < contador; i++)
            {
                for (int j = 0; j < arregloOrdenar.Length - 1; j++)
                {
                    if (arregloOrdenar[j] > arregloOrdenar[j + 1])
                    {
                        int aux = arregloOrdenar[j + 1];
                        arregloOrdenar[j + 1] = arregloOrdenar[j];
                        arregloOrdenar[j] = aux;
                    }
                }
            }*/
            for (int i = 0; i < contador; i++)
            {
                Console.Write("[" + datos[i] + "] ");

            }
            string texto4 = "\n===================================\n";
            Console.Write(texto4);
            int opcion = operaciones.getEntero("\nPresione un numero para regresar....", texto);

            return 0;
           

        }
        public static int getOpcion()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }
    }
     
}
