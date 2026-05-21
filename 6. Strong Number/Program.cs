using System.Globalization;

int input = int.Parse(Console.ReadLine());

int currentNumber = 0;
int factorial = 1;
int sum = 0;

string inputString = input.ToString();

for (int i = inputString.Length - 1; i >= 0; i--)
{
    currentNumber = int.Parse(inputString[i].ToString());

    if (currentNumber != 0)
    {
        for (int j = 1; j <= currentNumber; j++)
        {
            factorial *= j;

        }
    }
    sum+=factorial;
    factorial = 1;
}
if (sum == input)
{
    Console.WriteLine("yes");
}
else 
{
    Console.WriteLine("no");
}