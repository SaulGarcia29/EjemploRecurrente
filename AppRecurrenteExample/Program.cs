public class Factorial
{
    // Este método calcula el factorial de un número utilizando recursividad.
    public static int CalcularFactorial(int numero)
    {
        // Si el número es igual a 0, el factorial es 1.
        if (numero == 0)
        {
            return 1;
        }
        // Si el número no es igual a 0, el factorial es el producto del número por el factorial del número menos 1.
        // Este mismo se repite una y otra vez hasta que este valor sea igual a 0
        else
        {
            return numero * CalcularFactorial(numero - 1);
        }
    }


    public static void Main(string[] args)
    {
        // Declaracion de variable.
        int numero;

        // Se introduce un número.
        Console.WriteLine("Digite un número: ");
        numero = int.Parse(Console.ReadLine());

        // Se calcula el factorial del número introducido.
        int factorial = CalcularFactorial(numero);

        // Se muestra el resultado.
        Console.WriteLine("El factorial de {0} es {1}", numero, factorial);
    }
}
