
using System.Reflection.Metadata;

for (int idx = 1;idx <= 30;idx++)
{
   bool div3 = (idx % 3 == 0) ? true : false;
    bool div5 = (idx % 5 == 0) ? true : false;
    bool div3n5 = div3 && div5;
    if (div3n5)
    {
        Console.WriteLine("FIZZBUZZ");
        continue;
    }
    if(div5)
    {
        Console.WriteLine("BUZZ");
        continue;
    }
    if(div3)
    {
        Console.WriteLine("FIZZ");
        continue;
    }
    Console.WriteLine($"{idx}");
}
