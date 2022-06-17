Console.Write("Enter the number from 100 to 999: ");
int number = int.Parse(Console.ReadLine());

string str = number.ToString();
Console.Write("The second digit is: ");
Console.Write(str[1]);
