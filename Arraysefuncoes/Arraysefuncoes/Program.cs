// ARRAYS 

//1 - SOMA DOS ELEMENTOS
//Receba 5 números inteiros, armazene-os em um array e exiba a soma total dos elementos.

//int[] numeros = new int[5];
//int soma = 0;

//Console.WriteLine("Digite 5 numeros inteiros: ");

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine($"Numero {i + 1}: ");
//    string input = Console.ReadLine();

//    if (int.TryParse(input, out int numero))
//    {
//        numeros[i] = numero; //armazena o numero no array
//        //soma += numero;      // soma o numero ao total - aq acontece a soma
//    }
//    else
//    {
//        Console.WriteLine("Entrada invalida. Tente novamente.");
//        i--;
//    }

//}
//Console.WriteLine($"A soma dos numeros informados e: {soma}");

//2 - MAIOR E MENOR VALOR
// Peça ao usuário 10 números e armazene-os em um array. Em seguida, exiba o maior e o menor valor inserido.

//int[] numeros = new int[10];

//Console.WriteLine("Digite 10 numeros inteiros: ");

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine($"Numero {i + 1}: ");
//    string input = Console.ReadLine();

//    if (int.TryParse(input, out int numero))
//    {
//        numeros[i] = numero;
//    }
//    else
//    {
//        Console.WriteLine("Entrada invalida. Tente novamente.");
//        i--;
//    }

//}

//int maior = numeros[0];
//int menor = numeros[0];

//for (int i = 1; i < numeros.Length; i++)
//{
//    if (numeros[i] > maior)
//        maior = numeros[i];

//    if (numeros[i] < menor)
//        menor = numeros[i];
//}

//Console.WriteLine($"\nMaior valor informado: {maior}");
//Console.WriteLine($"Menor valor informado: {menor}");


int somar(int num0, int num3)
{
 return num0 + num3;
}
int resultado = somar(3, 5);
Console.WriteLine(resultado);

//