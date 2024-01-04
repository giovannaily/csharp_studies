using C_.models;


// int [] arrayInteiros = new int [4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// for (int contador =0; contador < arrayInteiros.Length; contador ++)
// {
//     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
// }

// foreach(int valor in  arrayInteiros)
// {
//     Console.WriteLine(valor);
// }

// Array.Resize(ref arrayInteiros, arrayInteiros.Length + 4);

////////////////////////////////////////////////////

// string opcao;

// bool exibirMenu = true; 

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opcao:");
//     Console.WriteLine("1 - cadastrar cliente");
//     Console.WriteLine("2 - buscar cliente");
//     Console.WriteLine("3 - apagar cliente");
//     Console.WriteLine("4 - encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//         Console.WriteLine("Cadastro de cliente");
//         break;

//         case "2":
//         Console.WriteLine("Busca de cliente");
//         break;

//         case "3":
//         Console.WriteLine("Apagar cliente");
//         break;

//         case "4":
//         Console.WriteLine("Encerrar");
//         exibirMenu = false;
//         break;

//         default:
//         Console.WriteLine("Opção invalida");
//         break;
//     }
// }

// Console.WriteLine("O programa se encerrou");


////////////////////////////////////////////////////////////////////////////////



// int soma = 0, numero = 0;
// do 
// {
//     Console.WriteLine("Digite um número: (0 para parar) ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0 );

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");






// int numero =5;
// int contador =0;

// while(contador <=10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador ++;
// }



// int numero = 5;


// for(int contador = 0; contador <=100; contador++)
// {
//     Console.WriteLine($"{numero} X {contador} = {numero * contador}");
// }









// Calculadora calc = new Calculadora();

// calc. Potencia(3,3);

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Divisor(2, 2)





// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;

// }

//////////////////////////////////////////////////////////////////////////////////////////////////////

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal.");
// }

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda?: {possivelVenda}");

// if (possivelVenda)
// {
//    Console.WriteLine("Venda realizada."); 
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos quantidade desejada em estoque.");
// }

///////////////////////////////////////////////////////////////////////////////////////////////////

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Anna";
// pessoa1.Idade = 26;
// pessoa1.Apresentar();

// Pessoa pessoa2 = new Pessoa();

// pessoa2.Nome = "Luís";
// pessoa2.Idade = 33;
// pessoa2.Apresentar();