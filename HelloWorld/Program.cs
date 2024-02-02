
Console.WriteLine("Digite sua velocidade em km/h: ");
int velocidade = int.Parse(Console.ReadLine());




double velMetros = (double)velocidade / 3.6;
Console.WriteLine("Sua velocidade em m/s é: " + velMetros);
Console.WriteLine();
float tempo = 435 / velocidade;
Console.WriteLine("O tempo que irá levar para completar esse trajeto é: " + tempo);





