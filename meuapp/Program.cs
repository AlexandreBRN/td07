using System;

//Exercício 1: Soma de Números de 1 a 10
// class Program
// {
//     static void Main()
//     {
//         int soma = 0; 

//         for (int i = 1; i <= 10; i++)
//         {
//             soma += i; 
//         }

//         Console.WriteLine("A soma dos números de 1 a 10 é: " + soma);

//         Console.ReadLine();
//     }
// }


//Exercício 2: Contagem Regressiva com while
// class Program
// {
//     static void Main()
//     {
//         int contador = 10; 

//         while (contador >= 0)
//         {
//             Console.WriteLine(contador);
//             contador--; 
//         }

//         Console.ReadLine();
//     }
// }


//Exercício 3: Pular Números Ímpares
// class Program
// {
//     static void Main()
//     {
//         for (int i = 1; i <= 20; i++)
//         {
//             if (i % 2 != 0)
//             {
//                 continue;
//             }

//             Console.WriteLine(i);
//         }

//         Console.ReadLine();
//     }
// }


//Exercício 4: Sair Quando o Quadrado For Maior que 50
// class Program
// {
//     static void Main()
//     {
//         int numero = 1;

//         while (true)
//         {
//             int quadrado = numero * numero;

//             if (quadrado > 50)
//             {
//                 Console.WriteLine("O primeiro quadrado maior que 50 é: " + quadrado);
//                 break;
//             }

//             numero++;
//         }

//         Console.ReadLine();
//     }
// }


//Exercício 5: Tabuada de um Número Usando for
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Digite um número inteiro: ");
//         int numero = int.Parse(Console.ReadLine());

//         Console.WriteLine("Tabuada de " + numero + ":");

//         for (int i = 1; i <= 10; i++)
//         {
//             int resultado = numero * i;
//             Console.WriteLine(numero + " x " + i + " = " + resultado);
//         }

//         Console.ReadLine();
//     }
// }


//Exercício 6: Soma com Loop do-while
// class Program
// {
//     static void Main()
//     {
//         int soma = 0;
//         int numero;

//         do
//         {
//             Console.Write("Digite um número inteiro (0 para encerrar): ");
//             numero = int.Parse(Console.ReadLine());
//             soma += numero;
//         } while (numero != 0);

//         Console.WriteLine("A soma total é: " + soma);

//         Console.ReadLine();
//     }
// }


//Exercício 7: Encontrar o Primeiro Múltiplo de 3 e 7
// class Program
// {
//     static void Main()
//     {
//         int numeroMultiplo = 0;

//         for (int i = 1; i <= 100; i++)
//         {
//             if (i % 3 == 0 && i % 7 == 0)
//             {
//                 numeroMultiplo = i;
//                 break;
//             }
//         }

//         if (numeroMultiplo != 0)
//         {
//             Console.WriteLine("O primeiro número múltiplo de 3 e 7 é: " + numeroMultiplo);
//         }
//         else
//         {
//             Console.WriteLine("Nenhum número múltiplo de 3 e 7 foi encontrado no intervalo de 1 a 100.");
//         }

//         Console.ReadLine();
//     }
// }


//Exercício 8: Fatorial de um Número
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Digite um número inteiro positivo: ");
//         int numero = int.Parse(Console.ReadLine());

//         if (numero < 0)
//         {
//             Console.WriteLine("O número deve ser positivo.");
//         }
//         else
//         {
//             long fatorial = 1; // Usamos long para acomodar fatoriais maiores

//             for (int i = 1; i <= numero; i++)
//             {
//                 fatorial *= i;
//             }

//             Console.WriteLine("O fatorial de " + numero + " é: " + fatorial);
//         }

//         Console.ReadLine();
//     }
// }