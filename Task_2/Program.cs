Console.Write("Enter the first number: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int number2 = int.Parse(Console.ReadLine());

if (number1*number1 == number2 | number2*number2 == number1){
    Console.Write("Your numbers are multiple of each other");
}
else{
    Console.Write("Your numbers are not multiple of each other");
}