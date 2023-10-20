using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Funcoes
{
    internal class Program
    {
        //static int[] vetor = new int[10]; //Variável Global da questão 2

        static void Main(string[] args)
        {
            //1- Fazer uma calculadora das 4 operações (soma, subtração, multiplicação e divisão) Para isso, precisaremos aceitar números com vírgula.

            //while (true)
            //{
            //    Console.WriteLine("Escolha uma operação: (+ para soma, - para subtração, * para multiplicação, / para divisão, Q para sair)");

            //    string operacao = Console.ReadLine();

            //    if (operacao == "Q" || operacao == "q")
            //    {
            //        break;
            //    }

            //    Console.WriteLine("Digite o primeiro número: ");
            //    double num1 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite o segundo número:");
            //    double num2 = double.Parse(Console.ReadLine());

            //    double resultado = 0;

            //    switch (operacao)
            //    {
            //        case "+":
            //            resultado = Soma(num1, num2);
            //            break;
            //        case "-":
            //            resultado = Subtracao(num1, num2);
            //            break;
            //        case "*":
            //            resultado = Multiplicacao(num1, num2);
            //            break;
            //        case "/":
            //            if (num2 != 0)
            //            {
            //                resultado = Divisao(num1, num2);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Erro! Divisão por zero.");
            //                continue;
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Operação inválida.");
            //            continue;
            //    }

            //    Console.WriteLine($"O resultado da operação é: {resultado}");
            //}
            //static double Soma(double a, double b)
            //{
            //    return a + b;
            //}

            //static double Subtracao(double a, double b)
            //{
            //    return a - b;
            //}

            //static double Multiplicacao(double a, double b)
            //{
            //    return a * b;
            //}

            //static double Divisao(double a, double b)
            //{
            //    return a / b;
            //}







            //2- Fazer programa que tenha duas funções. i) para ler um vetor de 10 elementos (variável global) e ii) para verificar e apresentar a quantidadede elementos pares que
            //este vetor possui.

            //LerVetor();

            //int pares = ContarPares();

            //Console.WriteLine($"O vetor possui {pares} elementos pares.");

            //static void LerVetor()
            //{
            //    Console.WriteLine("Digite 10 números inteiros: ");

            //    for (int i = 0; i < 10; i++)
            //    {
            //        vetor[i] = int.Parse(Console.ReadLine());
            //    }
            //}

            //static int ContarPares()
            //{
            //    int pares = 0;

            //    foreach (int num in vetor)
            //    {
            //        if (num % 2 == 0)
            //        {
            //            pares++;
            //        }
            //    }

            //    return pares;
            //}







            //3-  Desenvolva uma função que calcule a média de três números fornecidos como argumentos.


            //Console.Write("Insira o 1° número: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Insira o 2° número: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.Write("Insira o 3° número: ");
            //double num3 = double.Parse(Console.ReadLine());

            //double media = CalcularMedia(num1, num2, num3);

            //Console.WriteLine($"A média dos números {num1}, {num2} e {num3} é: {media}");

            //static double CalcularMedia(double num1, double num2, double num3)
            //{
            //    double media = (num1 + num2 + num3) / 3;
            //    return media;
            //}







            //4- Escreva uma função que calcule o fatorial de um número inteiro positivo.

            //Console.WriteLine("Digite um número para calcular o fatorial: ");
            //int num = int.Parse(Console.ReadLine());

            //int resultado = CalcularFatorial(num);

            //Console.WriteLine($"O fatorial de {num} é: {resultado}");

            //static int CalcularFatorial(int num)
            //{
            //    if (num < 0)
            //    {
            //        throw new ArgumentException("O número deve ser não-negativo.");
            //    }

            //    if (num == 0 || num == 1)
            //    {
            //        return 1;
            //    }

            //    int fatorial = 1;
            //    for (int i = 2; i <= num; i++)
            //    {
            //        fatorial *= i;
            //    }

            //    return fatorial;
            //}






            //5- Desenvolva uma função que converta uma temperatura em graus Celsius para Fahrenheit.

            //Console.WriteLine("Digite a temperatura em graus Celsius: ");
            //double celsius = double.Parse(Console.ReadLine());

            //double fahrenheit = ConverterFahrenheit(celsius);

            //Console.WriteLine($"{celsius} graus Celsius equivalem a {fahrenheit} graus Fahrenheit.");

            //static double ConverterFahrenheit (double celsius)
            //{
            //    double fahrenheit = (celsius * 9 / 5) + 32;
            //    return fahrenheit;
            //}






            //6- Escreva uma função que calcule a média de um vetor de 10 números.

            //int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //double media = CalcularMedia(vetor);

            //Console.WriteLine($"A média do vetor é: {media}");

            //static double CalcularMedia(int[] vetor)
            //{
            //    double soma = 0;
            //    foreach (int numero in vetor)
            //    {
            //        soma += numero;
            //    }

            //    double media = soma / vetor.Length;
            //    return media;
            //}







            //7- Crie uma função que determine se um número é primo ou não.

            //Console.WriteLine("Digite o número que quer verificar se é primo ou não: ");
            //int numero = int.Parse(Console.ReadLine());

            //if (VerificarPrimo(numero))
            //{
            //    Console.WriteLine($"{numero} é um número primo.");
            //}
            //else
            //{
            //    Console.WriteLine($"{numero} não é um número primo.");
            //}

            //static bool VerificarPrimo(int num)
            //{
            //    if (num <= 1)
            //    {
            //        return false;
            //    }

            //    if (num == 2)
            //    {
            //        return true;
            //    }

            //    if (num % 2 == 0)
            //    {
            //        return false;
            //    }

            //    int limite = (int)Math.Floor(Math.Sqrt(num));

            //    for (int i = 3; i <= limite; i += 2)
            //    {
            //        if (num % i == 0)
            //        {
            //            return false;
            //        }
            //    }

            //    return true;
            //}





            //8- Ler um número inteiro e passar por parâmetro para uma função e retornar 0, se o número é par, ou 1, se o número é ímpar.

            //Console.WriteLine("Digite um número inteiro qualquer: ");
            //int num = int.Parse(Console.ReadLine());

            //int result = VerificaParImpar(num);

            //if (result == 0)
            //{
            //    Console.WriteLine("O número é par.");
            //} 
            //else
            //{
            //    Console.WriteLine("O número é ímpar.");
            //}

            //static int VerificaParImpar(int num)
            //{
            //    if (num %2 == 0)
            //    {
            //        return 0;
            //    }
            //    else
            //    {
            //        return 1;
            //    }
            //}








            //9- Escrever um programa com uma função que receba por parâmetro dois números (n1 e n2) e retorna a soma dos números inteiros que existem entre n1 e n2 (inclusive ambos).
            //Apresente o resultado na main.

            //Console.WriteLine("Digite o primeiro número:");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo número:");
            //int n2 = int.Parse(Console.ReadLine());

            //int soma = SomaInteiros(n1, n2);

            //Console.WriteLine($"A soma dos números inteiros entre {n1} e {n2} é: {soma}");

            //static int SomaInteiros (int n1, int n2)
            //{
            //    int soma = 0;

            //    for (int i = n1; i <= n2; i++)
            //    {
            //        soma += i;
            //    }

            //    return soma;
            //}






            //10 - Desafio: Ler um vetor de inteiros com 10 elementos e passar por parâmetro para uma função que verifica e retorna o menor elemento do vetor.

            //int[] vetor = new int[10];

            //Console.WriteLine("Digite 10 números inteiros: ");

            //for (int i = 0; i < 10; i++)
            //{
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}

            //int menorElemento = EncontrarMenorElemento(vetor);

            //Console.WriteLine($"O menor elemento do vetor é: {menorElemento}");

            //static int EncontrarMenorElemento(int[] vetor)
            //{
            //    int menor = vetor[0];

            //    for (int i = 1; i < vetor.Length; i++)
            //    {
            //        if (vetor[i] < menor)
            //        {
            //            menor = vetor[i];
            //        }
            //    }

            //    return menor;
            //}






            //11- Na teoria dos Sistemas, define-se como elemento minimax de uma matriz, o menor elemento da linha em que se encontra o maior elemento da matriz.
            //Escreva um programa que lê uma matriz [10 X 10] e em uma função encontre e mostre o elemento minimax e sua posição na matriz.

            //int[,] matriz = new int[10, 10];

            //Console.WriteLine("Digite os elementos da matriz [10x10]: ");

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //EncontrarElementoMinimax(matriz);

            //static void EncontrarElementoMinimax(int[,] matriz)
            //{
            //    int maior = matriz[0, 0];
            //    int linhaMaior = 0;
            //    int colunaMaior = 0;

            //    for (int i = 0; i < 10; i++)
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            if (matriz[i, j] > maior)
            //            {
            //                maior = matriz[i, j];
            //                linhaMaior = i;
            //                colunaMaior = j;
            //            }
            //        }
            //    }

            //    int menor = matriz[linhaMaior, 0];

            //    for (int j = 1; j < 10; j++)
            //    {
            //        if (matriz[linhaMaior, j] < menor)
            //        {
            //            menor = matriz[linhaMaior, j];
            //        }
            //    }

            //    Console.WriteLine($"Elemento minimax: {menor}");
            //    Console.WriteLine($"Posição: [{linhaMaior},{colunaMaior}]");
            //}









            //12- Escreva uma função chamada CalcularMedia que recebe um vetor de números, a informação se o usuário deseja escolher os pares ou os impares, e retorna a média
            //dos valores conforme a escolha do usuário.

            //int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine("Deseja calcular a média dos números pares (P) ou ímpares (I)?");
            //char escolha = char.ToUpper(Console.ReadKey().KeyChar);

            //double media = CalcularMedia(numeros, escolha);

            //Console.WriteLine($"\nA média dos números {escolha} é: {media}");

            //static double CalcularMedia(int[] numeros, char escolha)
            //{
            //    int soma = 0;
            //    int contador = 0;

            //    foreach (int numero in numeros)
            //    {
            //        if ((numero % 2 == 0 && escolha == 'P') || (numero % 2 != 0 && escolha == 'I'))
            //        {
            //            soma += numero;
            //            contador++;
            //        }
            //    }

            //    return (contador > 0) ? (double)soma / contador : 0;
            //}





            //13- Escreva uma função chamada TransporMatriz que recebe uma matriz como parâmetro e retorna a matriz transposta.

            //    int[,] matrizOriginal = {
            //    {1, 2, 3},
            //    {4, 5, 6},
            //    {7, 8, 9}
            //};

            //    int[,] matrizTransposta = TransporMatriz(matrizOriginal);

            //    Console.WriteLine("Matriz Original: ");
            //    MostrarMatriz(matrizOriginal);

            //    Console.WriteLine("\nMatriz Transposta: ");
            //    MostrarMatriz(matrizTransposta);

            //    static int[,] TransporMatriz(int[,] matriz)
            //    {
            //        int linhas = matriz.GetLength(0);
            //        int colunas = matriz.GetLength(1);

            //        int[,] matrizTransposta = new int[colunas, linhas];

            //        for (int i = 0; i < linhas; i++)
            //        {
            //            for (int j = 0; j < colunas; j++)
            //            {
            //                matrizTransposta[j, i] = matriz[i, j];
            //            }
            //        }

            //        return matrizTransposta;
            //    }

            //    static void MostrarMatriz(int[,] matriz)
            //    {
            //        int linhas = matriz.GetLength(0);
            //        int colunas = matriz.GetLength(1);

            //        for (int i = 0; i < linhas; i++)
            //        {
            //            for (int j = 0; j < colunas; j++)
            //            {
            //                Console.Write(matriz[i, j] + " ");
            //            }
            //            Console.WriteLine();
            //        }
            //    }




            //14- Escreva uma função chamada MultiplicarMatrizes que recebe duas matrizes como parâmetros e retorna a matriz resultante da multiplicação.

            //    int[,] matrizA = {
            //    {1, 2, 3},
            //    {4, 5, 6},
            //};

            //    int[,] matrizB = {
            //    {7, 8},
            //    {9, 10},
            //    {11, 12}
            //};

            //    int[,] matrizResultado = MultiplicarMatrizes(matrizA, matrizB);

            //    Console.WriteLine("Matriz A:");
            //    ImprimirMatriz(matrizA);

            //    Console.WriteLine("\nMatriz B:");
            //    ImprimirMatriz(matrizB);

            //    Console.WriteLine("\nMatriz Resultado:");
            //    ImprimirMatriz(matrizResultado);

            //    static int[,] MultiplicarMatrizes(int[,] matrizA, int[,] matrizB)
            //    {
            //        int linhasA = matrizA.GetLength(0);
            //        int colunasA = matrizA.GetLength(1);
            //        int linhasB = matrizB.GetLength(0);
            //        int colunasB = matrizB.GetLength(1);

            //        if (colunasA != linhasB)
            //        {
            //            throw new InvalidOperationException("As matrizes não podem ser multiplicadas.");
            //        }

            //        int[,] matrizResultado = new int[linhasA, colunasB];

            //        for (int i = 0; i < linhasA; i++)
            //        {
            //            for (int j = 0; j < colunasB; j++)
            //            {
            //                for (int k = 0; k < colunasA; k++)
            //                {
            //                    matrizResultado[i, j] += matrizA[i, k] * matrizB[k, j];
            //                }
            //            }
            //        }

            //        return matrizResultado;
            //    }
            //    static void ImprimirMatriz(int[,] matriz)
            //    {
            //        int linhas = matriz.GetLength(0);
            //        int colunas = matriz.GetLength(1);

            //        for (int i = 0; i < linhas; i++)
            //        {
            //            for (int j = 0; j < colunas; j++)
            //            {
            //                Console.Write(matriz[i, j] + " ");
            //            }
            //            Console.WriteLine();
            //        }
            //    }







            //15- Crie uma função chamada SomaDiagonalPrincipal que recebe uma matriz quadrada como parâmetro e retorna a soma dos elementos na diagonal principal.

            //    int[,] matriz = {
            //    {1, 2, 3},
            //    {4, 5, 6},
            //    {7, 8, 9}
            //};

            //    int somaDiagonal = SomaDiagonalPrincipal(matriz);

            //    Console.WriteLine("Matriz:");
            //    MostrarMatriz(matriz);

            //    Console.WriteLine($"\nSoma da Diagonal Principal: {somaDiagonal}");

            //    static int SomaDiagonalPrincipal(int[,] matriz)
            //    {
            //        int soma = 0;
            //        int tamanho = matriz.GetLength(0);

            //        for (int i = 0; i < tamanho; i++)
            //        {
            //            soma += matriz[i, i];
            //        }

            //        return soma;
            //    }
            //    static void MostrarMatriz(int[,] matriz)
            //    {
            //        int linhas = matriz.GetLength(0);
            //        int colunas = matriz.GetLength(1);

            //        for (int i = 0; i < linhas; i++)
            //        {
            //            for (int j = 0; j < colunas; j++)
            //            {
            //                Console.Write(matriz[i, j] + "\t");
            //            }
            //            Console.WriteLine();
            //        }
            //    }







            //16- Escreva uma função chamada MediaColunaMatriz que recebe uma matriz e um número de coluna como parâmetros, e retorna a soma dos elementos nessa coluna.

            //    int[,] matriz = {
            //    {1, 2, 3},
            //    {4, 5, 6},
            //    {7, 8, 9}
            //};

            //    int numColuna = 1;
            //    int somaColuna = MediaColunaMatriz(matriz, numColuna);

            //    Console.WriteLine($"Matriz:");
            //    MostrarMatriz(matriz);

            //    Console.WriteLine($"\nSoma dos elementos na coluna {numColuna}: {somaColuna}");

            //    static int MediaColunaMatriz(int[,] matriz, int coluna)
            //    {
            //        int soma = 0;
            //        int tamanho = matriz.GetLength(0);

            //        for (int i = 0; i < tamanho; i++)
            //        {
            //            soma += matriz[i, coluna];
            //        }

            //        return soma;
            //    }

            //    static void MostrarMatriz(int[,] matriz)
            //    {
            //        int linhas = matriz.GetLength(0);
            //        int colunas = matriz.GetLength(1);

            //        for (int i = 0; i < linhas; i++)
            //        {
            //            for (int j = 0; j < colunas; j++)
            //            {
            //                Console.Write(matriz[i, j] + "\t");
            //            }
            //            Console.WriteLine();
            //        }
            //    }






            //17- Crie uma função chamada VerificarNumeroPrimo que recebe um vetor de números inteiros como parâmetro e retorna verdadeiro se pelo menos um número primo estiver
            //presente no vetor, e falso caso contrário.

            //int[] vetor = { 2, 4, 8, 9, 15, 20, 27 };

            //bool temPrimo = VerificarNumeroPrimo(vetor);

            //Console.WriteLine(temPrimo ? "Pelo menos um número primo está presente no vetor." : "Nenhum número primo está presente no vetor.");

            //static bool VerificarNumeroPrimo(int[] vetor)
            //{
            //    foreach (int numero in vetor)
            //    {
            //        if (Primo(numero))
            //        {
            //            return true;
            //        }
            //    }

            //    return false;
            //}
            //static bool Primo(int numero)
            //{
            //    if (numero < 2) return false;
            //    if (numero == 2) return true;
            //    if (numero % 2 == 0) return false;

            //    for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            //    {
            //        if (numero % i == 0)
            //        {
            //            return false;
            //        }
            //    }

            //    return true;
            //}














        }

    }
}