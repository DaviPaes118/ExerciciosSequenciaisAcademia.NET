
namespace ListaExerciciosSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1- Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            //Área do triangulo = (base * altura) / 2; Teste se a base ou a altura digitada não foi igual a zero.

            //Console.WriteLine("Digite o valor da base: ");
            //double b = double.Parse(Console.ReadLine());

            //if (b <= 0)
            //{
            //    Console.WriteLine("Não é possível realizar essa operação.");

            //}
            //else
            //{
            //    Console.WriteLine("Digite o valor da altura: ");
            //    double h = double.Parse(Console.ReadLine());

            //    if (h <= 0)
            //    {
            //        Console.WriteLine("Não é possível realizar essa operação.");
            //    }
            //    else
            //    {
            //        double area = (b * h) / 2;

            //        Console.WriteLine("A area do triângulo é de: " + area);
            //    }
            //}



            //2- Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.

            //Console.WriteLine("Digite um número: ");
            //double num = double.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("O número é par");

            //}
            //else
            //{
            //    Console.WriteLine("O número é ímpar.");
            //}


            //3- Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

            //Console.WriteLine("Digite o primeiro valor: ");
            //int v1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo valor: ");
            //int v2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o terceiro valor: ");
            //int v3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o quarto valor: ");
            //int v4 = int.Parse(Console.ReadLine());

            //double media = (v1 + v2 + v3 + v4) / 4;
            //Console.WriteLine("O valor da média é: " + media);

            //Console.WriteLine("Os valores acima da média são: ");

            //if (media < v1) { Console.WriteLine(v1); }

            //if (media < v2) { Console.WriteLine(v2); }

            //if (media < v3) { Console.WriteLine(v3); }

            //if (media < v4) { Console.WriteLine(v4); }



            //4- Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
            //Mostrar na tela qual dos professores tem o maior salário total.

            //    Console.WriteLine("Digite as horas do primeiro professor: ");
            //    int hr1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Informe o valor recebido por hora pelo primeiro professor: ");
            //    double vh1 = double.Parse(Console.ReadLine());

            //    double salario1 = hr1 * vh1;

            //    Console.WriteLine("Digite as horas do segundo professor: ");
            //    int hr2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Informe o valor recebido por hora do segundo professor: ");
            //    double vh2 = double.Parse(Console.ReadLine());

            //    double salario2 = hr2 * vh2;

            //    if (salario1 > salario2) { Console.WriteLine("O salário do primeiro professor é maior com o valor de: R$" + salario1); }

            //    else { Console.WriteLine("O salário do segundo professor é maior com o valor de: R$" + salario2); }
            //}




            //5- Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” se a média das duas notas for maior ou igual a 7, 0.
            //Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final, é a média entre a nota do exame e a média das 2 notas.
            //Se esta média final for maior ou igual a 5, 0, o programa deve escrever “Aprovado”, caso contrário deve escrever “Reprovado”.

            //Console.WriteLine("Digite sua primeira nota: ");
            //double nota1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite sua segunda nota: ");
            //double nota2 = int.Parse(Console.ReadLine());

            //double media = (nota1 + nota2) / 2;

            //Console.WriteLine("Sua média foi de: " + media);

            //if (media > 7.0) { Console.WriteLine("Parabéns, você foi aprovado."); }

            //else
            //{
            //    Console.WriteLine("Digite sua nota do exame: ");
            //    double notaexame = double.Parse(Console.ReadLine());

            //    double mediafinal = (notaexame + media) / 2;

            //    if (mediafinal > 5.0) { Console.WriteLine("Parabéns, você foi aprovado."); }

            //    else { Console.WriteLine("Infelizmente, você foi reprovado."); }


            //}




            //6- Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
            //O programa deve calcular o Indice de Massa Corpórea(IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
            //O cálculo do imc = peso / (altura * altura)

            //IMC
            //menor que 18->baixo peso
            //maior que 18 e menor que 25->peso normal
            //maior que 25 e menor que 30->sobrepeso
            //maior que 30 e menor que 35->obesidade
            //maior que 35->obesidade grau sério

            //Console.WriteLine("Digite o seu nome: ");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Informe sua altura em cm: ");
            //double altura = double.Parse(Console.ReadLine());
            //double metros = altura / 100;

            //Console.WriteLine("Informe seu peso em Kg: ");
            //double peso = double.Parse(Console.ReadLine());

            //double imc = peso / (metros * metros);

            //Console.WriteLine("Sua ficha: ");
            //Console.WriteLine("Nome: " + nome.ToUpper());
            //Console.WriteLine("Altura: " + metros);
            //Console.WriteLine("Peso: " + peso);
            //Console.WriteLine("IMC: " + imc);

            //Console.WriteLine("\nResultado: ");

            //if (imc < 18) { Console.WriteLine("Você está abaixo do peso."); }

            //if (imc > 18 && imc < 25 )
            //{ Console.WriteLine("Você está com o peso normal."); }

            //if (imc > 25 && imc < 30)
            //{ Console.WriteLine("Você está com sobrepeso."); }

            //if (imc > 30 && imc < 35) 
            //{ Console.WriteLine("Você está com obesidade."); }

            //if (imc > 35) 
            //{ Console.WriteLine("Você está com obesidade de grau sério."); }




            //7- Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            //O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            //exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase.

            //Console.WriteLine("Digite um frase: ");
            //string frase = (Console.ReadLine());

            //Console.WriteLine("Digite uma palavra para pesquisar: ");
            //string palavra = (Console.ReadLine());

            //if (frase.Contains(palavra)) 
            //{
            //    Console.WriteLine("A palavra " + palavra + " está contida na frase digita");

            //} else { Console.WriteLine("A palavra não está contida na frase digitada."); }




            //8- Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            //Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5 % do total de vendas.
            //Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7 % do total de vendas.
            //E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10 % do total de vendas.

            //Console.WriteLine("Digite o seu nome: ");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Digite o seu código: ");
            //int cod = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o seu salário base: ");
            //double salariobase = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor total de suas vendas: ");
            //double totalvendas = double.Parse(Console.ReadLine());

            //if (totalvendas > 500 && totalvendas < 1000)
            //{

            //    double salariofinal = salariobase + (totalvendas * 5 / 100);
            //    Console.WriteLine("Seu salário final será de R$" + salariofinal);
            //}

            //if (totalvendas > 1000 && totalvendas < 5000)
            //{
            //    double salariofinal = salariobase + (totalvendas * 7 / 100);
            //    Console.WriteLine("Seu salário final será de R$" + salariofinal);
            //}

            //if (totalvendas > 5000)
            //{

            //    double salariofinal = salariobase + (totalvendas * 10 / 100);
            //    Console.WriteLine("Seu salário final será de R$" + salariofinal);

            //}





            //9- Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            //diária de um paciente diabético.Para cada valor recebido analisar e informar ao paciente o seguinte:
            //Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia
            //Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.
            //Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
            //menor que 80, avisá - lo que é preciso diminuir 2 unidades de insulina.Se a média for maior que
            //150, avisá - lo que será necessário adicionar 2 unidades de insulina.

            //Console.WriteLine("Informe o primeiro valor: ");
            //int v1 = int.Parse(Console.ReadLine());

            //if (v1 < 65)
            //{
            //    Console.WriteLine("Alerta de hipoglicemia!");
            //}
            //else
            //{
            //    if (v1 > 250) { Console.WriteLine("Alerta de hiperglicemia!"); }
            //}

            //Console.WriteLine("Informe o segundo valor: ");
            //int v2 = int.Parse(Console.ReadLine());

            //if (v2 < 65)
            //{
            //    Console.WriteLine("Alerta de hipoglicemia!");

            //}
            //else
            //{
            //    if (v2 > 250) { Console.WriteLine("Alerta de hiperglicemia!"); }
            //}

            //Console.WriteLine("Informe o terceiro valor: ");
            //int v3 = int.Parse(Console.ReadLine());

            //if (v3 < 65)
            //{
            //    Console.WriteLine("Alerta de hipoglicemia!");

            //}
            //else
            //{
            //    if (v3 > 250) { Console.WriteLine("Alerta de hiperglicemia"); }
            //}

            //double media = (v1 + v2 + v3) / 3;
            //Console.WriteLine("Sua média é de: " + media);

            //if (media < 80)
            //{
            //    Console.WriteLine("Deverá ser diminuído duas unidades de insulina.");
            //}
            //else

            //{
            //    if (media > 150) { Console.WriteLine("Deve ser adicionado duas unidades de insulina."); }
            //}




            //10- Faça um programa no VS que receba dados de dois atletas (nome, idade e altura). O programa deve mostrar os dados do atleta mais novo e mais alto.

            //Console.WriteLine("Digite o seu nome: ");
            //string nome1 = Console.ReadLine();

            //Console.WriteLine("Informe sua idade: ");
            //int idade1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe sua altura em metros: ");
            //double altura1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o seu nome: ");
            //string nome2 = Console.ReadLine();

            //Console.WriteLine("Informe sua idade: ");
            //int idade2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informa sua altura: ");
            //double altura2 = double.Parse(Console.ReadLine());

            //if (idade1 > idade2) { Console.WriteLine("O atleta 2 é mais novo."); } else { Console.WriteLine("O atleta 1 é mais novo."); }

            //if (altura1 > altura2) { Console.WriteLine("O atleta 1 é mais alto."); } else { Console.WriteLine("O atleta 2 é mais alto."); }



            //11- Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
            //O programa deve exibir se a hora digitada está ou não válida. Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

            // Console.WriteLine("Digite a hora: ");
            // int hora = int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite os minutos: ");
            // int minutos = int.Parse(Console.ReadLine());

            //if  (hora >= 0 && hora <= 23 && minutos >= 0 && minutos <=59) 
            // {
            //     Console.WriteLine("A hora " + hora + ":" + minutos + " é válida.");
            // } else { Console.WriteLine("A hora " + hora + ":" + minutos + " não é válida."); }




            //12- Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
            //número de horas trabalhadas de um operário.Na sequência, calcule o salário sabendo - se que ele ganha
            //R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento
            //armazenando - o na variável "extra", caso contrário zerar tal variável.A hora excedente de trabalho vale R$ 20,00.
            //No final do processamento, exibir o salário total e o salário excedente do operário.

            //Console.WriteLine("Digite o seu código: ");
            //int codigo = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite suas horas trabalhadas: ");
            //int numerohoras = int.Parse(Console.ReadLine());

            //int valorhora = 10;
            //int valorhoraextra = 20;
            //int horaextra = 0;

            //int salariofinal = numerohoras * valorhora;

            //if (horaextra > 50)
            //{
            //    horaextra = numerohoras - 50;
            //    salariofinal += horaextra * valorhoraextra;

            //}

            //Console.WriteLine("O seu código é: " + codigo);
            //Console.WriteLine("Horas trabalhadas: " + numerohoras);
            //Console.WriteLine("Seu salário base é: " + salariofinal);
            //Console.WriteLine("Seu salário com o pagamento de extras será de: R$" + salariofinal+(horaextra * valorhoraextra));



            //13- Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
            //seu peso ideal, utilizando as seguintes fórmulas:
            //Para homens: (72.7 * h) - 58
            //Para mulheres: (62.1 * h) - 44.7

            //Console.WriteLine("Informe sua altura em metros: ");
            //double h = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o seu gênero: F / M? ");
            //char genero = char.Parse(Console.ReadLine());

            //double pesoideal;

            //if (genero == 'M' || genero =='m') {

            //    pesoideal = (72.7 * h) - 58;

            //} else if (genero == 'F' ||  (genero =='f') )
            //{
            //    pesoideal = (62.1 * h) - 44.7;
            //}
            //else { Console.WriteLine("Por favor, digite apenas uma das opções mostradas anteriormente."); return; }

            //Console.WriteLine("Peso ideal: " + pesoideal.ToString("0.00") + " kg");


            //14- Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
            //link de Internet(em Mbps).Em seguida, calcule e informe o tempo aproximado de download do arquivo usando este link(em minutos).

            //Console.WriteLine("Informe o tamanho do arquivo em MB: ");
            //double arquivo = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe a velocidade da internet em Mbps: ");
            //double velocidade = double.Parse(Console.ReadLine());

            //double segundos = velocidade / 8;
            //double tempo = arquivo / segundos;

            //double minutos = tempo / 60;

            //Console.WriteLine("Tempo aproximado do download: " + minutos.ToString("0.00") + " minutos") ;



            //15- Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
            //da área a ser pintada.Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
            //e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

            //Console.WriteLine("Informe o tamanho da area a ser pintada em m2: ");
            //double area = double.Parse(Console.ReadLine());

            //double litro = area / 3;

            //int lata = (int)Math.Ceiling(litro / 18);
            //double precototal = lata * 80;

            //if (litro % 18 != 0) { lata++; precototal += 80; }

            //Console.WriteLine("A quantidade necessária de latas será de: " + lata);
            //Console.WriteLine("O valor total gasto será de: " + precototal.ToString("0.00"));




            //16- Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
            //na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase.Caso contrário, mostre uma mensagem indicando que os dois times irão se
            //enfrentar novamente em um novo jogo.
            //ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
            //ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
            //plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.

            //Console.WriteLine("Digite a pontuação do time da casa: ");
            //int casa = int.Parse(Console.ReadLine());

            //Console.WriteLine("Difite a pontuação do time de fora: ");
            //int fora = int.Parse(Console.ReadLine());

            //if (fora - casa >=2) { Console.WriteLine("O time de fora já se classificou."); }
            //else if (fora - casa < 2) { Console.WriteLine("Os dois times irão se enfrentar novamente em um novo jogo."); }



            //17- Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
            //formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero(todos
            //os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

            //Console.WriteLine("Digite o valor do lado A: ");
            //double a = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor do lado B: ");
            //double b = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor do lado C: ");
            //double c = double.Parse(Console.ReadLine());

            //if (a + b > c && a + c > b && b + c > a)
            //{
            //    if (a == b && b == c)
            //    {
            //        Console.WriteLine("É um triângulo equilátero.");
            //    }
            //    else if (a == b || b == c) { Console.WriteLine("É um triângulo isósceles."); }

            //    else { Console.WriteLine("É um triângulo escaleno."); }
            //}
            //else { Console.WriteLine("Não é possível formar um triângulo."); }





            //18- Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

            //Console.WriteLine("Digite o primeiro valor: ");
            //double v1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo valor: ");
            //double v2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o terceiro valor: ");
            //double v3 = double.Parse(Console.ReadLine());

            //if (v1 > v2 && v1 > v3) { Console.WriteLine("O primeiro valor é o maior."); }

            //else if (v2 > v3 && v2 > v1) { Console.WriteLine("O segundo valor é o maior."); }

            //else
            //{
            //    Console.WriteLine("O terceiro valor é o maior.");
            //}



            //19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

            //Console.WriteLine("Digite o primeiro valor: ");
            //double v1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo valor: ");
            //double v2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o terceiro valor: ");
            //double v3 = double.Parse(Console.ReadLine());

            //double menor = 0, meio = 0, maior = 0;

            //if (v1 > v2 && v1 > v3)
            //{
            //    maior = v1;
            //    if (v2 > v3)
            //    {
            //        meio = v2;
            //        menor = v3;
            //    }
            //    else
            //    {
            //        meio = v3;
            //        menor = v2;
            //    }
            //}
            //if (v2 > v3 && v2 > v1)
            //{
            //    maior = v2;
            //    if (v3 > v1)
            //    {
            //        meio = v3;
            //        menor = v1;
            //    }
            //    else
            //    {
            //        meio = v1;
            //        menor = v3;
            //    }
            //}
            //if (v3 > v1 && v3 > v2)
            //{
            //    maior = v3;
            //    if (v1 > v2)
            //    {
            //        meio = v1;
            //        menor = v2;
            //    }
            //    else
            //    {
            //        meio = v2;
            //        menor = v1;
            //    }
            //}

            //Console.WriteLine("A ordem crescente do menor para o maior é: " + menor + ", " + meio + ", " + maior);





            //20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
            //plus: você pode gerar o número de forma randomica(função random c#).

            //Random random = new Random();
            //int numsecreto = random.Next(1, 10);
            //int tentativas = 3;

            //Console.WriteLine("Bem vindo ao jogo de adivinhação!");
            //Console.WriteLine("\nVocê tem 3 chances para adivinhar o número secreto!");

            //for (int i = 1; i <= tentativas; i++)
            //{
            //    Console.WriteLine($"Tentativa {i}");
            //    Console.WriteLine("Digite seu palpite: ");
            //    int palpite = int.Parse(Console.ReadLine());

            //    if (palpite == numsecreto) { Console.WriteLine("Parabéns!! Você acertou o número secreto!"); return; }

            //    else if (palpite < numsecreto) { Console.WriteLine("O número secreto é maior!"); }

            //    else { Console.WriteLine("O número secreto é menor."); }
            //}
            //Console.WriteLine("Infelizmente você usou todas as tentativas :(");
            //Console.WriteLine("O número secreto era: " + numsecreto);




            //21- Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés) e uma unidade de 
            //medida de saída usando um menu com o comando switch case.O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse
            //valor para a unidade de saída selecionada.

            //int opin, opout, unin =0, unout = 0;
            //double valorini = 0, valorfim = 0;

            //Console.WriteLine("Para qual unidade deseja converter? ");
            //Console.Write("De (1) Metros, (2) Centímetros, (3) Polegadas, (4) Pés: ");
            //opin = int.Parse(Console.ReadLine());

            //switch (opin)
            //{
            //    case 1:
            //        unin = 1;
            //        break;
            //    case 2:
            //        unin = 2;
            //        break;
            //    case 3:
            //        unin = 3;
            //        break;
            //    case 4:
            //        unin = 4;
            //        break;
            //}

            //Console.Write("Para (1) Metros, (2) Centímetros, (3) Polegadas, (4) Pés: ");
            //opout = int.Parse(Console.ReadLine());

            //Console.Write("Qual valor deseja converter? ");
            //valorini = double.Parse(Console.ReadLine());

            //Console.Clear();

            //switch (opout)
            //{
            //    case 1:
            //        if (opin == 2) { valorfim = valorini * 100; }
            //        if (opin == 3) { valorfim = valorini / 39.37; }
            //        if (opin == 4) { valorfim = valorini / 3.281; }
            //        unout = 1;
            //        break;
            //    case 2:
            //        if (opin == 1) { valorfim = valorini / 100; }
            //        if (opin == 3) { valorfim = (valorini * 100) / 39.37; }
            //        if (opin == 4) { valorfim = (valorini * 100) / 3.281; }
            //        unout = 2;
            //        break;
            //    case 3:
            //        if (opin == 1) { valorfim = valorini / 39.37; }
            //        if (opin == 2) { valorfim = (valorini * 100) / 39.37; }
            //        if (opin == 4) { valorfim = valorini / 12; }
            //        unout = 3;
            //        break;
            //    case 4:
            //        if (opin == 1) { valorfim = valorini / 3.281; }
            //        if (opin == 2) { valorfim = valorini * 30.48; }
            //        if (opin == 3) { valorfim = valorini * 12; }
            //        unout = 4;
            //        break;

            //    default:
            //        Console.WriteLine("Opção inválida!");
            //        valorfim = 0;
            //        break;
            //}
            //Console.WriteLine($"{valorini} {unin} para {unout} = {valorfim}");
        }
        

    }
}



