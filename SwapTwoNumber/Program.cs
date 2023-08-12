
//There are two ways to achive swapping

//    1 By using third variable
int a = 10;
int b = 20;
int temp;
Console.WriteLine($"Befor swap value a = {a}, b = {b}");

temp = a; //10
a = b;    //20
b = temp; //10

Console.WriteLine($"After swap value a = {a}, b = {b}");

//2 whit out thred variable

int c = 10;
int d = 20;
Console.WriteLine($"Befor swap value c = {c}, d = {d}");

c = c + d;
d = c - d;
c = c - d;
Console.WriteLine($"After swap value c = {c}, d = {d}");


