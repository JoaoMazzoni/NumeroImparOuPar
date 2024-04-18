int n1;


Console.WriteLine("Digite um número: ");
n1 = int.Parse(Console.ReadLine());
if (n1 == 0)
{
    Console.WriteLine("O número zero é um número neutro.");
}

else 
{ 
    if (n1%2 == 0)
    {
        Console.WriteLine("O número {0} é par.", n1);
    }

    else 
    {
        Console.WriteLine("O número {0} é ímpar.", n1);
    }

}

Console.ReadKey();