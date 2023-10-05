using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace ListadeExercicios1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            // int v1, v2;
            // float media;
            // Console.WriteLine("Digite um Valor: ");
            // v1 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Digite um segundo valor: ");
            // v2 = int.Parse(Console.ReadLine());
            // media = (v1 + v2) / 2;
            // Console.WriteLine("Sua média é: " + media);



            //2- Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

            //int v1, v2, v3, v4;
            //float media;
            //Console.WriteLine("Digite o primeiro valor: ");
            //v1= int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo valor: ");
            //v2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro valor: ");
            //v3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o quarto valor: ");
            //v4 = int.Parse(Console.ReadLine());
            //media = (v1 + v2 + v3 + v4)/4;
            //Console.WriteLine("Sua média é: " + media);



            //3- Escreva a sequência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
            // si os valores de duas variáveis A e B.

            //int a =9, b =10;
            //int tmp = a;
            //a = b;
            //b = tmp;



            //4 - Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            //forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            //Console.WriteLine("Digite uma data DD/MM/AAAA: ");
            //DateOnly data = DateOnly.Parse(Console.ReadLine());
            //Console.WriteLine("Convertendo a data para os seguintes formatos: ");
            //Console.WriteLine("AAAA/MM/DD: " + data.Year + "/" + data.Month.ToString("D2") + "/" + data.Day.ToString("D2"));
            //Console.WriteLine("AA/MM/DD: " + data.Year.ToString().Substring(2) + "/" + data.Month.ToString("D2") + "/" + data.Day.ToString("D2"));



            //5 -Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel (medido em Km / l), sendo que são conhecidos a distância total percorrida
            //e o volume de combustível consumido para percorrê-la(medido em l).

            //Console.WriteLine("Digite quantos KM foram percorridos: ");
            //double distancia = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite quantos litros foram gastos no total durante o percurso: ");
            //double consumo = double.Parse(Console.ReadLine());
            //double consumomedio = (distancia + consumo) / 2;
            //Console.WriteLine("Seu consumo médio foi de: " + consumomedio + "Km/l");




            // 6 -Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            //isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem de IPI(única) a ser acrescentada.

            //Console.WriteLine("Parafuso A: ");
            //Console.WriteLine("Digite o código do produto: ");
            //int codigoA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual a quantidade de peças? ");
            //int qtdA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor unitário: R$");
            //double valorA = double.Parse(Console.ReadLine());
            //Console.WriteLine("Informe a porcentagem de IPI dos produtos: ");
            //double IPIA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Parafuso B: ");
            //Console.WriteLine("Digite o código do produto: ");
            //int codigoB = int.Parse(Console.ReadLine());
            //Console.WriteLine("Qual a quantidade de peças? ");
            //int qtdB = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor unitário: R$");
            //double valorB = double.Parse(Console.ReadLine());
            //Console.WriteLine("Informe a porcentagem de IPI dos produtos: ");
            //double IPIB = double.Parse(Console.ReadLine());

            //Console.WriteLine("Resultado final: ");
            //Console.WriteLine($"Parafuso A - Código: {codigoA}, Quantidade: {qtdA}, Valor Unitário: R${valorA}, Porcentagem do IPI: {IPIA}%");
            //Console.WriteLine($"Parafuso B - Código: {codigoB}, Quantidade: {qtdB}, Valor Unitário: R${valorB}, Porcentagem do IPI: {IPIB}%");



            //7 - Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            //o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. Calcule o salário total do vendedor.Escreva o número do vendedor e o salário 
            //total do vendedor. 

            //Console.WriteLine("Informe seu nome: ");
            //string nome = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Digite seu número: ");
            //int numero = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o seu salário em BRL: ");
            //double salario = double.Parse(Console.ReadLine());
            //Console.WriteLine("Informe seu total de vendas: ");
            //int totalvendas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Informe a sua porcentagem de comissão: ");
            //double percentcomissao = double.Parse(Console.ReadLine());

            //double comissaofinal = totalvendas * (percentcomissao / 100);
            //double salariofinal = salario + comissaofinal;

            //Console.WriteLine("Número do vendedor: " + numero);
            //Console.WriteLine("Seu salário total é de: R$ " + salariofinal);




            //8 - Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. A fórmula da conversão é F = (9 * C + 160) / 5.

            //Console.WriteLine("Informe a temperatura em °C: ");
            //double celsius = double.Parse(Console.ReadLine());
            //double F = (9 * celsius + 160) / 5;
            //Console.WriteLine("Essa temperatura convertida em °F é: " + F + "°F");





            //9 - Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
            //do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
            //Por exemplo, se o valor da mercadoria for R$ 270, 00, a entrada e as duas prestações são iguais a R$ 90, 00;
            //se o valor da mercadoria for R$ 302, 75 a entrada é de R$ 102, 75 e as duas prestações são iguais a R$ 100, 00.
            //Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            //da entrada e das duas prestações, de acordo com as regras acima.
            //Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o
            //conseqüente pagamento dos boletos das duas prestações.

            //Console.WriteLine("Digite o valor da mercadoria desejada: R$");
            //double valormercadoria = double.Parse(Console.ReadLine());

            //double resto = valormercadoria % 3;
            //double parcelas = (valormercadoria - resto) / 3; 
            //double entrada = parcelas + resto;

            //Console.WriteLine("Valor da entrada: R$" + entrada);
            //Console.WriteLine("Valor das parcelas: R$" + parcelas);




            //10 -  Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
            //para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
            //realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as
            //notas de menor valor fossem distribuídas em número mínimo possível.
            //Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            //uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
            //Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas
            //de acordo com o critério da “distribuição ótima”.

            //Console.WriteLine("Digite o valor que deseja retirar: R$");
            //int valor = int.Parse(Console.ReadLine());

            //int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
            //int[] qtdnotas = new int[notas.Length];

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    qtdnotas[i] = valor / notas[i];
            //    valor = valor % notas[i];

            //}
            //Console.WriteLine("A Distribuição de notas vai ficar da seguinte forma: ");

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    if (qtdnotas[i] > 0) ;
            //}

            //for (int i = 0; i < notas.Length; i++)
            //{

            //    Console.WriteLine($"{qtdnotas[i]} nota(s) de R${notas[i]},00");

            //}



            //11 - Escreva um algoritmo para ler o número de eleitores de um município, 
            //o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

            //Console.WriteLine("Digite o número total de eleitores: ");
            //int eleitores = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o número de votos brancos: ");
            //int vb = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o número de votos nulos: ");
            //int vn = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o número de votos válidos: ");
            //int validos = int.Parse(Console.ReadLine());

            //double percentbrancos = ((double)vb / eleitores   * 100);
            //double percentnulo = ((double)vn / eleitores * 100);
            //double percentvalido = ((double)validos / eleitores * 100);

            //Console.WriteLine("Os resultados serão: ");
            //Console.WriteLine("Total de eleitores: " + eleitores);
            //Console.WriteLine("Porcentagem de votos brancos: " + percentbrancos + "%");
            //Console.WriteLine("Porcentagem de votos nulo: " + percentnulo + "%");
            //Console.WriteLine("Percent de votos válidos: " + percentvalido + "%");



            //12- Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
            //marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido
            //dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.

            //Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia

            //Média do consumo = Total quilometragem / quantidade de combustível gasto

            //Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)


            //double valorcombustivel = 6.90;

            //Console.WriteLine("Informe a marcação do odômetro no início: ");
            //double odometroi = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe a marcação do odômetro no final: ");
            //double odometrof = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe quantos litros de combustível foram gastos: ");
            //double litrosgastos = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe qual o valor total recebido hoje: ");
            //double valortotal = double.Parse(Console.ReadLine());

            //double kmtotal = odometrof - odometroi;
            //double consumomedio = kmtotal / litrosgastos;
            //double lucroliquido = valortotal - (litrosgastos * valorcombustivel);

            //Console.WriteLine("Seus resultados são de: ");
            //Console.WriteLine("Consumo médio: " + consumomedio + "km/l");
            //Console.WriteLine("Lucro líquido: R$" + lucroliquido);



            //13 - Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
            // preço de custo de cada bicicleta vendida.Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
            //vendidas pelo vendedor, calcule e mostre: o salário do empregado

            //Console.WriteLine("Informe o valor do Salário Mínimo: ");
            //double salariomin = double.Parse(Console.ReadLine());

            //Console.WriteLine("Informe quantas bicicletas foram vendidas: ");
            //int qtdbike = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor de custo de cada Bicicleta: ");
            //double custobike = double.Parse(Console.ReadLine());

            //double valorbike = custobike * 1.5;
            //double comissao = qtdbike * custobike * 0.15;

            //double salariofinal = (2 * salariomin) + comissao;

            //Console.WriteLine("Informações: ");
            //Console.WriteLine("Valor do salário mínimo: " + salariomin);
            //Console.WriteLine("Quantidade de bicicletas vendidas: " + qtdbike);
            //Console.WriteLine("Preço de custo das bicicletas: R$" + custobike);
            //Console.WriteLine("Salário que o vendedor vai receber: R$" + salariofinal);

        }
    }
}