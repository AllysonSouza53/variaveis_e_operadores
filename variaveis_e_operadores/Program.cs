using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveis_e_operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*variaveis são espaços que definimos na memória (flash) para gardar informações
             existem alguns tipos de variaveis, cada uma definindo seu tamanho/capacidade de armazenamento
             e tipo de dado. Nessa aula usaremos:
             .string: para caracteres e letras
             .Int: para numeros inteiros
             .Double: para numeros decimais
            
             Operadores:
             ."=": o igual é o operador que impoe um valor a alguma variavel
             ."+": é o operador de soma e tambem usado na concatenação da saida
             ."-": é o operador de subtração
             ."*": é o operador de multiplicação
             ."/": é o operador de divisão
             
             

             */

            //----------------------------------------------------------------------------------------//

            /*String nome;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("O nome digitado é:" + nome);
            Console.ReadKey();*/

            //---------------------------------------------------------------------------------------//

            /*
            //Definição das variáveis e entrada de dados
            
            Console.WriteLine("digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            //Criação de variável "resultado" e processamento

            int resultado = n1+ n2;

            //Saida

            Console.WriteLine("o resultado de operação é: " + resultado);

            //encerra o prgrama
            Console.ReadKey();*/

            //----------------------------------------------------------------------------------------//

            //Definição das variáveis e entrada de dados
            //Console.WriteLine("Qual o valor do combustivel: ");
            //double vc=double.Parse(Console.ReadLine());
            //Console.WriteLine("Qual a distancia percorrida em Kilometros: ");
            //double dp=double.Parse(Console.ReadLine());
            //Console.WriteLine("Quantos Kilometros o veiculo anda por litro (Km/l): ");    
            //double kml=double.Parse(Console.ReadLine());

            //Processamento

            //double r = (dp/kml)*vc; 

            //Saída

            //Console.WriteLine("O total gasto na viagem foi de: R$" + r);

            //Finalização do programa
            //Console.ReadKey(); 

            //--------------------------------------------------------------------------------//

            ////Declaração de variáveis

            //int ano, mes, dia, t;

            ////Entrada

            //Console.WriteLine("Quantos anos de vida tu tem: ");
            //ano = int.Parse(Console.ReadLine());
            //Console.WriteLine("Quantos meses de vida tu tem: ");
            //mes = int.Parse(Console.ReadLine());
            //Console.WriteLine("Quantos dias de vida tu tem: ");
            //dia = int.Parse(Console.ReadLine());

            ////Processamento

            //t = (365 * ano) + (30 * mes) + dia;

            ////Saída

            //Console.WriteLine("O teu total de dias vividos são: " + t);

            ////Encerramento
            //Console.ReadKey();

            //------------------------------------------------------------------------------------//
            //Declaração de variáveis
            int a, b, c;
            //Entrada
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            //Processamento
            c = a;
            a = b;
            b = c;
            //Saída
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            //Encerramento
            Console.ReadKey();

        }
    }
}
