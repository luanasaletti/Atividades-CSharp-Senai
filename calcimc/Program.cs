using System.ComponentModel.Design;
// usando if and else
Console.WriteLine("Calculadora de IMC");
Console.WriteLine("Digite seu peso (kg): ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua altura (m): ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc <= 18.5)
{
    Console.WriteLine($"IMC de {imc} classificaçao BAIXO PESO");
}
else if (imc >= 18.6 && imc <= 24.9)
{
    Console.WriteLine($"IMC de {imc} classificaçao PESO NORMAL");
}
else if (imc >= 25 && imc <= 29.9)
{
    Console.WriteLine($"IMC de {imc} classificaçao SOBRE PESO");
}
else if (imc >= 30 && imc <= 34.9)
{
    Console.WriteLine($"IMC de {imc} classificaçao OBESIDADE GRAU I");
}
else if (imc >= 35 && imc <= 39.9)
{
    Console.WriteLine($"IMC de {imc} classificaçao OBESIDADE GRAU II");
}
else
{
    Console.WriteLine($"IMC de {imc} classificação OBESIDADE GRAU III");
}


// usando switch case 

switch (imc)
{
    case <= 18.5:
        Console.WriteLine($"IMC de {imc} classificaçao BAIXO PESO");
        break;

    case >= 18.6 and <= 24.9:
        Console.WriteLine($"IMC de {imc} classificaçao PESO NORMAL");
        break;

    case >= 25 and <= 29.9:
        Console.WriteLine($"IMC de {imc} classificaçao SOBREPESO");
        break;

    case >= 30 and 34.9:
        Console.WriteLine($"IMC de {imc} classificaçao OBESIDADE GRAU I");
        break;

    case >= 35 and <= 39.9:
        Console.WriteLine($"IMC de {imc} classificaçao OBESIDADE GRAU II");
        break;

    default:
        Console.WriteLine($"IMC de {imc} classificaçao OBESIDADE GRAU III");
        break;

}
