using ConversorMoeda;
using System.Globalization;
using System.Runtime.CompilerServices;




Console.WriteLine("Qual é a cotação do dólar? ");
double dolar = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Quantos dólares deseja comprar? ");
double qte = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double result = Conversor.DolarParaReal(qte, dolar);

Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));


//Como estava antes de correção

//Console.WriteLine("Qual é a cotação do dólar? ");
//double dolar = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//Conversor.CotacaDollar(dolar);
//Console.WriteLine("Quantos dólares deseja comprar? ");
//double qte = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//Conversor.QuantidadeDollarCompra(qte);

//double total = dolar * qte;

//Console.WriteLine("Valor a ser pago em reais: " + Conversor.TotalEmReais(total).ToString("F2", CultureInfo.InvariantCulture));


