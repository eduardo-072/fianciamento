Console.WriteLine("-----FAÇA SEU FINANCIAMENTO-----\n");

Console.WriteLine("Digite o valor total do produto...");

decimal vlTotal = Convert.ToDecimal(Console.ReadLine());
int qtParcela;

Console.Write("Financiamento em quantas vezes?...");
qtParcela = Convert.ToInt32 (Console.ReadLine());

decimal vlParcela = vlTotal / qtParcela;

Console.WriteLine($"Você pagará {qtParcela} parcelar de R$ {vlParcela}");
Console.WriteLine("\nOBRIGADO POR COMPRAR CONOSCO !!!");  

