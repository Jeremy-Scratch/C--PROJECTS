using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

//CREAMOS UNA CLASE PARA OPTENER LOS DATOS DEL USUARIO 
public class GetInput
{
    //Metodo para obtener los valores a calcular y depurar una entrada invalida de datos
    public double GetNumber(string mensaje)
    {
        double numero;
        Console.WriteLine(mensaje);

        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada invalida, ");
            Console.WriteLine(mensaje);
        }
        return numero;

    }

     //Metodo para obtener LA OPERACION A REALIZAR y depurar una entrada invalida de datos
    public char GetOpe()
    {
        Console.WriteLine("Ingrese que operacion quiere realizar ( +, -, *, / )");
        char opcion;

        while (!char.TryParse(Console.ReadLine(), out opcion) || (opcion != '+' && opcion != '-' && opcion != '*' && opcion != '/'))
        {
            Console.WriteLine("Entrada invalida, Porfavor ingresa un operador valido.");
            Console.WriteLine("( +, -, *, / )");
        }
        return opcion;


    }

}

