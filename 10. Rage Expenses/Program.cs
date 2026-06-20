int lostGames = int.Parse(Console.ReadLine());

double headsetPrice = double.Parse(Console.ReadLine());

double mousePrice = double.Parse(Console.ReadLine());

double keyboardPrice = double.Parse(Console.ReadLine());

double displayPrice = double.Parse(Console.ReadLine());


double totalHeadsetPrice = headsetPrice * (lostGames / 2);

double totalMousePrice = mousePrice * (lostGames / 3);

double totalKeyboardPrice = keyboardPrice * (lostGames / 6);

double totalDisplayPrice = displayPrice * (lostGames / 12);

double totalRageExpenses = totalHeadsetPrice + totalMousePrice + totalKeyboardPrice + totalDisplayPrice;

Console.WriteLine($"Rage expenses: {totalRageExpenses:f2} USD");