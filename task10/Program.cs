

List<int> randomNumbers = new List<int>();
Random rnd = new Random();

for (int i = 0; i < 5; i++)
{
    randomNumbers.Add(rnd.Next(1, 100));
}

Console.WriteLine("Ададҳои тасодуфӣ:");
foreach (int n in randomNumbers)
{
    Console.WriteLine(n);
}