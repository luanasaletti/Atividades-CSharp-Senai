//reforco arrays e funcoes

Console.WriteLine("=== Bem-Vindo(a) a Calculadora ===");

Console.Write("Insira o primeiro numero: ");
double num1 = coletarValor();
Console.Write("Insira o segundo numero: ");
double num2 = coletarValor();

Console.Write(@$"

Escolha sua operacao:
______________________
|  1 - Soma           |
|  2 - Subtracao      |
|  3 - Divisao        |
|  4 - Multiplicacao  |
-----------------------
> ");

double operacao = coletarValor();

switch(operacao)
{
    case 1:
        Soma(num1, num2);
        break;
    case 2:
        Subtracao(num1, num2);
        break;
    case 3:
        Divisao(num1, num2);
        break;
    case 4:
        Multiplicacao(num1, num2);  
        break;
}



double coletarValor()
{
    bool numeroValido = false;
    double valorColetado;

    while (!numeroValido)
    {
        try
        {
            valorColetado = Convert.ToDouble
                (Console.ReadLine());
            numeroValido = true;

            return valorColetado;

        }
        catch
        {
            Console.Write("Entrada digitada invalida, digite somente numeros:");
        }

    }

    return 0;
}

void Soma(double num1, double num2)
{
    double soma = num1 + num2;
    Console.WriteLine($"{num1} + {num2} = {soma}");
}

void Subtracao(double num1, double num2)
{
    double subtracao = num1 - num2;
    Console.WriteLine($"{num1} - {num2} = {subtracao}");
}

void Divisao(double num1, double num2)
{
    double divisao = num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {divisao}");
}

void Multiplicacao(double num1, double num2)
{
    double multiplicacao = num1 * num2;
    Console.WriteLine($"{num1} X {num2} = {multiplicacao}");
}
