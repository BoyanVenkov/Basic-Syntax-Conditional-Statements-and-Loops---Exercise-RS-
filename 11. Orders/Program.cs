int n = int.Parse(Console.ReadLine());

double totalPrice = 0;

for (int i = 1; i <= n; i++)
{ 
    double price = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsules = int.Parse(Console.ReadLine());

    double orderPrice = price * days * capsules;

    totalPrice += orderPrice;
    Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");

}
Console.WriteLine($"Total: ${totalPrice:f2}");