using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

    class Program
{

    static void Main(string[] aegs)
    {

        while (true)
        {
            //CREAMOS UNA INSTANCIA PARA LLAMAR NUESTROS METODOS DE COLECCION DE DATOS
            GetInput gi = new GetInput();

            //CON ELPRIMER METODO INGRESAMOS EL PARAMETRO "EL MENSAJE" QUE SE MOSTRARA AL USUARIO Y EL RETORNO LO ALMACENAMOS DIRECTAMENTE EN VARIABLES.
            double r1 = gi.GetNumber("Ingrese el primer numero");
            double r2 = gi.GetNumber("Ingrese el segundo numero");
            //EL SEGUNDO METODO PARA ELEGIR QUE OPERACION SE REALIZARA ES LLAMADO Y ALMACENA DIRECTAMENTE EN LA VARIABLE OP.
            char op = gi.GetOpe();

            //VARIABLE QUE ALMACENARA EL RESULTADO DE DICHAS OPERACIONES.    
            double resultado = 0;
            //VARIABLE PARA DAR PASO A SEGUIR CON LA OPERACION SI SE CUMPLEN LAS CONDICIONES
            bool validOperation = true;

            switch (op)
            {
                case '+':
                    resultado = r1 + r2;
                    break;

                case '-':
                    resultado = r1 - r2;
                    break;
                case '*':
                    resultado = r1 * r2;
                    break;
                case '/':
                    if (r2 <= 0)
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                        validOperation = false;
                    }
                    else
                    {
                        resultado = r1 / r2;
                    }
                    break;

                default:

                    Console.WriteLine("");
                    validOperation = false;
                    break;

            }


            if (validOperation)
            {
                Console.WriteLine($"El resultado de {r1} {op} {r2} es: {resultado}");
            }

            Console.WriteLine("Desea Realizar otra operacion?  (si/no) ");

            if (Console.ReadLine()?.ToLower() != "si")
            {
                break;
            }
        }








    }


 }



