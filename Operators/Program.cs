using System.Threading.Channels;

int x = 10;
int y = 20;

Console.WriteLine($"x is {x} and y is {y}");

Console.WriteLine("x is {0}, and y is {1}", x, y);

int sum = x + y;
Console.WriteLine(sum);

int subtract = x - y;
Console.WriteLine(subtract);


//x=10
int k = ++x; // k=11
Console.WriteLine($"k={k}");
Console.WriteLine($"x={x}");

//x=11
k = x++;
Console.WriteLine($"k={k}");
Console.WriteLine($"x={x}");

//x=12


int booleanOr = 3 | 5;
//.....000011    
//.....000101
//.....000111
//<<1

//2^0*1+2^1*1+2^2*1.... =7

Console.WriteLine(booleanOr);
//.....000111
//<<1
//.....001110
Console.WriteLine(booleanOr << 1);

int d = 12;
int f = 32;

bool b1 = d > f || d > 5;
bool b2 = d > f && d > 5;

Console.WriteLine(b1);
Console.WriteLine(b2);

Console.WriteLine(5 % 2);

int x1, x2, x3;

x1 = x2 = x3 = 10;


//x1+=10;
//x1=x1+10;
x1 *= 3;
Console.WriteLine(x1);

int a = 20, b = 30;
//cast
Console.WriteLine((double)a / b);


string s = null;

s ??= "asd"; //s = s == null ? "asd" : s;
Console.WriteLine(s);
