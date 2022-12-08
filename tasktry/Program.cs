

//Task1
Console.WriteLine("Eded daxil edin: ");
int eded = Convert.ToInt32(Console.ReadLine());
if (eded != 0)
{
    if (eded % 2 == 0)
    {
        Console.WriteLine(eded / 2);
    }
    else
    {
        Console.WriteLine(eded * 2);
    }
}
else
{
    Console.WriteLine("0-dan ferqli eded daxil et");
}

//Task2
int sum = 0;
for (int i = 0; i < 11; i++)
{
    sum += i;

}
Console.WriteLine(sum);


//Task3
int bolunenler = 0;
for (int i = 1; i < 101; i++)
{
    if (i % 5 == 0)
    {
        bolunenler++;
    }

}
Console.WriteLine(sum);



//Task4
string str = Console.ReadLine();

char[] ch = new char[str.Length];

for (int i = 0; i < str.Length; i++)
{
    ch[i] = str[i];
}

for(int i = 0; i < ch.Length; i++)
{
    if(ch[i] == ',')
    {
        ch[i] = '.';
    }
}
string newString = string.Join("", ch);
Console.WriteLine(newString);


//Task 5



Console.WriteLine("Yasinizi daxil edin: ");
int age = Convert.ToInt32(Console.ReadLine());
if (age > 0)
{
    if (age >= 18)
    {
        Console.WriteLine("Suruculuk vesiqesi ala bilersinisz");
    }
    else
    {
        Console.WriteLine(18 - age + " il sonra vesiqeni ala bilersiniz");
    }
}
else
{
    Console.WriteLine("zehmet olmasa musbet eded daxil edin");
}