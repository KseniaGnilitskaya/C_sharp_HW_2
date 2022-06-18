Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());

string str = number.ToString();

if (number < 99){
    Console.Write("There is no third digit");
}
else{
    Console.Write($"The third digit is {str[2]}");
}
