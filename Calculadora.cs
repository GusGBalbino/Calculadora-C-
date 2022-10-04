namespace Calculadora
{
    class Operations
    {
        static void Main(string[] args)
        {

            double num1, num2;
            string value;

            Console.WriteLine("Digite um número: ");
            value = Console.ReadLine();
            num1 = int.Parse(value);

            Console.WriteLine("Digite mais um número: ");
            value = Console.ReadLine();
            num2 = int.Parse(value);

            double resultado;

            //realiza a soma e imprime no console
            resultado = num1 + num2;
            Console.WriteLine("============ SOMA ============");
            Console.WriteLine($"{num1} SOMADO com {num2} é: " + resultado);

            //realiza a subtração e imprime no console
            resultado = num1 - num2;
            Console.WriteLine("============ SUBTRAÇÃO ============");
            Console.WriteLine($"{num1} SUBTRAIDO por {num2} é: " + resultado);

            //realiza a multiplicação e imprime no console
            resultado = num1 * num2;
            Console.WriteLine("============ MULTIPLICAÇÃO ============");
            Console.WriteLine($"{num1} MULTIPLICADO por {num2} é: " + resultado);

            //realiza a divisão e imprime no console
            resultado = num1 / num2;
            Console.WriteLine("============ DIVISÃO ============");
            Console.WriteLine($"{num1} DIVIDIDO por {num2} é: " + resultado);
            //Console.WriteLine("Divisão: " + resultado);
        }
    }
}