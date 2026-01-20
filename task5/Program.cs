

List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
Console.WriteLine("The filtered numbers are:");
List<int> evenumbers= numbers.FindAll(n => n%2==0);
foreach(int number in evenumbers)
{
    Console.Write($"{number} ");
}