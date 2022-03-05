Console.WriteLine("введите  число ");
string strN = Console.ReadLine();
int N = int.Parse(strN);
int A = 0;
while(A<N)
{
    if(N%2==1)N=N-1;
    A=A+2;
    Console.Write(A + " ");
}
Console.WriteLine(" <-четные числа ");

