string input = Console.ReadLine();
double totalMoney = 0;

// Първи цикъл: Събиране на монети
while (input != "Start")
{
    double coin = double.Parse(input);
    if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
    {
        totalMoney += coin;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coin}");
    }

    input = Console.ReadLine();
}

input = Console.ReadLine();

while (input != "End")
{
    if (input == "Nuts")
    {
        if (totalMoney - 2 >= 0)
        {
            Console.WriteLine($"Purchased {input.ToLower()}");
            totalMoney -= 2.0;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Water")
    {
        if (totalMoney - 0.7 >= 0)
        {
            Console.WriteLine($"Purchased {input.ToLower()}");
            totalMoney -= 0.7;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Crisps")
    {
        if (totalMoney - 1.5 >= 0)
        {
            Console.WriteLine($"Purchased {input.ToLower()}");
            totalMoney -= 1.5;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Soda")
    {
        if (totalMoney - 0.8 >= 0)
        {
            Console.WriteLine($"Purchased {input.ToLower()}");
            totalMoney -= 0.8;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else if (input == "Coke")
    {
        if (totalMoney - 1.0 >= 0)
        {
            Console.WriteLine($"Purchased {input.ToLower()}");
            totalMoney -= 1.0;
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }

    input = Console.ReadLine();
}

Console.WriteLine($"Change: {totalMoney:F2}");