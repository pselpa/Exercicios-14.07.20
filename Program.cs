using System;

namespace Exercicios_14._07._20
{
    class Program
    {
        static void Main(string[] args)
        {
            // //1.a)Imprimir os números de 1 a 10 de forma crescente
            // int evenNumber = 1;
            // while (evenNumber <= 10) 
            // {
            //     Console.WriteLine(evenNumber);
            //     evenNumber++;
            // }
            // System.Console.WriteLine("Fim do exercício");


            // //1.b)Imprimir os números de 1 a 10 de forma decrescente
            // evenNumber = 10;
            // while (evenNumber >= 0)
            // {
            //     Console.WriteLine(evenNumber);
            //     evenNumber--;
            // }
            // System.Console.WriteLine("Fim do exercício");


            // //1.c)Imprimir os números PARES de 1 a 10 de forma crescente
            // evenNumber = 1;
            // while (evenNumber <= 10)
            // {
            //     evenNumber++;
            //     if (evenNumber % 2 == 0)
            //     {
            //         System.Console.WriteLine(evenNumber);
            //     }
            // }


            // // 2. Imprimir a soma dos números inteiros de 1 a 100.
            // int sumIntNumbers = 0;
            // int counterSum = 0;

            // while (counterSum <= 100)
            // {
            //     sumIntNumbers += counterSum;
            //     counterSum++;
            // }
            // System.Console.WriteLine($"Soma = {sumIntNumbers}");


            // //3. Imprimir todo os números ímpares menores de 200.
            // int oddNumber = 0;

            // while (oddNumber < 200)
            // {
            //     oddNumber++;
            //     if (oddNumber % 2 != 0)
            //     {
            //         System.Console.WriteLine(oddNumber);
            //     }
            // }

            // //4. Calcular a média de idade de uma turma. Parar quando for digitada a idade igual a zero.
            // int counter = 0;
            // float groupAge = 1;
            // var age = "";

            // while (age != "0")
            // {
            //     System.Console.WriteLine("Insira a idade de um membro da turma (zero para encerrar):");
            //     age = System.Console.ReadLine();
            //     groupAge += float.Parse(age);
            //     counter++;
            // }
            // float averageAge = (groupAge-1)/(counter-1);
            // System.Console.WriteLine($"Idade média = {averageAge}");

            // //5. Peça nome e idade de 5 mulheres. Mostrar porcentagem das que têm idade entre 18 e 35. 
            // int userAge = 0;
            // string userName = "";
            // float counterUsers = 0;
            // float counterAge = 0;
            // float percentAverageAge = 0;


        //     while (counterUsers < 5)
        //     {
        //         System.Console.WriteLine("Insira o nome da Usuária:");
        //         userName = System.Console.ReadLine();
        //         System.Console.WriteLine("Insira a idade da Usuária:");
        //         var age = System.Console.ReadLine();
        //         userAge = int.Parse(age);
        //         counterUsers++;

        //         if (userAge >= 18 && userAge <= 35)
        //         {
        //             counterAge++;
        //         }
        //     }
        //     percentAverageAge = (counterAge / counterUsers) * 100;
        //     System.Console.WriteLine($"A porcentagem de mulheres entre 18 e 35 anos é {percentAverageAge}%");
        // }

        // //6. URNA ELETRÔNICA (SENHA, Cadastrar, Votar, apurar votos)
        // // * Esta urna deve possuir dois candidatos e possui três modos. 
        // // * O primeiro é o modo de CADASTRO, onde o sistema pergunta o nome de cada um dos dois candidatos. 
        // // *** Para poder cadastrar um candidato deve solicitar senha para poder ter acesso (a senha é Pa$$w0rd).
        // // * O segundo é o modo de votos, informa 1 para votar no primeiro e 2 para votar no segundo candidato. 
        // // * O terceiro, é o modo de apuração de votos, onde o sistema verifica qual candidato tem mais votos. 
        // // *** Caso o número de votos seja igual, o sistema deve imprimir a mensagem "SEGUNDO TURNO", caso 
        // // contrário deve imprimir o nome do candidato vencedor e o número de votos que ele obteve.

        // System.Console.WriteLine("*** URNA ELETRÔNICA ***");
        // var firstCandidate = "";
        // var secondCandidate = "";

        //     System.Console.WriteLine("1ª ETAPA: CADASTRO");
        //     System.Console.WriteLine("Insira a senha para continuar:");
        //     var password = System.Console.ReadLine();
            
        //     if (password != "Pa$$w0rd")
        //     {
        //         System.Console.WriteLine("SENHA INCORRETA");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Insira o nome do 1º candidato:");
        //         firstCandidate = System.Console.ReadLine();
        //         System.Console.WriteLine("Insira o nome do 2º candidato:");
        //         secondCandidate = System.Console.ReadLine();
        //     }

        //     System.Console.WriteLine("2ª ETAPA: VOTAÇÃO:");
        //     int firstCandidateCounter = 0;
        //     int secondCandidateCounter = 0;

        //     System.Console.WriteLine($"Selecione dentre as opções: (1) {firstCandidate} ou (2) {secondCandidate} ");

        //     while (true)
        //     {
        //         System.Console.WriteLine("Insira o número, ou X para finalizar:");
        //         var vote = System.Console.ReadLine();
        //         if (vote == "x" || vote == "X")
        //         {
        //             break;
        //         }
        //         else if (vote == "1")
        //         {
        //             firstCandidateCounter++;
        //         }
        //         else if (vote == "2")
        //         {
        //             secondCandidateCounter++;
        //         }
        //         else
        //         {
        //             System.Console.WriteLine("Escolha uma opção válida.");
        //         }
        //     }

        //     System.Console.WriteLine("3ª ETAPA: APURAÇÃO DOS VOTOS");
        //     if (firstCandidateCounter > secondCandidateCounter)
        //     {
        //         System.Console.WriteLine($"Candidato(a) {firstCandidate} venceu a eleição!");
        //     }
        //     else if (secondCandidateCounter > firstCandidateCounter)
        //     {
        //         System.Console.WriteLine($"Candidato(a) {secondCandidate} venceu a eleição!");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("SEGUNDO TURNO");
        //     }


            // // 7. Calcular a quantidade de dinheiro gasta por um fumante. Dados: o numero de anos que ele 
            // //fuma, o nº de cigarros fumados por dia e o preço de uma carteira

            // System.Console.WriteLine("Há quantos anos esta pessoa fuma?");
            // var years = System.Console.ReadLine();
            // var smokingYears = double.Parse(years);
            // System.Console.WriteLine("Quantos cigarros ela fuma por dia?");
            // var cigarretes = System.Console.ReadLine();
            // var cigarretesPerDay = double.Parse(cigarretes);
            // System.Console.WriteLine("Qual o valor da carteira de cigarros?");
            // var price = System.Console.ReadLine();
            // var cigarretesPrice = double.Parse(price);

            // var cigarretesPerYear = (cigarretesPerDay*smokingYears*365/20);
            // var cigarretesPackPerYear = Math.Ceiling(cigarretesPerYear);
            // var totalExpensePerYear = (cigarretesPackPerYear*cigarretesPrice);

            // System.Console.WriteLine($"O valor total gasto em cigarros foi R$ {totalExpensePerYear}");


            // //8. Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.
            // System.Console.WriteLine("Insira X:");
            // var xString = System.Console.ReadLine();
            // int x = Int32.Parse(xString);
            // System.Console.WriteLine("Insira Y:");
            // var yString = System.Console.ReadLine();
            // int y = Int32.Parse(yString);

            // if (x % y == 0)
            // {
            //     System.Console.WriteLine("X é módulo de Y.");
            // }
            // else
            // {
            //     System.Console.WriteLine("X não é módulo de Y.");
            // }


            // // 9. Fazer um algoritmo para ler 03 números reais do teclado e verificar se o primeiro é maior 
            // //que a soma dos outros dois.

            // System.Console.WriteLine("Insira o 1º número:");
            // var num1 = System.Console.ReadLine();
            // int firstNumber = Int32.Parse(num1);
            // System.Console.WriteLine("Insira o 2º número:");
            // var num2 = System.Console.ReadLine();
            // int secondNumber = Int32.Parse(num2);
            // System.Console.WriteLine("Insira o 3º número:");
            // var num3 = System.Console.ReadLine();
            // int thirdNumber = Int32.Parse(num3);
            // int sum = secondNumber + thirdNumber;

            // if (firstNumber > sum)
            // {
            //     System.Console.WriteLine("Primeiro número é maior que os outros dois.");
            // }
            // else
            // {
            //     System.Console.WriteLine("Primeiro número não é maior que os outros dois");
            // }


            // // 10. Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é maior, ou a 
            // //mensagem "A = B" caso sejam iguais.

            // System.Console.WriteLine("Insira a variável A:");
            // var num1 = System.Console.ReadLine();
            // int varA = Int32.Parse(num1);
            // System.Console.WriteLine("Insira a variável B:");
            // var num2 = System.Console.ReadLine();
            // int varB = Int32.Parse(num2);

            // if (varA > varB)
            // {
            //     System.Console.WriteLine("A > B");
            // }
            // else if (varB > varA)
            // {
            //     System.Console.WriteLine("B > A.");
            // }
            // else
            // {
            //     System.Console.WriteLine("A = B");
            // }

            // // 11. Ler 02 números inteiros. Se o segundo for diferente de zero, calcular e imprimir 
            // //o quociente do primeiro pelo segundo. Caso contrário, imprimir a mensagem: "DIVISÃO POR ZERO".

            // System.Console.WriteLine("Insira o primeiro número:");
            // var num1 = System.Console.ReadLine();
            // double firstNumber = Int32.Parse(num1);
            // System.Console.WriteLine("Insira o segundo número:");
            // var num2 = System.Console.ReadLine();
            // double secondNumber = Int32.Parse(num2);

            // if (secondNumber != 0)
            // {
            //     double division = firstNumber/secondNumber;
            //     System.Console.WriteLine($"Divisão = {division}");
            // }
            // else if (secondNumber == 0)
            // {
            //     System.Console.WriteLine("DIVISÃO POR ZERO!");
            // }

            // // 12. Ler 4 números inteiros e calcular a soma dos que forem pares e ímpares.

            // int sumEvenNumbers = 0;
            // int sumOddNumbers = 0;
            // int cont = 0;

            // while (cont < 4)
            // {
            // System.Console.WriteLine("Insira um número inteiro:");
            // var num = System.Console.ReadLine();
            // int number = Int32.Parse(num);
            // cont++;

            // if (number%2 == 0)
            // {
            //     sumEvenNumbers += number;
            // }
            // else if (number%2 != 0)
            // {
            //     sumOddNumbers += number;
            // }
            // }
            // System.Console.WriteLine($"A soma dos números pares é {sumEvenNumbers}");
            // System.Console.WriteLine($"A soma dos números ímpares é {sumOddNumbers}");


            // // 13. Ler 10 valores e determinar o maior dentre eles.

            // int greatestNumber = 0;
            // int counter = 0;

            // while (counter < 10)
            // {
            // System.Console.WriteLine("Insira um número:");
            // var num = System.Console.ReadLine();
            // int number = Int32.Parse(num);
            // counter++;

            // if (number > greatestNumber)
            // {
            //     greatestNumber = number;
            // }
            // }
            // System.Console.WriteLine($"O maior número é {greatestNumber}");
            
            
            // // 14. Ler três valores e colocá-los em ordem
            
            // int firstNumber = 0;
            // int secondNumber = 0;
            // int thirdNumber = 0;
        
            // System.Console.WriteLine("Insira o primeiro número:");
            // var num1 = System.Console.ReadLine();
            // int number1 = Int32.Parse(num1);

            // System.Console.WriteLine("Insira o segundo número:");
            // var num2 = System.Console.ReadLine();
            // int number2 = Int32.Parse(num2);

            // System.Console.WriteLine("Insira o terceiro número:");
            // var num3 = System.Console.ReadLine();
            // int number3 = Int32.Parse(num3);

            // if (number1 < number2 && number2 < number3)
            // {
            //     firstNumber = number1;
            //     secondNumber = number2;
            //     thirdNumber = number3;
            // }
            // else if (number1 < number3 && number3 < number2)
            // {
            //     firstNumber = number1;
            //     secondNumber = number3;
            //     thirdNumber = number2;
            // }
            // else if (number2 < number1 && number1 < number3)
            // {
            //     firstNumber = number2;
            //     secondNumber = number1;
            //     thirdNumber = number3;
            // }
            // else if (number2 < number3 && number3 < number1)
            // {
            //     firstNumber = number2;
            //     secondNumber = number3;
            //     thirdNumber = number1;
            // }
            // else if (number3 < number1 && number1 < number2)
            // {
            //     firstNumber = number3;
            //     secondNumber = number1;
            //     thirdNumber = number2;
            // }
            // else if (number3 < number2 && number2 < number1)
            // {
            //     firstNumber = number3;
            //     secondNumber = number2;
            //     thirdNumber = number1;
            // }

            // System.Console.WriteLine($"1° número {firstNumber}");
            // System.Console.WriteLine($"2° número {secondNumber}");
            // System.Console.WriteLine($"3° número {thirdNumber}");


            // // 15. Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.

            // int counter3 = 0;
            // int counter5 = 0;
            // int counter = 0;

            // while (counter < 10)
            // {
            //     counter++;
            //     System.Console.WriteLine($"Insira o número {counter} de 10");
            //     int number = Int32.Parse(System.Console.ReadLine());

            //     if (number%3 == 0)
            //     {
            //         counter3++;
            //     }
            //     else if (number%5 == 0)
            //     {
            //         counter5++;
            //     }
            // }
            // System.Console.WriteLine($"Há {counter3} números múltiplos de 3 e {counter5} múltiplos de 5.");


            // // 16. Ler o salário de uma pessoa e imprimir o Salário Líquido de acordo com a redução do imposto descrito ao lado:
            // // Menor ou igual a R$ 600,00 - ISENTO
            // // Maior que R$ 600,00 e menor ou igual a 1200 - 20% desconto
            // // Maior que R$ 1.200,00 e menor ou igual a R$2000 - 25% desconto
            // // Maior que R$ 2.000,00 - 30% desconto

            // double finalIncome = 0;
            // System.Console.WriteLine("Insira o seu salário bruto:");
            // double income = double.Parse(System.Console.ReadLine());

            // if (income <= 600)
            // {
            //     System.Console.WriteLine($"Salário = R$ {income}. ISENTO");
            // }
            // else if (income > 600 && income <= 1200)
            // {
            //     finalIncome = income * 0.8;
            //     System.Console.WriteLine($"Salário líquido é R$ {finalIncome.ToString("0.00")}");
            // }
            // else if (income > 1200 && income <= 2000)
            // {
            //     finalIncome = income * 0.75;
            //     System.Console.WriteLine($"Salário líquido é R$ {finalIncome.ToString("0.00")}");
            // }
            // else if (income > 2000)
            // {
            //     finalIncome = income * 0.70;
            //     System.Console.WriteLine($"Salário líquido é R$ {finalIncome.ToString("0.00")}");
            // }

            // // 17. Imprimir a tabuada de qualquer número fornecido pelo usuário até que o usuário forneça o valor –1.

            // int number = 0;

            // while (true)
            // {
            //     System.Console.WriteLine("Insira um número inteiro. Para finalizar, digite -1:");
            //     number = Int32.Parse(System.Console.ReadLine());

            //     if (number == -1) 
            //     {
            //         break;
            //     }

            //     System.Console.WriteLine($"1 x {number} = {number}");
            //     System.Console.WriteLine($"2 x {number} = {2*number}");
            //     System.Console.WriteLine($"3 x {number} = {3*number}");
            //     System.Console.WriteLine($"4 x {number} = {4*number}");
            //     System.Console.WriteLine($"5 x {number} = {5*number}");
            //     System.Console.WriteLine($"6 x {number} = {6*number}");
            //     System.Console.WriteLine($"7 x {number} = {7*number}");
            //     System.Console.WriteLine($"8 x {number} = {8*number}");
            //     System.Console.WriteLine($"9 x {number} = {9*number}");
            //     System.Console.WriteLine($"10 x {number} = {10*number}");
            // }

            // 18. As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem compradas pelo menos 12. Escreva 
            //um programa que leia o número de maçãs compradas, calcule e escreva o custo total da compra. 

            
           
            System.Console.WriteLine("Quantas maçãs você deseja comprar?");
            int appleAmount = Int32.Parse(System.Console.ReadLine());

            if (appleAmount < 12)
            {
                double appleCost = 1.3 *appleAmount;
                System.Console.WriteLine($"Total da compra: R$ {appleCost.ToString("0.00")}");   
            }
            else if (appleAmount >= 12)
            {
                System.Console.WriteLine($"Total da compra: R$ {appleAmount}"); 
            }

            




        }
    }
}
