using System;
using System.Globalization;
using System.Collections.Generic;
using Primeiro.Eintities;
using Primeiro.Eintities.Enums;
using Primeiro.Entities;
using Primeiro.Entities.Enums;
using Primeiro.Entities.Exceptions;
using System.IO;


namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int idade = 32;
            double saldo = 10.35874;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5291;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + " cujo preço é " + preco1);
            Console.WriteLine(produto2 + " cujo preço é " + preco2);

            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero );

            Console.WriteLine("Medida com oito casas decimais: {0:f8}", medida);

            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant culture " + medida.ToString("F3", CultureInfo.InvariantCulture)); 

            int a = 10;
            Console.WriteLine(a);
            
            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a /= 2;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            
            s += "DEF";
            Console.WriteLine(s); 

            int a = 10;
            int b = ++a;

            Console.WriteLine(a);

            Console.WriteLine(b); 

            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            double a = 5.1;
            int b = (int)a;
            Console.WriteLine(b); 

            int a = 5;
            int b = 2;

            double resultado = (double) a / b;
            Console.WriteLine(resultado); 
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8;

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1); 

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

           
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou: " + n1);
            Console.WriteLine("Você digitou a letra: " + ch);
            Console.WriteLine("Você digitou: " + n2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture)); 

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com seu último nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
         

            EXERCICIO EXEMPLO 
            
            double largura, comprimento, precoM2, area, preco;

            Console.WriteLine("Digite a largura do terreno: "); 
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o preço do metro quadrado: ");
            precoM2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoM2;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO = " + preco.ToString("F2", CultureInfo.InvariantCulture));
            

            EXERCICIO 1

            int v1, v2, resultado;

            Console.WriteLine("Digite o primeiro numero: ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            v2 = int.Parse(Console.ReadLine());

            resultado = v1 + v2;

            Console.WriteLine("a soma é: " + resultado);
           
            
            EXERCICIO 2

            double valor;
            double tt = 3.14159;
            double area;

            Console.WriteLine("Digite o valor do raio: ");
            valor = double.Parse(Console.ReadLine());

          
            area = tt * (Math.Pow (valor, 2.0));

            Console.WriteLine("o valor da área do circulo é: " + area.ToString("F4", CultureInfo.InvariantCulture));  

            
            EXERCICIO 3
            
            int diferenca;
            
            Console.WriteLine("Digite o valor de A: ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            int D = int.Parse(Console.ReadLine());

            diferenca = (A * B - C * D);

            Console.WriteLine("a diferença é: " + diferenca); 


            EXERCICIO 4

            int funcionario = int.Parse(Console.ReadLine());
            double horas = double.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine());

            double salario;

            salario = horas * valor;

            Console.WriteLine("Numero: " + funcionario);
            Console.WriteLine("Numero: " + salario.ToString("F2", CultureInfo.InvariantCulture));


            EXERCICIO 5

            int codigo1, codigo2, numero1, numero2;
            double valor1, valor2, total;

            string[] valores = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(valores[0]);
            numero1 = int.Parse(valores[1]);
            valor1 = double.Parse(valores[2]);

            valores = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(valores[0]);
            numero2 = int.Parse(valores[1]);
            valor2 = double.Parse(valores[2]);

            total = (numero1 * valor1) + (numero2 * valor2);

            Console.WriteLine("VALOR A PAGAR: " + total.ToString("F2", CultureInfo.InvariantCulture));


            EXERCICIO 6

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0]);
            B = double.Parse(valores[1]);
            C = double.Parse(valores[2]);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture)); 

            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8); 


            bool c1 = ! (2 > 3) || 4 != 5;
            bool c2 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("------------------");

            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;

            Console.WriteLine(c4); 

            int x = 10;

            Console.WriteLine("Bom dia");
            
            if (x < 5)
            {
                Console.WriteLine("Boa tarde");
            }
            
            
            Console.WriteLine("Boa noite"); 

            Console.WriteLine("Entre com um numero inteiro");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            } 
            else
            {
                Console.WriteLine("O numero é impar");
            }

            Console.WriteLine("Digite a hora atual: ");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if ( hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite"); 
            } 

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto); 


            EXERCICIO 1
            int n1 = int.Parse(Console.ReadLine());
            
            if (n1 < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("POSITIVO");
            } 

            EXERCICIO 2
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }


            EXERCICIO 3
            string[] numeros = Console.ReadLine().Split(' ');

            int A = int.Parse(numeros[0]);
            int B = int.Parse(numeros[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            } 

            
            EXERCICIO 4
            string[] valores = Console.ReadLine().Split(' ');
            int inicial = int.Parse(valores [0]);
            int final = int.Parse(valores [1]);
            
            int duracao;

            if (inicial < final)
            {
                duracao = final - inicial;
            }
            else
            {
                duracao = 24 - inicial + final;
            }

            Console.WriteLine("O jogo durou: " + duracao + " horas!"); 

            
            EXERCICIO 5

            double valor = 0;

            Console.WriteLine("Digite o código e a quantidade: ");
            string[] produto = Console.ReadLine().Split(' ');
            int codigo = int.Parse(produto[0]);
            int qtde = int.Parse(produto[1]);

            if (codigo == 1)
            {
                valor = qtde * 4;
            } 
            else if (codigo == 2)
            {
                valor = qtde * 4.50;
            }
            else if (codigo == 3)
            {
                valor = qtde * 5;
            }
            else if (codigo == 4)
            {
                valor = qtde * 2;
            } 
            else
            {
                valor = qtde * 1.50;
            }

            Console.WriteLine("Valor Total: " + valor.ToString("F2", CultureInfo.InvariantCulture)); 


            EXERCICIO 6

            Console.WriteLine("Digite um valor: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0 || valor > 100)
            {
                Console.WriteLine("Fora do intervalo!");
            }
            else if (valor <= 25)
            {
                Console.WriteLine("Intervalo: (0,25)");
            }
            else if (valor <= 50)
            {
                Console.WriteLine("Intervalo: (25,50)");
            }
            else if (valor <= 75)
            {
                Console.WriteLine("Intarvalo: (50,75)");
            }
            else
            {
                Console.WriteLine("Intervalo: (75,100)");
            }


            Console.WriteLine("digite 3 numeros");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior é: " + resultado); ;
        }


        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m; 

            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            while (numero >= 0.0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero: ");
                numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
                
            Console.WriteLine("numero negativo"); 

            EXERCICIO 1

            Console.WriteLine("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());
            
            while (senha != 2022)
            {
                Console.WriteLine("Senha inválida, digite novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Acesso Permitido! "); 

            EXERCICIO 2

            Console.WriteLine("Digite o valor de X e Y: ");
            string[] valores = Console.ReadLine().Split(' ');

            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }

                Console.WriteLine("Digite o valor de X e Y: ");
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }

            EXERCICIO 3

            Console.WriteLine("Digite o codigo do combustivel: ");
            int codigo = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (codigo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (codigo == 3)
                {                    
                    diesel = diesel + 1;
                }
                
                Console.WriteLine("Digite o codigo do combustivel: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel); 


            Console.Write("Quantos numeros inteiros você vai digitar?: ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Valor #" + i);
                int valor = int.Parse(Console.ReadLine());              
                soma += valor;
            }

            Console.WriteLine("Soma: " + soma ); 

            EXERCICIO 1

            Console.WriteLine("digite valor de x: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            } 


            EXERCICIO 2

            Console.WriteLine("quantidade de numeros: ");
            int n = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("valor # " + i);
                int x = int.Parse(Console.ReadLine());

                if (x < 10 || x > 20)
                {
                    fora = fora + 1;
                }
                else
                {
                    dentro = dentro + 1;
                }    
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out"); 

            
            EXERCICIO 3

            Console.WriteLine("quantidade: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = (Console.ReadLine().Split(' '));
                double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            } 


            EXERCICIO 5 

            Console.WriteLine("digite o valor");
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial); 


            EXERCICIO 6

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            EXERCICIO 7

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                
                Console.WriteLine($" {primeiro} {segundo} {terceiro}");
            } 

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triangulo X:");

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y:");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));


            Console.WriteLine("Area de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior X");
            }
            else
            {
                Console.WriteLine("Maior Y");
            }

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y:");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));


            Console.WriteLine("Area de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior X");
            }
            else
            {
                Console.WriteLine("Maior Y");
            } 

            
            EXERCICIO 1

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            int idade1, idade2;

            Console.WriteLine("Digite com os dados da primeira pessoa:");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite com os dados da segunda pessoa:");
            Console.WriteLine("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            } 

            EXERCICIO 2  

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Entre com os dados do primeiro funcionario");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados do segundo funcionario");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));

            
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo Y:");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior X");
            }
            else
            {
                Console.WriteLine("Maior Y");
            } 

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque? ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto " + p);
            Console.WriteLine();

            Console.Write("Quantidade a ser adicionada no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Quantidade a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            EXERCICIO 1
            
            Retangulo t1 = new Retangulo();
                        
            Console.WriteLine("Digite os dados do Retangulo: ");
            Console.Write("Largura: ");
            t1.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            t1.Altura = double.Parse(Console.ReadLine());

            
            Console.Write("AREA: " + t1.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
                        
            Console.Write("PERIMETRO: " + t1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("DIAGONAL: " + t1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(); 

            EXERCICIO 2
            Funcionario f = new Funcionario();
            
            Console.Write("Digite o nome do Funcionario: ");
            f.Nome = Console.ReadLine();
            Console.Write("Digite o Salario Bruto do Funcionario: ");
            f.SalarioBruto = double.Parse(Console.ReadLine()); 
            Console.Write("Digite o Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + f.Nome + ", Salario Liquido R$ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            double porcentagem;
            Console.WriteLine("Qual a porcentagem de aumento?");
            porcentagem = double.Parse(Console.ReadLine());
            f.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + f); 

            Aluno aluno = new Aluno();

            Console.WriteLine("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Nota 1:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2:");
            aluno.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota 3:");
            aluno.Nota3 = double.Parse(Console.ReadLine());

            aluno.Media();

            aluno.Aprovacao();

            
            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
            }
            
            static double Circunferencia(double r)
            {
                return 2 * Pi * r;
            } 

            static double Volume(double r)
            {
                return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
            } 

            Calculadora calc = new Calculadora();

            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture)); 

            
            Console.WriteLine("Digite o valor do raio: ");                                                                                                          
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)); 

            Console.WriteLine("Qual a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dolares deseja comprar: ");
            double qtde = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = ConversorDeMoeda.Cotacao(cotacao, qtde);

            Console.WriteLine("Valor a ser pago em Reais: " + valor.ToString("F2", CultureInfo.InvariantCulture)); 


            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p1 = new Produto(nome, preco);

            Produto p2 = new Produto();

            Produto p3 = new Produto 
            { 
                Nome = "tv", 
                Preco = 500.00, 
                Quantidade = 20 
            };

            Console.WriteLine();
            Console.WriteLine("Dados do Produto " + p);
            Console.WriteLine();

            Console.Write("Quantidade a ser adicionada no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Quantidade a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p); 


            Produto p = new Produto("Tv", 500, 10);

            p.Nome = ("T");

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco); 

            ContaBancaria conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor de depósito inicial");
                double inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, inicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }



            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor de Deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor de Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta); 

            Point p = new Point();
            
            Console.WriteLine(p); 

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null!");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null!"); 
            }


            double? x = null;
            double? y = 10;

            y = x ?? 30;

            Console.WriteLine(y); 

            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            double avg = soma / n;
            Console.WriteLine("Média: " + avg.ToString("F2", CultureInfo.InvariantCulture)); 

            int n = int.Parse(Console.ReadLine());

            Produtct[] vect = new Produtct[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produtct { Nome = name, Price = price };    
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("Preço medio igual a: " + avg.ToString("F2", CultureInfo.InvariantCulture)); 

            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);
            int s3 = Calculator.Sum(2, 3, 4, 8, 4, 5, 6, 98, 2, 3, 4, 8, 4, 5, 6, 98, 2, 3, 4, 8, 4, 5, 6, 98);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3); 

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a); 

            int b = 10;
            int triple;
            Calculator.Triple1(b, out triple);
            Console.WriteLine(triple);

            string[] vetor = new string[] { "Maria", "Alex", "Bob" };

            foreach (string obj in vetor)
            {
                Console.WriteLine(obj); 
            }

            List<string> lista = new List<string>();
            List<string> lista2 = new List<string> { "Maria", "José" }; 

            List<string> lista = new List<string>();

            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");
            lista.Insert(2, "Marco");
            lista.Insert(4, "Aaron");


            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("Tamanho da lista: " + lista.Count);

            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);

            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position com A: " + pos1);

            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position com A: " + pos2);

            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            foreach (string obj in lista2)
            {
                Console.WriteLine("5 Letras " + obj);
            }

            Console.WriteLine("--------------------------------------");

            lista.Remove("");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------");
            
            lista.RemoveAll(x => x[0] == 'M');
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveAt(2);

            lista.RemoveRange(2, 2);

            Console.WriteLine("Quantas pessoas seram registrados: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> lista = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #: " + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Employee(id, nome, salario));
                Console.WriteLine("----------------------------");

            }

            Console.Write("Qual o Id para aumento do salario: ");
            int idAu = int.Parse(Console.ReadLine());

            Employee emp = lista.Find(x => x.Id == idAu);
            if (emp != null)
            {
                Console.Write("Qual a porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(porcentagem);
            }
            else
            {
                Console.WriteLine("Este id não existe!");
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Dados atualizados!");

            foreach (Employee obj in lista)
            {
               Console.WriteLine(obj);
            }


            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine();

            Console.WriteLine(mat.GetLength(8));

            Console.Write("tamanho da matiz: ");
            int n = int.Parse(Console.ReadLine());

            int [,] matriz = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]); 
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + count); 

            string[] line = Console.ReadLine().Split();
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Digite um numero da matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }


            int x = int.Parse(Console.ReadLine());

            string day;
            
            switch (x)
            {
                case 1:
                    day = "Sunday";
                    break;

                case 2:
                    day = "Monday";
                    break;

                case 3:
                    day = "Tuesday";
                    break;

                case 4:
                    day = "Whednesday";
                    break;
                
                case 5:
                    day = "Thurday";
                    break;

                case 6:
                    day = "Friday";
                    break;
                
                case 7:
                    day = "Saturday";
                    break;

                default:
                    day = "Invalid value";
                    break;
                
            }

            Console.WriteLine("Day: " + day); 

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            desconto = (preco < 20) ? desconto = preco * 0.1 : desconto = preco * 0.05;
            
            Console.WriteLine(desconto);    


            string original = "abcde FGHIJ ABC abc DEFG      ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf-bc: -" + n1 + "-");
            Console.WriteLine("LastIndexOf-bc: -" + n2 + "-");
            Console.WriteLine("Substring 3: -" + s4 + "-");
            Console.WriteLine("Substring 3,5: -" + s5 + "-");
            Console.WriteLine("Replace a, x: -" + s6 + "-");
            Console.WriteLine("Replace abc, yx: -" + s7 + "-");
            Console.WriteLine("IsNull or Empty: -" + b1);
            Console.WriteLine("IsNull or WhiteSpace: -" + b2);


            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); 

            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 03);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03, 500);
            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d3 = DateTime.Parse("15/08/2000 13:08:58");
            DateTime d4 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d5 = DateTime.ParseExact("15/08/2000 13:05:55", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);

            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine(t12);


            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeak: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year); 


            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime d1 = new DateTime(2001, 8, 18, 13, 45, 58);

            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);
            DateTime d4 = d.AddDays(7);

            TimeSpan t = d1.Subtract(d);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(t); 

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);


            TimeSpan t10 = new TimeSpan(1, 30, 10);
            TimeSpan t11 = new TimeSpan(0, 10, 5);

            TimeSpan soma = t10.Add(t11);
            TimeSpan dif = t10.Subtract(t11);
            TimeSpan mult = t11.Multiply(2.0);
            TimeSpan div = t11.Divide(2.0);

            Console.WriteLine(soma);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div); 


            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind );
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Local: " + d1.ToUniversalTime());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine("--------------------");
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 kind: " + d3.Kind);
            Console.WriteLine("d3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + d3.ToUniversalTime());
            Console.WriteLine("-------------------------------------------");


            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to UTC: " + d2.ToUniversalTime());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); 

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);

            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior):  ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter com o #{i} contract data:");
                Console.Write("Date DD/MM/YYYY: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine();
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for: " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)); 


            Comment c1 = new Comment("Have a nive trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Treaveling to New Zealand",
                "Im going to visit a wonderful country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night!");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys!",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2); 

            ----------------------------------------------------------------------

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, birthDate);
            


            Console.WriteLine("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order); 


            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            Account acc3 = new SavingAccount(1004, "Ana", 0.0, 0.01);

            // DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingAccount)
            {
                //SavingAccount acc5 = (SavingAccount)acc3;
                SavingAccount acc5 = acc3 as SavingAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }


            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingAccount(1002, "Ana", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            List<Employeer> list = new List<Employeer>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + " data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employeer(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employeer emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture)); 
            } 


            List <Products> list = new List<Products>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char cui = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (cui == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customsfee));
                }
                else if (cui == 'u')
                {
                    Console.Write(" Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    list.Add(new Products(name, price));
                }
             
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (Products prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
            

            Console.Write("Enter the number of the shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Shape #" + i);
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(widht, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
                                
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS");

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            } 

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (i/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = (Console.ReadLine());
                Console.Write("Anual income: ");
                double anualIcome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIcome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIcome, numberOfEmployees));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach(TaxPayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture)); 

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed!");
            }

            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }

            finally
            {
                Console.WriteLine("Desista!");
            } 

            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date: (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date: (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to dupdate the reservation.");
                Console.Write("Check-in date: (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date: (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in Reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            } 


            
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = (Console.ReadLine());
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                AccountBank account = new AccountBank(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double valueWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
            try
            {
                account.WithDraw(valueWithdraw);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            } 

            string sourcePath = @"e:\csharp\file1.txt";
            string targetPath = @"e:\csharp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }

            string path = @"e:\csharp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();

                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }

            string path = @"e:\csharp\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }

            string sourcePath = @"e:\csharp\file1.txt";
            string targetPath = @"e:\csharp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            } 

            string path = @"e:\csharp\";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }

            try
            {
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(path + @"\newfolder");
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }


            string path = @"e:\csharp\newfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath()); */




        }
    }
}

