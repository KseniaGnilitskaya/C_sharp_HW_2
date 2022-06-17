Console.Write("Enter the first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int number2 = int.Parse(Console.ReadLine());

if (number1*number1 == number2){
    Console.Write($"{number2} is a square of {number1}");
}
else{
    Console.Write($"{number2} is not a square of {number1}");
}