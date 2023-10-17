internal class Program
{
    private static void Main(string[] args)
    {
        //1- Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares

        //int[] valor = new int[10];
        //int pares = 0;
        //int impares = 0;

        //for (int i = 0; i < valor.Length; i++)
        //{
        //    Console.WriteLine("Digite o valor " + (i + 1) + ":");
        //    valor[i] = int.Parse(Console.ReadLine());
        //}
        //foreach (int i in valor)
        //{
        //    if (i % 2 == 0)
        //    {
        //        pares++;
        //    }
        //    else
        //    {
        //        impares++;
        //    }
        //}
        //Console.WriteLine("Quantidade de números pares: " + pares);
        //Console.WriteLine("Quantidade de números ímpares: " + impares);





        //2- Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

        //int[] v1 = new int[20];
        //int[] v2 = new int[20];
        //int[] vs = new int[20];

        //Console.WriteLine("Digite os valores para o primeiro vetor: ");
        //for (int i = 0; i < v1.Length; i++)
        //{
        //    Console.WriteLine("Elemento " + (i + 1) + ":");
        //    v1[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("Digite os valores para o segundo vetor: ");
        //for (int i = 0; i < v2.Length; i++) 
        //{
        //    Console.WriteLine("Elemento " + (i + 1) + ":");
        //    v2[i] = int.Parse(Console.ReadLine());
        //}
        //for (int i = 0;i < vs.Length; i++)
        //{
        //    vs[i] = v1[i] + v2[i];
        //}
        //Console.WriteLine("O resultado da soma dos elementos é: ");
        //for (int i = 0; i < 20 ; i++) 
        //{
        //    Console.WriteLine("Elemento " + (i + 1) + ":" + vs[i]);
        //}




        //3- Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.

        //int[] vetor = new int[20];

        //int[] primos = new int[20];

        //int contprimos = 0;

        //Console.WriteLine("Digite 20 valores: ");

        //for (int i = 0; i < 20; i++)
        //{
        //    vetor[i] = int.Parse(Console.ReadLine());
        //    bool verificacao = true;

        //    if (vetor[i] < 2)
        //    {
        //        verificacao = false;
        //    }
        //    else
        //    {
        //        for (int  j = 2; j < vetor[i] ; j++)
        //        {
        //            if (vetor[i] % j == 0)
        //            {
        //                verificacao = false;
        //                break;
        //            }
        //        }
        //    }
        //    if (verificacao)
        //    {
        //        primos[contprimos] = i;
        //        contprimos++;
        //    }
        //}
        //Console.WriteLine("Resultado: ");

        //for (int i = 0;i < contprimos; i++)
        //{
        //    Console.WriteLine(primos[i]);
        //}







        //4- Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor.
        //Mostre o vetor resultante.

        //int[] vetor1 = new int[10];
        //int[] vetor2 = new int[10];
        //int[] result = new int[10];

        //Console.WriteLine("Digite os 10 valores do primeiro vetor: ");

        //for (int i = 0; i < 10; i++)
        //{
        //    vetor1[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("Digite os 10 valores do segundo vetor: ");

        //for(int i = 0;i < 10; i++)
        //{
        //    vetor2[i] = int.Parse(Console.ReadLine());
        //}
        //for(int i = 0; i < 10 ; i++)
        //{
        //    result[i] = vetor1[i] * vetor2[i];
        //}
        //Console.WriteLine("O resultado da multiplicação é: ");

        //for (int i = 0; i < 10 ; i++)
        //{
        //    Console.WriteLine(result[i] + " ");
        //}





        //5- Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

        //int[] vetor = new int[80];
        //int menor = int.MaxValue;
        //int posicao = -1;

        //Console.WriteLine("Digite os 80 números inteiros do vetor: ");

        //for (int i = 0; i < 80; i++)
        //{
        //    vetor[i] = int.Parse(Console.ReadLine());

        //    if (vetor[i] < menor)
        //    {
        //        menor = vetor[i];
        //        posicao = i;
        //    }
        //}
        //Console.WriteLine($"O menor número desse vetor é {menor} e está na posição {posicao}.");






        //6- Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
        //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
        //b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

        //int[] numeros = new int[10];

        //Console.WriteLine("Digite os 10 números: ");

        //for (int i = 0; i < 10; i++)
        //{
        //    numeros[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("Números na ordem inversa: ");

        //for(int i = 9;i >= 0; i--)
        //{
        //    Console.WriteLine(numeros[i] + " ");
        //}






        //7- Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
        //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
        //b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |

        //int[] numeros = new int[10];

        //Console.WriteLine("Digite os 10 números: ");

        //for (int i = 0; i < 10; i++)
        //{
        //    numeros[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("\n Resultado: ");

        //for (int i = 0;i < 10; i++)
        //{
        //    if (numeros[i] %2 == 0)
        //    {
        //        Console.Write("|" + numeros[i]);
        //    }
        //}

        //for (int i =0; i < 10; i++)
        //{
        //    if (numeros[i] %2 != 0)
        //    {
        //        Console.Write("|" + numeros[i]);
        //    }
        //}
        //Console.Write("|");





        //8- Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
        //a.lê:         | 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
        //b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .

        //double[] numeros = new double[30];

        //Console.WriteLine("Digite os 30 números reais: ");

        //for (int i = 0; i < 30; i++)
        //{
        //    numeros[i] = double.Parse(Console.ReadLine());
        //}
        //Console.Write("|");

        //for (int i = 0;i < 30;i++)
        //{
        //    if (numeros[i] < 0)
        //    {
        //        Console.Write(i + 1 + "|");
        //    }
        //}






        //9 -

        //int[] vetor = new int[10] { 10, 7, 3, 6, 9, 1, 2, 5, 8, 4 };
        //int aux = 0;

        //for (int i = 0; i < vetor.Length; i++)
        //{
        //    for (int j = 0; j < (vetor.Length - 1); j++)
        //    {
        //        if (vetor[j + 1] < vetor[j])
        //        {
        //            aux = vetor[j];
        //            vetor[j] = vetor[j + 1];
        //            vetor[j + 1] = aux;
        //        }
        //    }
        //}

        //for (int i = 0; i < vetor.Length; i++)
        //{
        //    Console.WriteLine("Vetor[" + i + "] = " + vetor[i]);
        //}






        //10- Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

        //int[] vetor1 = new int[20];
        //int[] vetor2 = new int[20];

        //Console.WriteLine("Digite os 20 números inteiros: ");

        //for (int i = 0; i < 20; i++)
        //{
        //    vetor1[i] = int.Parse(Console.ReadLine());

        //    vetor2[i] = (vetor1[i] == 0) ? 2: vetor1[i];
        //}

        //Console.WriteLine("\nVetor original: ");

        //Console.Write("|");

        //foreach (int valor in vetor1) 
        //{
        //    Console.Write(valor + "|");
        //}

        //Console.WriteLine();

        //Console.WriteLine("Substituindo os valores nulos por 2: ");

        //Console.Write("|");

        //foreach (int valor in vetor2 )
        //{
        //    Console.Write(valor + "|");
        //}

        //Console.WriteLine();






        //11- Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

        //int[] vetor = new int[5];

        //Console.WriteLine("Digite os 5 valores do vetor: ");

        //for (int i = 0; i < 5; i++)
        //{
        //    vetor[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("Elementos do vetor: ");

        //foreach (int valor in vetor)
        //{
        //    Console.Write(valor + "|");
        //}
        //Console.WriteLine();

        //Console.WriteLine("Na ordem inversa: ");

        //for(int i = 4; i >= 0; i--)
        //{
        //    Console.Write(vetor[i] + "|");
        //}
        //Console.WriteLine();






        //12- Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor.
        //Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".

        //int[] vetor = new int[10];

        //Console.WriteLine("Digite 10 números inteiros: ");

        //for (int i = 0; i < 10; i++)
        //{
        //    vetor[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("Digite o número que quer verificar se existe no vetor: ");
        //int num = int.Parse(Console.ReadLine());

        //bool existe = false;

        //int posicao = 0;

        //foreach (int elemento in vetor)
        //{
        //    if (elemento == num)
        //    {
        //        Console.WriteLine($"O número {num} foi encontrado na posição {posicao}.");
        //        existe = true;
        //    }
        //    posicao++;
        //}
        //if (!existe)
        //{
        //    Console.WriteLine($"O número {num} não foi encontrado no vetor.");
        //}






        //13- Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições.
        //Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.

        //const int max = 100;
        //int[] vetor = new int[max];
        //int cont2 = 0, cont4 = 0, cont8 = 0;
        //int posicao = 0;

        //Console.WriteLine("Digite os números inteiros e positivos para o vetor (Ou -1 para encerrar o programa): ");

        //do
        //{
        //    int num = int.Parse(Console.ReadLine());

        //    if (num == -1)
        //    {
        //        break;
        //    }
        //    if (num == 2)
        //    {
        //        cont2++;
        //    }
        //    else if (num == 4)
        //    {
        //        cont4++;
        //    }
        //    else if (num == 8)
        //    {
        //        cont8++;
        //    }

        //    vetor[posicao] = num;
        //    posicao++;

        //} while (posicao < max);

        //Console.WriteLine($"O número 2 aparece {cont2} vezes.");
        //Console.WriteLine($"O número 4 aparece {cont4} vezes.");
        //Console.WriteLine($"O número 8 aparece {cont8} vezes.");

        //Console.WriteLine("\nValores que estão no vetor: ");
        //for ( int i = 0; i < posicao; i++ )
        //{
        //    Console.Write(vetor[i] + "|");
        //}




        //14- Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. Se o código for zero, termine o algoritmo.
        //Se o código for 1, mostre o vetor na ordem em que foi lido. Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

        //const int max = 50;
        //int[] vetor = new int[max];
        //int codigo;

        //Console.WriteLine("Digite um código (0 para sair, 1 para mostrar o vetor, 2 para mostrar o vetor invertido): ");

        //do
        //{
        //    codigo = int.Parse(Console.ReadLine());

        //    if (codigo == 0)
        //    {
        //        break;
        //    }
        //    else if (codigo == 1)
        //    {
        //        Console.WriteLine("\nVetor na ordem original:");
        //        for (int i = 0; i < max; i++)
        //        {
        //            Console.Write(vetor[i] + "|");
        //        }
        //        Console.WriteLine();
        //    }
        //    else if (codigo == 2)
        //    {
        //        Console.WriteLine("\nVetor na ordem inversa:");
        //        for (int i = max - 1; i >= 0; i--)
        //        {
        //            Console.Write(vetor[i] + "|");
        //        }
        //        Console.WriteLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Código inválido. Tente novamente.");
        //    }
        //} while (true);





        //15- Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem.
        //Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os conteúdos do primeiro vetor em uma
        //linha e os do segundo uma linha abaixo.

        //int[] vetor1 = new int[20];
        //int[] vetor2 = new int[20];

        //Console.WriteLine("Digite 20 números inteiros:");

        //for (int i = 0; i < 20; i++)
        //{
        //    vetor1[i] = int.Parse(Console.ReadLine());
        //}

        //for (int i = 0; i < 20; i++)
        //{
        //    vetor2[i] = vetor1[19 - i];
        //}

        //Console.WriteLine("\nConteúdo do primeiro vetor:");
        //for (int i = 0; i < 20; i++)
        //{
        //    Console.Write(vetor1[i] + "|");
        //}

        //Console.WriteLine("\n\nConteúdo do segundo vetor (invertido):");
        //for (int i = 0; i < 20; i++)
        //{
        //    Console.Write(vetor2[i] + "|");
        //}







        //16 -

        //int[] x = new int[4] { 0, 1, 2, 3 };
        //int[] y = new int[4] { 3, 4, 5, 6 };

        //int[] uniao = new int[8];
        //int[] diferenca = new int[4];
        //int[] interseccao = new int[4];

        ////UNIÃO 
        //x.CopyTo(uniao, 0);

        //int aux = 4;

        //for (int i = 0; i < y.Length; i++)
        //{
        //    for (int j = 0; j < x.Length; j++)
        //    {
        //        if (y[i] == x[j])
        //        {
        //            break;
        //        }

        //        if (j == (x.Length - 1))
        //        {
        //            uniao[aux] = y[i];
        //            aux++;
        //        }
        //    }
        //}

        //for (int i = 0; i < aux; i++)
        //{
        //    Console.WriteLine("união[" + i + "] = " + uniao[i]);
        //}

        //int aux2 = 0;

        //for (int i = 0; i < x.Length; i++)
        //{
        //    for (int j = 0; j < y.Length; j++)
        //    {
        //        if (x[i] == y[j])
        //        {
        //            break;
        //        }

        //        if (j == (y.Length - 1))
        //        {
        //            diferenca[aux2] = x[i];
        //            aux2++;
        //        }
        //    }
        //}

        //for (int i = 0; i < aux2; i++)
        //{
        //    Console.WriteLine("Diferença[" + i + "] = " + diferenca[i]);
        //}







    }
}