Console.WriteLine("введите число");
string imputN = Console.ReadLine();
int N = int.Parse(imputN);
while(N<1000)
{
    if(N>100)
        {
            Console.Write("третья цифра ->  " + N%10);
            break;
        }
        else
        {
            Console.Write("нет последней цифры");
            break;
        }
      
}        
if(N > 1000)
{
    Console.Write("третья цифра -> " + N/10/10%10);
}