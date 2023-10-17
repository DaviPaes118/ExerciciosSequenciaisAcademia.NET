using static System.Net.Mime.MediaTypeNames;
using System.Runtime.ConstrainedExecution;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics.Metrics;
using System;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        //1 -Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n pessoas e calcular a média das idades.

        //Console.WriteLine("Digite a quantidade de pessoas: ");
        //int n = int.Parse(Console.ReadLine());

        //int soma = 0;

        //for (int i = 1; i <= n; i++) 
        //{
        //    Console.WriteLine($"Digite a idade da pessoa {i}");
        //    int idade = int.Parse(Console.ReadLine());

        //    soma += idade;
        //}
        //double mediaidade = (double)soma / n;

        //Console.WriteLine($"A média das idades é: {mediaidade}");




        //2- Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.

        //int maior = int.MinValue;

        //for (int i = 0; i < 10; i++) 
        //{
        //    Console.WriteLine($"Digite o {i + 1}° número: ");
        //    int num = int.Parse( Console.ReadLine());

        //    if ( num > maior ) 
        //    {
        //        maior = num;
        //    }
        //}
        //Console.WriteLine($"O maior número é: {maior}");





        //3- Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número Escreva um algoritmo que leia pelo teclado um valor e então calcule a
        //tabuada de 1 a 10 de um número

        // Console.WriteLine("Digite um número entre 1 e 10: ");
        // int num = int.Parse(Console.ReadLine());

        // Console.WriteLine("A tabuada de " + num + " é:");

        //for (int i = 1; i <= 10; i++)
        // {
        //     int result = num * i;

        //     Console.WriteLine($"{num} * {i} = {result}");
        // }





        //4- Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.

        //double potencia(double x,  double y)
        //{
        //    double result = 1;

        //    for (int i = 0; i < Math.Abs(y) ; i++) 
        //    { 
        //        result *= x;
        //    }

        //    if (y < 0) 
        //    {
        //        result = 1 / result;
        //    }
        //    return result;
        //}
        //Console.WriteLine("Digite o valor de x: ");
        //double x = double.Parse(Console.ReadLine());

        //Console.WriteLine("Digite o valor de y: ");
        //double y = double.Parse(Console.ReadLine());

        //double result = potencia(x, y);

        //Console.WriteLine($"O resultado de {x} elevado a {y} é: " + result);





        //5- Escreva um algoritmo para calcular o fatorial de um número.

        //int fatorial(int num)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        //Program programa = new Program();

        //Console.WriteLine("Digite um número para calcular o fatorial: ");
        //int num = int.Parse(Console.ReadLine());

        //int result = fatorial(num);

        //Console.WriteLine($"O fatorial do número {num} é :" + result);





        //6- Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações 
        //aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final (média das notas das avaliações).

        //Console.WriteLine("Digite o número de alunos: ");
        //int alunos = int.Parse(Console.ReadLine());

        //Console.WriteLine("Digite o número de avaliações aplicadas: ");
        //int avaliacoes = int.Parse(Console.ReadLine());

        //for (int i = 1; i <= alunos; i++)
        //{
        //    double somanotas = 0;

        //    for (int j = 1; j <= avaliacoes; j++)
        //    {
        //        Console.WriteLine($"Digite a nota da avaliação {j} para o aluno {i}");
        //        double nota = double.Parse(Console.ReadLine());

        //        somanotas += nota;
        //    }
        //    double media = somanotas / avaliacoes;
        //    Console.WriteLine($"A média do aluno {i} é: {media}");
        //}






        //7- Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por um usuário. Apresente o resultado.

        //int pares = 0;
        //int impares = 0;

        //for (int i = 0; i < 20; i++) 
        //{
        //    Console.WriteLine($"Digite o {i + 1}° número: ");
        //    int num = int.Parse( Console.ReadLine() );

        //    if ( num %2 == 0 )
        //    {
        //        pares++;
        //    } 
        //    else
        //    {
        //        impares++;
        //    }
        //}
        //Console.WriteLine($"A quantidade de números pares é: {pares}");

        //Console.WriteLine($"A quantidade de números ímpares é: {impares}");






        //8- Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
        //(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
        //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

        //Exemplo:
        //Digite um número inteiro positivo: -8
        //Valor incorreto!
        //Digite um número inteiro positivo: 8
        //Numero digitado: 8
        //Números inteiros pares entre 1 e 8: 2, 4, 6.

        //int num;

        //do
        //{
        //    Console.WriteLine("Digite um número inteiro positivo: ");
        //    string input = Console.ReadLine();

        //    if (int.TryParse(input, out num) && num > 0)
        //    {
        //        break;
        //    }
        //    Console.WriteLine("Valor Incorreto!");

        //} while (true);

        //Console.WriteLine($"Número digitado: {num}");
        //Console.WriteLine($"Números inteiros pares entre 1 e {num}: ");

        //for (int i = 2; i <= num; i += 2)
        //{
        //    Console.WriteLine(i + " ");
        //}






        //9- Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
        //informar um outro número. Caso positivo, o programa em VS deve ser repetido.

        //Exemplo:
        //Digite um número inteiro positivo: 8
        //Numero digitado: 8
        //Números inteiros pares entre 1 e 8: 2, 4, 6.

        //Deseja informar outro número(s/ n)? S

        //Digite um número inteiro positivo: 12
        //Numero digitado: 20
        //Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.

        //Deseja informar outro número(s/ n)? N

        //do
        //{
        //    int num;

        //    do
        //    {
        //        Console.WriteLine("Digite um número inteiro positivo: ");
        //        string input = Console.ReadLine();

        //        if (int.TryParse(input, out num) && num > 0)
        //        {
        //            break;
        //        }
        //        Console.WriteLine("Valor Incorreto!");

        //    } while (true);

        //    Console.WriteLine($"Número digitado: {num}");
        //    Console.WriteLine($"Números inteiros pares entre 1 e {num}: ");

        //    for (int i = 2; i <= num; i += 2)
        //    {
        //        Console.WriteLine(i + " ");
        //    }
        //    Console.WriteLine("\nDeseja informar outro número: S / N");
        //} while (Console.ReadLine().ToUpper() == "S");






        //10- Fazer um laço (repetição) que fique solicitando números ao usuário. Se o usuário digitar 0 o programa em VS deve parar
        //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.
        //do
        //{
        //    Console.WriteLine("Digite qualquer número (Ou 0 para sair): ");
        //    double num = double.Parse(Console.ReadLine());

        //    if (num == 0)
        //    {
        //        Console.WriteLine("Programa encerrado.");
        //        break;
        //    }
        //    if (num %2 == 0)
        //    {
        //        Console.WriteLine($"O {num} é par.");
        //    } 
        //    else
        //    {
        //        Console.WriteLine($"O {num} é ímpar.");
        //    }
        //    bool primo = true;

        //    for (int i = 2; i < num; i++)
        //    {
        //        if (num % i == 0) 
        //        { 
        //            primo = false;
        //            break;
        //        }
        //        if (primo)
        //        {
        //            Console.WriteLine($"O número {num} é primo.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"O número {num} não é primo.");
        //        }
        //    }
        //} while (true);







        //11- Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
        //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
        //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
        //escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número de votos em branco. 

        //int votosz = 0;
        //int votosj = 0;
        //int brancos = 0;

        //do
        //{
        //    Console.Clear();

        //    Console.WriteLine("Digite o voto JOAO para votar no candidato Joao; ");
        //    Console.WriteLine("Digite o voto ZECA para votar no candidato Zeca; ");
        //    Console.WriteLine("Digite BRANCO para votar em branco; ");
        //    Console.WriteLine("Digite FIM para terminar a votação. ");

        //    Console.WriteLine("Sua opção é: ");
        //    string voto = Console.ReadLine().ToUpper();

        //    switch (voto)
        //    {
        //        case "JOAO":
        //            votosj++;
        //            break;
        //        case "ZECA":
        //            votosz++;
        //            break;
        //        case "BRANCO":
        //            brancos++;
        //            break;
        //        case "FIM":
        //            Console.WriteLine("Votação Encerrada.");
        //            break;
        //        default:
        //            Console.WriteLine("Opção Inválida.");
        //            break;
        //    }
        //    if (voto == "FIM")
        //    {
        //        break;
        //    }

        //} while (true);


        //Console.WriteLine($"O número de votos no candidato João foram: {votosj}");
        //Console.WriteLine($"O número de votos no candidato Zeca foram: {votosj}");
        //Console.WriteLine($"O número de votos em branco foram: {brancos}");





        //12- Modifique o programa em VS anterior para aceitar votos nulos (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
        //Ao final, informe o nome do candidato vencedor, o número de votos nulos e o número de pessoas que votaram.

        //int votosz = 0;
        //int votosj = 0;
        //int brancos = 0;
        //int nulos = 0;
        //int total = 0;

        //do
        //{
        //    Console.Clear();

        //    Console.WriteLine("Digite o voto JOAO para votar no candidato Joao; ");
        //    Console.WriteLine("Digite o voto ZECA para votar no candidato Zeca; ");
        //    Console.WriteLine("Digite BRANCO para votar em branco; ");
        //    Console.WriteLine("Digite FIM para terminar a votação. ");

        //    Console.WriteLine("Sua opção é: ");
        //    string voto = Console.ReadLine().ToUpper();

        //    switch (voto)
        //    {
        //        case "JOAO":
        //            votosj++;
        //            break;
        //        case "ZECA":
        //            votosz++;
        //            break;
        //        case "BRANCO":
        //            brancos++;
        //            break;
        //        case "NULO":
        //            nulos++;
        //            break;
        //        case "FIM":
        //            Console.WriteLine("Votação Encerrada.");
        //            break;
        //        default:
        //            Console.WriteLine("Opção Inválida.");
        //            break;
        //    }
        //    if (voto == "FIM")
        //    {
        //        break;
        //    }

        //} while (true);


        //Console.WriteLine($"O número de votos no candidato JOAO é: {votosj}");
        //Console.WriteLine($"O número de votos no candidato ZECA é: {votosz}");
        //Console.WriteLine($"O número de votos BRANCO é: {brancos}");
        //Console.WriteLine($"O número de votos NULO é: {nulos}");

        //string vencedor = (votosj > votosz) ? "JOAO" : "ZECA";

        //Console.WriteLine($"O candidato vencedor é: {vencedor}");





        //13- Faça um programa em VS que solicite ao usuário que informe a idade e valide a entrada de dados, 
        //ou seja, repita a leitura até que ela esteja correta(maior do que zero). Ao final, mostre a idade digitada.

        //Console.WriteLine("Informe sua idade: ");
        //int idade = int.Parse(Console.ReadLine());

        //for (int i = 0; i <= idade; i++) 
        //{
        //    Console.WriteLine(i);
        //}




        //14- Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
        //A cada solicitação, teste se o usuário informou um valor válido. 
        //Por exemplo: se o nome não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
        //informe que ele está incorreto e saia do programa em VS.
        //Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
        //informe que está errada e saia.Se estiver correta, solicite o salário.
        //Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
        //Se estiver correto, mostre todos os valores lidos.

        //string resposta;

        //do
        //{
        //    Console.WriteLine("Informe seu nome: ");
        //    string nome = Console.ReadLine();

        //    bool num = false;

        //    foreach (char c in nome)
        //    {
        //        if (char.IsDigit(c))
        //        {
        //            num = true;
        //            break;
        //        }
        //    }
        //    if (string.IsNullOrWhiteSpace(nome) || num)
        //    {
        //        Console.WriteLine("Nome Inválido. Programa encerrado.");
        //        return;
        //    }
        //    Console.WriteLine("Informe sua idade: ");
        //    int idade = int.Parse(Console.ReadLine());

        //    if (idade <= 0 )
        //    {
        //        Console.WriteLine("Idade inválida. Programa encerrado.");
        //        return;
        //    }

        //    Console.WriteLine("Informe o seu salário: ");
        //    double salario = double.Parse(Console.ReadLine());

        //    if (salario <= 0)
        //    {
        //        Console.WriteLine("Salário inválido. Programa encerrado.");
        //        return;
        //    }
        //    Console.Clear();

        //    Console.WriteLine("Suas informações são: ");
        //    Console.WriteLine($"Nome: {nome}");
        //    Console.WriteLine($"Idade: {idade}");
        //    Console.WriteLine($"Salário: {salario}");

        //    Console.WriteLine("Deseja fornecer informações de outra pessoa? S / N ");
        //    resposta = Console.ReadLine();

        //} while (resposta.ToUpper() == "s");







        //15- Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro, solicite - o até que seja.após, informe se ele é par ou impar.
        //Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

        //do
        //{
        //    Console.WriteLine("Digite um número inteiro: ");
        //    string input = (Console.ReadLine());

        //    if (!int.TryParse(input, out int num))
        //    {
        //        Console.WriteLine("Número inválido. Digite um número inteiro.");
        //        continue;
        //    }
        //    if (num %2 == 0 )
        //    {
        //        Console.WriteLine("O número é par.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("O número é ímpar.");
        //    }

        //    Console.WriteLine("Desejar repetir o programa? S / N");
        //    string resposta = Console.ReadLine();

        //    if (resposta.ToLower() != "s")
        //    {
        //        break;
        //    }

        //} while (true);





        //16- Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram o zoológico num determinado dia, imprimindo:
        //Quantas pessoas tem entre 1 e 3 filhos.
        //Quantas pessoas tem entre 4 e 7 filhos.
        //Quantas pessoas tem mais de 8 filhos.
        //Quantas pessoas não tem filhos.

        //int p1a3 = 0;
        //int p4a7 = 0;
        //int p8 = 0;
        //int f0 = 0;

        //for (int i = 0; i < 30; i++)
        //{
        //    Console.WriteLine($"Informe quantos filhos a {i + 1}° pessoa tem: ");
        //    int filhos = int.Parse(Console.ReadLine());

        //    if (filhos == 0)
        //    {
        //        f0++;
        //    }
        //    if (filhos >= 1 && filhos <= 3)
        //    {
        //        p1a3++;
        //    }
        //    if (filhos >= 4 && filhos <= 7)
        //    {
        //        p4a7++;
        //    }
        //    if (filhos >= 8)
        //    {
        //        p8++;
        //    }
        //}
        //Console.WriteLine($"Pessoas com 1 a 3 filhos: {p1a3}");
        //Console.WriteLine($"Pessoas com 4 a 7 filhos: {p4a7}");
        //Console.WriteLine($"Pessoas com mais de 8 filhos: {p8}");
        //Console.WriteLine($"Pessoas sem filhos: {f0}");




        //17- Ler nome, sexo e idade de 50 pessoas e após imprimir:
        //Número de pessoas do sexo masculino.
        //Número de pessoas do sexo feminino.
        //Número de pessoas com idade inferior a 30 anos.
        //Número de pessoas com idade superior a 60 anos.
        //Média de idade das mulheres.

        //int masc = 0;
        //int fem = 0;
        //int idadeinf = 0;
        //int idadesup = 0;
        //int idadefem = 0;

        //for (int i = 0; i < 50; i++)
        //{
        //    Console.WriteLine($"Pessoa {i + 1}");

        //    Console.WriteLine("Informe o nome: ");
        //    string nome = Console.ReadLine();

        //    Console.WriteLine("Informe o sexo: M / F");
        //    char sexo = char.ToUpper(Console.ReadKey().KeyChar);
        //    Console.WriteLine();

        //    Console.WriteLine("Informe a idade: ");
        //    int idade = int.Parse(Console.ReadLine());

        //    if (sexo == 'M')
        //    {
        //        masc++;
        //    }
        //    if (sexo == 'F')
        //    {
        //        fem++;
        //        idadefem += idade;
        //    }
        //    if (idade < 30)
        //    {
        //        idadeinf++;
        //    }
        //    if (idade > 60)
        //    {
        //        idadesup++;
        //    }
        //}
        //    Console.WriteLine("\n Resultados: ");
        //    Console.WriteLine($"Número de pessoas do sexo masculino: {masc}");
        //    Console.WriteLine($"Número de pessoas do sexo feminino: {fem}");
        //    Console.WriteLine($"Número de pessoas com idade inferior a 30 anos: {idadeinf}");
        //    Console.WriteLine($"Número de pessoas com idade superior a 60 anos: {idadesup}");

        //    if (fem > 0)
        //    {
        //        double media = idadefem / fem;
        //        Console.WriteLine($"A média da idade das mulheres é de: {media}");
        //    }







        //18- Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
        //a média aritmética da turma e a quantidade de alunos da turma. Usar - 1 para encerrar a leitura.

        //double notas;
        //double soma = 0;
        //double alta = double.MinValue;
        //double baixa = double.MaxValue;
        //int alunos = 0;

        //Console.WriteLine("Insira a nota dos alunos: (digite -1 para encerrar)");

        //do
        //{
        //    notas = double.Parse(Console.ReadLine());

        //    if (notas == -1)
        //    {
        //        break;
        //    }
        //    soma += notas;
        //    alunos++;

        //    if (notas > alta)
        //    {
        //        alta = notas;
        //    }
        //    if (notas < baixa)
        //    {
        //        baixa = notas;
        //    }
        //} while (true);

        //if (alunos == 0 )
        //{
        //    Console.WriteLine("Nenhuma nota foi inserida");
        //    return;
        //}
        //double media = soma / alunos;

        //Console.WriteLine($"A nota mais alta foi: {alta}");
        //Console.WriteLine($"A nota mais baixa foi: {baixa}");
        //Console.WriteLine($"A média é de: {media}");
        //Console.WriteLine($"A quantidade de alunos é: {alunos}");





        //19- Apresentar o total da soma dos cem primeiros números inteiros.

        //int soma = 0;

        //for (int i = 0; i <= 100; i++)
        //{
        //    soma += i;
        //}
        //Console.WriteLine($"A soma dos 100 primeiros números inteiros é: {soma}");






        //20- Elaborar um programa que apresente o somatório dos valores pares existentes 
        //entre 1 e 500.

        //int soma = 0;

        //for (int i = 0; i <= 500; i++)
        //{
        //    if (i %2 == 0)
        //    {
        //        soma += i;
        //    } 
        //}
        //Console.WriteLine($"A soma dos valores pares entre 1 e 500 é: {soma}");





        //21- Mostrar as potências de 2 variando de 0 a 10.

        //for (int i = 0; i <= 10; i++)
        //{
        //    double potencia = Math.Pow(2, i);
        //    Console.WriteLine($"2^{i} = {potencia}");
        //}






        //22- Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
        //ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. Considerar nota 7,0 como mínima para aprovação.

        //Console.WriteLine("Digite as 4 notas do aluno (separe por espaço): ");
        //string[] notasStr = Console.ReadLine().Split(' ');

        //double[] notas = new double[4];

        //for (int i = 0; i < 4; i++)
        //{
        //    notas[i] = double.Parse(notasStr[i]);
        //}

        //double media = (notas[0] * 2 + notas[1] * 1 + notas[2] * 2 + notas[3] * 4) / 9;

        //if (media >= 7.0)
        //{
        //    Console.WriteLine($"Sua média é de: {media:F1}. Parabéns, você foi aprovado!");
        //}
        //else
        //{
        //    Console.WriteLine($"Sua média é de: {media:F1}. Infelizmente você foi reprovado.");
        //}






        //23- Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da multiplicação sucessiva de N por 3 enquanto o produto for menor que 250
        //(N * 3; N * 3 * 3; N * 3 * 3 * 3; etc).

        //Console.WriteLine("Digite qualquer número menor ou igual a 50: ");
        //int num = int.Parse(Console.ReadLine());

        //if (num > 50)
        //{
        //    Console.WriteLine("Número inválido. Por favor digite um número MENOR ou IGUAL a 50.");
        //    return;
        //}
        //int produto = num;
        //int cont = 1;

        //do
        //{
        //    Console.WriteLine($"Iteração {cont}: {produto}");
        //    produto *= 3;
        //    cont++;

        //} while (produto < 250 );





        //24- Apresentar os quadrados dos números inteiros de 15 a 200.

        //for (int i = 15; i <= 200; i++)
        //{
        //    int quadrado = i * i;

        //    Console.WriteLine($"O quadrado de {i} é {quadrado}");
        //}







        //25- Elaborar um programa que apresente o valor de uma potência de uma base qualquer elevada a um expoente qualquer, ou seja, NM.

        //Console.WriteLine("Digite um valor para a base: ");
        //double numbase = double.Parse(Console.ReadLine());

        //Console.WriteLine("Digite um valor do expoente: ");
        //int expo = int.Parse(Console.ReadLine());

        //double result = 1;

        //for (int i = 0; i < expo; i++)
        //{
        //    result *= numbase;
        //}
        //Console.WriteLine($"O resultado de {numbase}^{expo} é: {result}");







        //26- A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o salário e número de filhos.A prefeitura deseja saber:

        //a) média do salário da população;
        //b) média do número de filhos;
        //c) maior salário;
        //d) percentual de pessoas com salário até R$ 100,00.
        //O final da leitura de dados se dará com a entrada de um salário negativo.

        //double somasalario = 0;
        //int somafilhos = 0;
        //int pessoas = 0;
        //int pessoas100 = 0;
        //double maiorsalario = double.MinValue;

        //do
        //{
        //    Console.WriteLine("Digite o valor do salário (Ou um número negativo para encerrar o programa): ");
        //    double salario = double.Parse(Console.ReadLine());

        //    if (salario < 0)
        //    {
        //        break;
        //    }
        //    Console.WriteLine("Digite o número de filhos: ");
        //    int filhos = int.Parse(Console.ReadLine());

        //    somasalario += salario;
        //    somafilhos += filhos;
        //    pessoas++;

        //    if (salario > maiorsalario)
        //    {
        //        maiorsalario = salario;
        //    }
        //    if (salario <= 100)
        //    {
        //        pessoas100++;
        //    }
        //} while (true);

        //if (pessoas > 0)
        //{
        //    double mediasalario = somasalario / pessoas;
        //    double mediafilhos = (double)somafilhos / pessoas;
        //    double percentpessoas = ((double)pessoas100 / pessoas) * 100;

        //    Console.WriteLine($"Média do salario das pessoas: {mediasalario:C}");
        //    Console.WriteLine($"Média do número de filhos: {mediafilhos:F}");
        //    Console.WriteLine($"Maior salário: {maiorsalario:C}");
        //    Console.WriteLine($"Percentual de pessoas com o salário de até R$100,00: {percentpessoas:F}% ");
        //}
        //else
        //{
        //    Console.WriteLine("Não foi inserido nenhum dado.");
        //}





        //27- Foi realizada uma pesquisa de algumas características físicas da população de uma certa região, a qual coletou os seguintes dados referentes a cada habitante para
        //serem analisados:
        //-sexo(masculino e feminino)
        //- cor dos olhos(azuis, verdes ou castanhos)
        //-cor dos cabelos(louros, castanhos, pretos)
        //-idade

        //Faça um algoritmo que determine e escreva:

        //-a maior idade dos habitantes
        //-a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
        //e que tenham olhos verdes e cabelos louros.
        //O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

        //int sexo;
        //int maiorIdade = 0, idade;
        //int corOlhos; //0 = azul, 1 = verde, 2 = castanhos
        //int corCabelo; //0 = loiro, 1 = castanho, 2 = preto
        //int op = -1;
        //int contagem = 0;

        //do
        //{
        //    Console.WriteLine("CADASTRO DE INDIVÍDUOS");
        //    Console.WriteLine("Digite o sexo da pessoa (0 - feminino e 1 para Masculino) : ");
        //    sexo = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite a cor dos olhos (0 = azul, 1 = verde, 2 = castanhos):");
        //    corOlhos = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite a cor dos cabelos 0 = loiro, 1 = castanho, 2 = preto:");
        //    corCabelo = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite a idade:");
        //    idade = int.Parse(Console.ReadLine());

        //    if (idade > maiorIdade)
        //    {
        //        maiorIdade = idade;
        //    }

        //    if (sexo == 0 && (idade > 18 && idade < 35)
        //        && corOlhos == 1 && corCabelo == 0)
        //    {
        //        contagem++;
        //    }

        //    Console.WriteLine("Informe -1 para encerrar ou quqlquer outro valor para continuar");
        //    op = int.Parse(Console.ReadLine());

        //} while (op != -1);


        //Console.WriteLine("A pessoa mais velha possui " +
        //    maiorIdade + " anos e existem " + contagem +
        //    " mulheres com idade entre 18 e 35 com olhos " +
        //    "verdes e cabelos louros.");






    }
}