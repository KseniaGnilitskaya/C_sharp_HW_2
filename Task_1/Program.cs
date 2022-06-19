
Console.Write("Enter number from 1 to 7: ");
int number = int.Parse(Console.ReadLine());

if(number == 1 | number == 2 | number == 3 | number == 4 | number == 5 ) {
    Console.Write("No, unfortunately. You have to work.");
}
if(number == 6 | number == 7){
    Console.Write("Yes! It's a day-off :)");
}
else {
    Console.Write("Please, enter number from 1 to 7: ");
}