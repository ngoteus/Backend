// string name= "Mateus";
// Console.WriteLine(name);

// //int idade= 36;
// //idade= 17;
// const int idade = 17;

// Console.WriteLine("A Idade do " + name + " E " + idade);

// float preco= 9.99F;

// Operadores

// Atribuicao
// int x =15;

// Operadores aritmeticos
// soma
// Console.WriteLine(5+4);
// Console.WriteLine(5 + "4");
// Console.WriteLine(5+x);

// // subtracao
// Console.WriteLine(15 - 3);
// // multiplicacao
// Console.WriteLine(5*5);
// // divisao
// Console.WriteLine(10/10);

// Operacao de comparacao

//igual a 
Console.WriteLine( 5 == 7);

// maior ou igual a 
Console.WriteLine( 5 >= 4);
// menor ou igual a

// maior que

// menor que

// diferente de

//operadores lógicos

// && : e
// || : ou 
// ! : não

// Console.WriteLine(5 == 5 && 8 == 8);// TRUE && TRUE = TRUE
// Console.WriteLine(5 == 5 && 8 == 5);// TRUE && FALSE = FALSE
// Console.WriteLine(5 == 6 && 8 == 8);// FALSE && TRUE = FALSE
// Console.WriteLine(5 == 6 && 8 == 5);// FALSE && FALSE = FALSE

// Console.WriteLine(2 == 2 || 3 == 3);// TRUE || TRUE = TRUE
// Console.WriteLine(2 == 2 || 3 == 4);// TRUE || FALSE = TRUE
// Console.WriteLine(2 == 4 || 3 == 3);// FALSE || TRUE = TRUE
// Console.WriteLine(2 == 4 || 3 == 5);// FALSE || FALSE = FALSE

// Console.WriteLine((2 == 4 || 4 == 4) && (7 == 6));

// Console.WriteLine(!(2 == 2 || 3 == 3));

//Crie um programa para calcular o IMC de uma pessoa

//Algoritmo
//nome, idade, peso e altura
// processamento: peso dividido por altura ao quadrado

string nome = "Mateus";
int idade = 17;
float peso= 82;
float altura= 1.91F;

//processamento 
float imc = peso / (altura*altura);

//saida
Console.WriteLine( "O IMC do " + nome + "e de : " +Math.Round (imc,2));