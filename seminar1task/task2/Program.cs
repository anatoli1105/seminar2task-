Console.WriteLine("введите первое число ");
string strNoumberA = Console.ReadLine();
int NoumberA = int.Parse(strNoumberA);

Console.WriteLine("введите второе число ");
string strNoumberB = Console.ReadLine();
int NoumberB = int.Parse(strNoumberB);

Console.WriteLine("введите третье число ");
string strNoumberC = Console.ReadLine();
int NoumberC = int.Parse(strNoumberC);
int Max=NoumberA;

Console.Write("max=");

if(NoumberA > NoumberB) 
{
    Max = NoumberA;
}
if(NoumberB > Max)
{
    Max = NoumberB;
}
if(NoumberC > Max)
{

    Max = NoumberC;
}
Console.Write(Max);
