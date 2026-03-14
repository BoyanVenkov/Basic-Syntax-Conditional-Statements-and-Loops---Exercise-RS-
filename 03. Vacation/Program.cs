using System.Globalization;

int peopleCount = int.Parse(Console.ReadLine());

string type = Console.ReadLine();

string day = Console.ReadLine();

double totalPrice = 0;

if (day == "Friday")
{
    if (type == "Students")
    {
        if (peopleCount < 30)
        {
            totalPrice = peopleCount * 8.45;
        }
        else
        {
            totalPrice = peopleCount * 8.45 * 0.85;
        }
    }
    else if (type == "Business")
    {
        if (peopleCount >= 100)
        {
            totalPrice = (peopleCount - 10) * 10.90;
        }
        totalPrice = peopleCount * 10.90;
    }
    else
    {
        if (peopleCount >= 10 && peopleCount <= 20)
        {
            totalPrice = peopleCount * 15 * 0.95;
        }
        else
        {
            totalPrice = peopleCount * 15;
        }
    }
}
if (day == "Saturday")
{
    if (type == "Students")
    {
        if (peopleCount < 30)
        {
            totalPrice = peopleCount * 9.80;
        }
        else
        {
            totalPrice = peopleCount * 9.80 * 0.85;
        }
    }
    else if (type == "Business")
    {
        if (peopleCount >= 100)
        {
            totalPrice = (peopleCount - 10) * 15.60;
        }
        else
        {
            totalPrice = peopleCount * 15.60;
        }
    }
    else
    {
        if (peopleCount >= 10 && peopleCount <= 20)
        {
            totalPrice = peopleCount * 20 * 0.95;
        }
        else
        {
            totalPrice = peopleCount * 20;
        }
    }
}
if (day == "Sunday")
{
    if (type == "Students")
    {
        if (peopleCount < 30)
        {
            totalPrice = peopleCount * 10.46;
        }
        else
        {
            totalPrice = peopleCount * 10.46 * 0.85;
        }
    }

    else if (type == "Business")
    {
        if (peopleCount >= 100)
        {
            totalPrice = (peopleCount - 10) * 16;
        }
        else
        {
            totalPrice = peopleCount * 16;
        }

    }
    else
    {
        if (peopleCount >= 10 && peopleCount <= 20)
        {
            totalPrice = peopleCount * 22.50 * 0.95;
        }
        else
        {
            totalPrice = peopleCount * 22.50;
        }

    }
}

Console.WriteLine($"Total price: {totalPrice:f2}");