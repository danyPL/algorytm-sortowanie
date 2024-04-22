using algorytm_sortowanie;

List<int> cyfry = new List<int>();
bool repeat = true;
Console.WriteLine("Podaj cyfry do arrayu np. 1,2,3,4");
string[] cyfryS = Console.ReadLine().Split(",");
foreach (string cyfra in cyfryS)
    cyfry.Add(int.Parse(cyfra));
int[] temp;

Sorting sort = new Sorting(cyfry.ToArray());
while (repeat)
{
    Console.Clear();
 Console.WriteLine("1. Znajdz najmniejsza");
    Console.WriteLine("2. Znajdz najwieksza");
    Console.WriteLine("3. Najmniejsza i podmien");
    Console.WriteLine("4. Posortuj");
    Console.WriteLine("5. Wyjdz");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine(sort.FindLowest());
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine(sort.FindHighest());
            Console.ReadKey();

            break;
        case "3":
        temp = sort.FindLowestAndExchange();
            foreach (int cyfra in temp)
                Console.Write($"{cyfra}, ");

            Console.ReadKey();

            break;
        case "4":
        temp = sort.Sort(cyfry.ToArray());
            foreach (int cyfra in temp)
                Console.Write($"{cyfra}, ");

            Console.ReadKey();

            break;
        case "5":
            repeat = false;
            break;
    }
}
   
