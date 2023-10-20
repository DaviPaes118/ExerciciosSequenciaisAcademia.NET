namespace ListaExerciciosMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos
            //da 1ª coluna.

            //int[,] matriz = new int[5, 3];

            //Console.WriteLine("Digite os valores da primeira coluna: ");

            //for (int i = 0; i < 5; i++)
            //{
            //    matriz[i, 0] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    matriz[i, 1] = matriz[i, 0] + 10;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    matriz[i, 2] = matriz[i, 0] * 2;
            //}
            //Console.WriteLine("\nMatriz resultante:");

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matriz[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}





            //2- Solicite ao usuário, preencher uma Matriz 3x3

            //Informe ao usuário:
            //*A soma dos elementos de cada linha
            //-Ex: Linha 1: 30
            //Linha 2: 17
            //* A soma dos elementos de cada coluna
            //-Ex: Coluna 1: 23
            //Coluna 2: 36

            //int[,] matriz = new int[3, 3];

            //Console.WriteLine("Digite os números da matriz: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Digite o valor para a posição [{i}, {j}]: ");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Soma dos elementos de cada linha: ");

            //for (int i = 0; i < 3; i++)
            //{
            //    int somaLinha = 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        somaLinha += matriz[i, j];
            //    }
            //    Console.WriteLine($"Linha {i + 1}: {somaLinha}");
            //}
            //Console.WriteLine("Soma dos elementos de cada coluna: ");

            //for (int j = 0; j < 3; j++)
            //{
            //    int somaColuna = 0;
            //    for (int i = 0; i < 3; i++)
            //    {
            //        somaColuna += matriz[i, j];
            //    }
            //    Console.WriteLine($"Coluna {j + 1}: {somaColuna}");
            //}






            //3- Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            //int[,] matriz = new int[4, 4];

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        matriz[i, j] = i * 4 + j + 1;
            //    }
            //}
            //Console.WriteLine("A matriz 4x4 é: ");

            //for (int i = 0;i < 4; i++)
            //{
            //    for(int j = 0;j < 4; j++)
            //    {
            //        Console.Write(matriz[i, j].ToString().PadLeft(4));
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("\nOs elementos da Diagonal Principal são: ");

            //for(int i = 0; i < 4; i++)
            //{
            //    Console.Write(matriz[i, i].ToString().PadLeft(4));
            //}







            //4- Popule uma matriz 5x5 e informe:
            //-Quantos números são pares
            //- Quantos números são impares
            //- Quantos números são positivos
            //- Quantos números são negativos
            //- Quantos zeros existem!

            //int[,] matriz = new int[5,5];

            //int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;

            //Console.WriteLine("Informe os números da matriz (5x5): ");

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        matriz[i, j] = int.Parse(Console.ReadLine());

            //        if (matriz[i, j] % 2 == 0)
            //            pares++;

            //        else
            //            impares++;

            //        if (matriz[i, j] > 0)
            //            positivos++;

            //        else if (matriz[i, j] < 0)
            //            negativos++;

            //        else
            //            zeros++;
            //    }
            //}
            //Console.WriteLine($"\nA quantidade de números pares é: {pares}");
            //Console.WriteLine($"\nA quantidade de números ímpares é: {impares}");
            //Console.WriteLine($"\nA quantidade de números positivos é: {positivos}");
            //Console.WriteLine($"\nA quantidade de números negativos é: {negativos}");
            //Console.WriteLine($"\nA quantidade de números Zero é: {zeros}");








            //5- Leia duas matrizes 2x3 de números double. Imprima a soma destas duas matrizes.

            //double[,] matriz1 = new double[2, 3];
            //double[,] matriz2 = new double[2, 3];
            //double[,] SomaMatrizes = new double[2, 3];

            //Console.WriteLine("Digite os números da 1° matriz (2x3): ");
            //OcuparMatriz(matriz1);

            //Console.WriteLine("\nDigite os números da 2° matriz (2x3): ");
            //OcuparMatriz(matriz2);

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        SomaMatrizes[i, j] = matriz1[i, j] + matriz2[i, j];
            //    }
            //}
            //Console.WriteLine("\nA soma das matrizes é:");

            //MostrarMatriz(SomaMatrizes);

            //static void OcuparMatriz(double[,] matriz)
            //{
            //    for (int i = 0; i < 2; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            matriz[i, j] = double.Parse(Console.ReadLine());
            //        }
            //    }
            //}
            //static void MostrarMatriz(double[,] matriz)
            //{
            //    for (int i = 0; i < 2; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            Console.Write(matriz[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}








            //6- Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);

            //int[,] matriz = new int[4, 4];
            //Random random = new Random();

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        matriz[i, j] = random.Next(0, 10);
            //    }
            //}
            //Console.WriteLine("Matriz gerada: ");
            //MostrarMatriz(matriz);

            //int MaiorNumero = EncontrarMaiorNumero(matriz);
            //Console.WriteLine("\nO maior número na matriz é: " + MaiorNumero);

            //static void MostrarMatriz(int[,] matriz)
            //{
            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            Console.Write(matriz[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //static int EncontrarMaiorNumero(int[,] matriz)
            //{
            //    int maior = matriz[0, 0];
            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            if (matriz[i, j] > maior)
            //            {
            //                maior = matriz[i, j];
            //            }
            //        }
            //    }
            //    return maior;
            //}








            //7- Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

            //int[,] matrizA = new int[3, 3];
            //int[,] matrizB = new int[3, 3];
            //int[,] matrizC = new int[3, 3];

            //OcuparMatriz(matrizA, "Matriz A");
            //OcuparMatriz(matrizB, "Matriz B");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
            //    }
            //}
            //MostrarMatriz(matrizA, "Matriz A");
            //MostrarMatriz(matrizB, "Matriz B");
            //MostrarMatriz(matrizC, "Matriz C");

            //static void OcuparMatriz(int[,] matriz, string nome)
            //{
            //    Console.WriteLine($"Informe os números da {nome} (3x3): ");
            //    for (int i = 0; i < 3; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            Console.Write($"{nome}[{i + 1},{j + 1}]: ");
            //            matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //static void MostrarMatriz(int[,] matriz, string nome)
            //{
            //    Console.WriteLine($"{nome}: ");
            //    for (int i = 0; i < 3; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            Console.Write(matriz[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}







            //8- Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            //int[,] matriz = new int[4, 4];

            //Console.WriteLine("Digite os valores para a matriz (4x4): ");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Posição [{i + 1},{j + 1}]: ");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("\nMatriz na ordem direta: ");
            //MostrarMatrizOriginal(matriz);

            //Console.WriteLine("\nMatriz na ordem inversa: ");
            //MostrarMatrizInversa(matriz);

            //static void MostrarMatrizOriginal(int[,] matriz)
            //{
            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            Console.Write(matriz[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //static void MostrarMatrizInversa(int[,] matriz)
            //{
            //    for (int i = 3; i >= 0; i--)
            //    {
            //        for (int j = 3; j >= 0; j--)
            //        {
            //            Console.Write(matriz[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}






            //9- Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
            //Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

            //int[,] matriz = new int[3, 3];

            //Console.WriteLine("Digite os valores para a matriz (3x3): ");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Posição [{i + 1},{j + 1}]: ");
            //        matriz[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.Write("\nDigite um número para pesquisar na matriz: ");
            //int numero = int.Parse(Console.ReadLine());

            //bool encontrado = false;
            //foreach (int elemento in matriz)
            //{
            //    if (elemento == numero)
            //    {
            //        encontrado = true;
            //        break;
            //    }
            //}
            //if (encontrado)
            //{
            //    Console.WriteLine($"O número {numero} existe na matriz.");
            //}
            //else
            //{
            //    Console.WriteLine($"O número {numero} não foi encontrado na matriz.");
            //}










            //10- Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

            //int[,] matrizA = new int[4, 4];
            //int[,] matrizB = new int[4, 4];

            //OcuparMatriz(matrizA, "A");
            //OcuparMatriz(matrizB, "B");

            //double media = (CalcularSoma(matrizA) + CalcularSoma(matrizB)) / (matrizA.Length + matrizB.Length);

            //int AbaixoMedia = ContarElementos(matrizA, x => x < media) + ContarElementos(matrizB, x => x < media);
            //int AcimaMedia = ContarElementos(matrizA, x => x > media) + ContarElementos(matrizB, x => x > media);
            //int NaMedia = ContarElementos(matrizA, x => x == media) + ContarElementos(matrizB, x => x == media);

            //Console.WriteLine($"\nA média dos elementos é: {media}");

            //Console.WriteLine($"Elementos abaixo da média: {AbaixoMedia}");

            //Console.WriteLine($"Elementos acima da média: {AcimaMedia}");

            //Console.WriteLine($"Elementos na média: {NaMedia}");

            //static void OcuparMatriz(int[,] matriz, string nomeMatriz)
            //{
            //    Console.WriteLine($"Digite os valores para a matriz {nomeMatriz} (4x4):");
            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            Console.Write($"{nomeMatriz}[{i + 1},{j + 1}]: ");
            //            matriz[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //}
            //static int CalcularSoma(int[,] matriz)
            //{
            //    int soma = 0;
            //    foreach (int elemento in matriz)
            //    {
            //        soma += elemento;
            //    }
            //    return soma;
            //}
            //static int ContarElementos(int[,] matriz, Func<int, bool> condicao)
            //{
            //    int contador = 0;
            //    foreach (int elemento in matriz)
            //    {
            //        if (condicao(elemento))
            //        {
            //            contador++;
            //        }
            //    }
            //    return contador;
            //}








            //11- Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

            //double[,] matrizA = new double[3, 3];
            //double[,] result = new double[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matrizA[i, j] = i + j + 1; 
            //    }
            //}
            //double SomaIndices = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        SomaIndices += (i + j);
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        result[i, j] = matrizA[i, j] / SomaIndices;
            //    }
            //}
            //Console.WriteLine("Matriz A: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrizA[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("\nMatriz Resultante:");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(result[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}






            //12- Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.

            //int[,] matriz = new int[4, 3];

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matriz[i, j] = i + j;
            //    }
            //}
            //Console.WriteLine("Valores que a soma dos índices é par: ");
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.WriteLine($"Posição[{i},{j}] = {matriz[i, j]}");
            //        }
            //    }
            //}







            //13- Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
            //diagonal secundária.

            //int[,] matriz = new int[5, 5];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        matriz[i, j] = i + j;
            //    }
            //}

            //int SomaDP = 0;
            //int SomaDS = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    SomaDP += matriz[i, i];
            //    SomaDS += matriz[i, 4 - i];
            //}
            //if (SomaDP == SomaDS)
            //{
            //    Console.WriteLine("A soma dos elementos da diagonal principal é igual à soma dos elementos da diagonal secundária.");
            //}
            //else
            //{
            //    Console.WriteLine("A soma dos elementos da diagonal principal é diferente da soma dos elementos da diagonal secundária.");
            //}






            //14- Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita) são os mesmos da diagonal
            //secundária (direita pra esquerda).

            //int[,] matriz = new int[5, 5];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        matriz[i, j] = i + j;
            //    }
            //}

            //bool DiagonaisIguais = true;

            //for (int i = 0; i < 5; i++)
            //{
            //    if (matriz[i, i] != matriz[i, 4 - i])
            //    {
            //        DiagonaisIguais = false;
            //        break;
            //    }
            //}
            //if (DiagonaisIguais)
            //{
            //    Console.WriteLine("Os elementos da diagonal principal SÃO iguais aos da diagonal secundária.");
            //}
            //else
            //{
            //    Console.WriteLine("Os elementos da diagonal principal NÃO SÃO iguais aos da diagonal secundária.");
            //}






            //15- Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

            //int[,] matriz1 = new int[4, 4];
            //int[,] matriz2 = new int[4, 4];
            //int[,] resultado = new int[4, 4];

            //Console.WriteLine("Digite os valores da 1° matriz 4x4:");
            //LerMatriz(matriz1);

            //Console.WriteLine("\nDigite os valores da 2° matriz 4x4:");
            //LerMatriz(matriz2);

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            //    }
            //}

            //Console.WriteLine("\nMatriz Resultante:");
            //MostrarMatriz(resultado);

            //static void LerMatriz(int[,] matriz)
            //{
            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            Console.Write($"Elemento [{i + 1}, {j + 1}]: ");
            //            matriz[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //}
            //static void MostrarMatriz(int[,] matriz)
            //{
            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            Console.Write(matriz[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}





            //16- Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

            //int[,] MatrizOriginal = new int[3, 4];
            //int[,] MatrizTransposta = new int[4, 3];

            //Console.WriteLine("Digite os valores da matriz 3x4: ");

            //LerMatriz(MatrizOriginal);

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        MatrizTransposta[j, i] = MatrizOriginal[i, j];
            //    }
            //}
            //Console.WriteLine("\nMatriz Transposta 4x3: ");

            //MostrarMatriz(MatrizTransposta);

            //static void LerMatriz(int[,] matriz)
            //{
            //    for (int i = 0; i < matriz.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matriz.GetLength(1); j++)
            //        {
            //            Console.Write($"Elemento [{i + 1}, {j + 1}]: ");
            //            matriz[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //}

            //static void MostrarMatriz(int[,] matriz)
            //{
            //    for (int i = 0; i < matriz.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matriz.GetLength(1); j++)
            //        {
            //            Console.Write(matriz[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}






            //17- Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o 
            //maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.

            //int[,] matriz = new int[10, 10];

            //Console.WriteLine("Digite os valores para a matriz 10x10: ");

            //LerMatriz(matriz);

            //int MaiorElemento = EncontrarMaiorElemento(matriz, out int linhaMaior, out int colunaMaior);

            //int MenorElemento = EncontrarMenorElementoLinha(matriz, linhaMaior);

            //Console.WriteLine($"\nO maior elemento é {MaiorElemento} na linha {linhaMaior + 1}, coluna {colunaMaior + 1}");
            //Console.WriteLine($"O menor elemento na linha do maior é {MenorElemento}.");

            //static void LerMatriz(int[,] matriz)
            //{
            //    for (int i = 0; i < matriz.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matriz.GetLength(1); j++)
            //        {
            //            Console.Write($"Elemento [{i + 1}, {j + 1}]: ");
            //            matriz[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //}
            //static int EncontrarMaiorElemento(int[,] matriz, out int linhaMaior, out int colunaMaior)
            //{
            //    int maior = matriz[0, 0];
            //    linhaMaior = 0;
            //    colunaMaior = 0;

            //    for (int i = 0; i < matriz.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matriz.GetLength(1); j++)
            //        {
            //            if (matriz[i, j] > maior)
            //            {
            //                maior = matriz[i, j];
            //                linhaMaior = i;
            //                colunaMaior = j;
            //            }
            //        }
            //    }

            //    return maior;
            //}
            //static int EncontrarMenorElementoLinha(int[,] matriz, int linha)
            //{
            //    int menor = matriz[linha, 0];

            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        if (matriz[linha, j] < menor)
            //        {
            //            menor = matriz[linha, j];
            //        }
            //    }
            //    return menor;
            //}








        }
    }
}