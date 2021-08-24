using System;

//1-Cria uma nova variavel de enum
//2-Montar o a chamada do menu
//3-Tratar o numero digirado para apresenta a opão do menu
//4-Fazer que o menu só feche quando escolher sair
//5-Usa uma limpesa de tela console.clear
//6-Criar um switch case de cada opção


//Brincar de debugar
//De fazer teste no Selenium
//Colocar no git, atualizar e reaproveitar o cod.

namespace Calculadora
{
    class Program
    {
         enum Menu  {soma=1,subtração,multiplicacao,divisao,potencia,raiz,sair};

        static void Main(string[] args)
        {

            Menu opçãoSelecionada = Menu.soma;
            do
            {
                Console.WriteLine("Qual operação Matematica deseja usar?");
                Console.WriteLine("" +
                 "              1-Soma\n" +
                 "              2-Subtração\n" +
                 "              3-Multiplicação\n" +
                 "              4-Divisão\n" +
                 "              5-Potencia\n" +
                 "              6-Raiz Quadrada\n" +  
                 "              7-Sair");
                opçãoSelecionada = (Menu)int.Parse(Console.ReadLine());
                //Console.WriteLine(opçãoSelecionada);


                if (opçãoSelecionada == Menu.sair || opçãoSelecionada != Menu.potencia || opçãoSelecionada != Menu.raiz)
                {
                    



                    switch (opçãoSelecionada)
                    {
                        case Menu.soma:
                            Soma();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case Menu.subtração:
                            Sub();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case Menu.multiplicacao:
                            Mult();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case Menu.divisao:
                            Div();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case Menu.potencia:
                            Pote();
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case Menu.raiz:
                            Raiz();
                            Console.Clear();
                            break;

                    }
                }
                
            } while (opçãoSelecionada !=  Menu.sair);

            /*
            static void digiteNumero(){
                Console.Write("Coloque o Primeiro numero = ");
                int N1 = int.Parse(Console.ReadLine());
                Console.Write("Coloque o Segundo Numero = ");
               int N2 = int.Parse(Console.ReadLine());          
            }*/


            static void Soma()
            {
                Console.Write("Coloque o Primeiro numero = ");
                int N1 = int.Parse(Console.ReadLine());
                Console.Write("Coloque o Segundo Numero = ");
                int N2 = int.Parse(Console.ReadLine());
                int resultado = N1 + N2;
                Console.WriteLine($"A soma de {N1} e {N2} é = {resultado}");
                Console.WriteLine("Aperte ENTER para voltar para o menu");
            }

            static void Sub()
            {
                Console.Write("Coloque o Primeiro numero = ");
                int N1 = int.Parse(Console.ReadLine());
                Console.Write("Coloque o Segundo Numero = ");
                int N2 = int.Parse(Console.ReadLine());
                int resultado = N1 - N2;
                Console.WriteLine($"A Subtração de {N1} e {N2} é = {resultado} ");
                Console.WriteLine("Aperte ENTER para voltar para o menu");
            }

            static void Mult()
            {
                Console.Write("Coloque o Primeiro numero = ");
                int N1 = int.Parse(Console.ReadLine());
                Console.Write("Coloque o Segundo Numero = ");
                int N2 = int.Parse(Console.ReadLine());
                int resultado = N1 * N2;
                Console.WriteLine($"A Multiplicação de {N1} e {N2} é = {resultado} ");
                Console.WriteLine("Aperte ENTER para voltar para o menu");
            }

            static void Div()
            {
                Console.Write("Coloque o Primeiro numero = ");
                int N1 = int.Parse(Console.ReadLine());
                Console.Write("Coloque o Segundo Numero = ");
                int N2 = int.Parse(Console.ReadLine());
                float resultado = (float)N1 / N2;
                Console.WriteLine($"A Multiplicação de {N1} e {N2} é = {resultado} ");
                Console.WriteLine("Aperte ENTER para voltar para o menu");
            }

           
            static double Pote()
            {
                Console.WriteLine("Potência de um numero:");
                Console.Write("Digite a base = ");
                int baseNumerica = int.Parse(Console.ReadLine());
                Console.Write("Digite o expoente = ");
                int expo = int.Parse(Console.ReadLine());
                double resultado = Math.Pow(baseNumerica,expo);
                Console.WriteLine($"O Resultado é = {resultado}");
                Console.WriteLine("Aperte ENTER para voltar para o menu");
                Console.ReadLine();
                return resultado;


            }


            static double Raiz()
            {
                Console.Write("Digite o numero que vai se verificado a Raiz = ");
                int a = int.Parse(Console.ReadLine());
                double resultado = Math.Sqrt(a); //Square Root
                Console.WriteLine($"A Raiz de {a} é = {resultado}");
                Console.WriteLine("Aperte ENTER para voltar para o menu");
                Console.ReadLine();
                return resultado;

            }
            

            Console.Write("Programa sendo finalizado.");
            Console.ReadLine();

        }
    }
}
