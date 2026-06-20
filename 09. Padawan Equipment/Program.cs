double money = double.Parse(Console.ReadLine());

int students = int.Parse(Console.ReadLine());

double lightSaberPrice = double.Parse(Console.ReadLine());

double robePrice = double.Parse(Console.ReadLine());

double beltPrice = double.Parse(Console.ReadLine());


double totalLightSaberPrce = lightSaberPrice * (students + Math.Ceiling(students * 0.10));

double totalRobePrice = robePrice * students;

double totalBeltPrice = beltPrice * (students - students / 6);

double totalPrice = totalLightSaberPrce + totalRobePrice + totalBeltPrice;


if (totalPrice <= money)
{
    Console.WriteLine($"The money is enough - it would cost {totalPrice:f2} USD.");
}
else
{
    Console.WriteLine($"John will need {totalPrice - money:f2} USD more.");
}