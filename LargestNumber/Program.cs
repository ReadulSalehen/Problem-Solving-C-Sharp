
//Largest Number Between 2 or 3 number

// 2 numbers
int a = 10;
int b = 15;

if (a > b)
{
    Console.WriteLine("a is grater");
}
else
{
    Console.WriteLine("b is grater");
}

// 3 numbers
int c = 10;
int d = 15;
int e = 5;

if (c > d)
{
    if (c > e)
    {
        Console.WriteLine("c is grater");
    }
    else
    {
        Console.WriteLine("e is grater");
    }
    
}
else
{
    if (d > e)
    {
        Console.WriteLine("d is grater");
    }
    else 
    { 
        Console.WriteLine("e is grater"); 
    }
}