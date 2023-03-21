// See https://aka.ms/new-console-template for more information
/* *******************************************************************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 22/03/2023
 * Autores do Projeto: Rafael Alves Freitas da Silva
 * Turma: 2F
 * Atividade Proposta em aula
 * Observação:
 * 
 * projeto.cs
 * ************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Projeto_PVB
    {
        static void Main(string[] args)
        {
            //Global
            int pessoas = 0;
            //var A
            int sup500 = 0;
            //var B
            int sup25 = 0;
            int sub25 = 0;
            //var C
            int idade2grau = 0;
            int pessoas2grau = 0;
            //var D
            double total_sup = 0;
            double total_prim = 0;
            
            //var E
            int maior_grau = 0;
            int maior_idade = 0;
            string maior_nome = null;
            double maior_sal = 0;

            int menor_grau = 0;
            int menor_idade = 0;
            string menor_nome = null;
            double menor_sal = 0;
            //var F/G
            int total5 = 0;
            int total10 = 0;
            int total15 = 0;

            //var H
            double sal_dolar = 0;
            Console.WriteLine("deseja iniciar o programa?");
            string controle = Convert.ToString(Console.ReadLine());
            while (controle == "s" || controle == "sim") 
            {
                pessoas++;
                //nome
                Console.WriteLine("digite seu nome");
                string nome = Convert.ToString(Console.ReadLine());
                //salario
                Console.WriteLine("digite seu salario");
                double salario = Convert.ToDouble(Console.ReadLine());
                while (salario < 0) 
                { 
                    Console.WriteLine("digite um salário valido");
                    salario = Convert.ToDouble(Console.ReadLine());
                }
                //idade
                Console.WriteLine("digite sua idade");
                int idade = Convert.ToInt32(Console.ReadLine());
                while (idade < 0)
                {
                    Console.WriteLine("digite uma idade valida");
                    idade = Convert.ToInt32(Console.ReadLine());
                }
                //dolar
                Console.WriteLine("qual a cotacao do dolar");
                double dolar = Convert.ToDouble(Console.ReadLine());
                //grau
                Console.WriteLine("qual seu grau de intrucao:\n (1) - primário\n (2) - Segundo Grau \n (3)– Superior");
                int grau = Convert.ToInt32(Console.ReadLine());
                while (grau != 1 && grau != 2 && grau != 3)
                {
                    Console.WriteLine("grau de intrucao invalido digite um valor valido:\n (1) - primário\n (2) - Segundo Grau \n (3)– Superior");
                    grau = Convert.ToInt32(Console.ReadLine());
                }
                //start A1
                if (grau == 3 && salario > 500) 
                {
                    sup500++;
                }
                //end A1

                //start B1
                if (idade >= 25) sup25++;
                else sub25++;
                //end B1

                //start C1
                if (grau == 2)
                {
                    idade2grau = idade2grau + idade;
                    pessoas2grau++;
                }
                //end C1

                //start D1
                if (grau == 1)
                {
                    total_prim++;
       
                }
                if (grau == 3)
                {
                    total_sup++;
                    
                }
               
                //end D1

                //start E1
                if (maior_sal < salario)
                {
                    maior_sal = salario;
                    maior_nome = nome;
                    maior_idade = idade;
                    maior_grau = grau;
                }
                if (salario > menor_sal)
                {
                    menor_sal = salario;
                    menor_nome = nome;
                    menor_idade = idade;
                    menor_grau = grau;
                }
                //end E1

                //start F/G
                if (idade > 20 && idade <35)
                {
                    salario = salario + (salario * 0.05);
                    total5++;
                }
                if (idade > 35 && idade < 45)
                {
                    salario = salario + (salario * 0.1);
                    total10++;
                }
                if (idade > 45)
                {
                    salario = salario + (salario * 0.15);
                    total15++;
                }
                //end F/G

                //start H
                sal_dolar = salario / dolar;
                Console.WriteLine("nome: " + nome + "\nsalário em dolar:" + sal_dolar);
                //end H

                Console.WriteLine("deseja continuar inserindo dados?");
                controle = Convert.ToString(Console.ReadLine());
            }
            //start A2
            Console.WriteLine("o numero de pessoas com curso superior e que ganham mais de 500 reais é de:" + sup500);
            //end A2

            //startB2
            int dif25 = sup25 - sub25;
            if (dif25 < 0) dif25 = dif25 * (-1);
            Console.WriteLine("a diferença entre os maiores de 25 anos e os menosres de 25 anos é de:" +dif25);
            //endB2

            //startC2
            if (idade2grau != 0 && pessoas2grau != 0)
            { 
                double media2grau = 0;
                media2grau = idade2grau / pessoas2grau;
                Math.Round(media2grau);
                Console.WriteLine("a media da idade das pessoas com 2 grau e de:" +media2grau);
            }
            //end C2

            //startD2
            double porc_sup = (total_sup * 100) / pessoas ;
            Math.Round(porc_sup);
            Console.WriteLine("a porcentagem de pessoas com curso superior e de:" +porc_sup + "%");
            double porc_prim = (total_prim *100) / pessoas;
            Math.Round(porc_prim);
            Console.WriteLine("a porcentagem de pessoas com curso primario e de:" + porc_prim +"%");
            //end D2

            //start E2
            Console.WriteLine("maior salario:");
            Console.WriteLine("nome:" + maior_nome);
            Console.WriteLine("nome:" + maior_idade);
            Console.WriteLine("nome:" + maior_grau);
            Console.WriteLine("nome:" + maior_sal);

            Console.WriteLine("menor salario:");
            Console.WriteLine("nome:" + menor_nome);
            Console.WriteLine("nome:" + menor_idade);
            Console.WriteLine("nome:" + menor_grau);
            Console.WriteLine("nome:" + menor_sal);
            //endE2

            //start G2
            double porc5 = (total5 * 100) / pessoas;
            double porc10 = (total10 * 100) / pessoas;
            Double porc15 = (total15 * 100) / pessoas;
            Math.Round(porc5);
            Math.Round(porc10);
            Math.Round(porc15);
            Console.WriteLine("percentual de pessoas com 5% decimal acrecimo é de:" + porc5 + "%");
            Console.WriteLine("percentual de pessoas com 5% decimal acrecimo é de:" + porc10 + "%");
            Console.WriteLine("percentual de pessoas com 5% decimal acrecimo é de:" + porc15 + "%");
            //end G2

            

        }
    }
}

