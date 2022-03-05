Console.WriteLine("введите число ");
string imputN = Console.ReadLine();
int N =int.Parse(imputN) ;
string [] arrey = new string []{"нет" ,"да","ни день недели"};
while(N > 0)
{
    if(N<6)Console.WriteLine(arrey[0]);
    break;
}
while(N>5)
{
    if(N < 8)Console.WriteLine(arrey[1]);
    break;
}
if(N > 7)Console.WriteLine(arrey[2]);
if(N < 1)Console.WriteLine(arrey[2]);

