Console.WriteLine("введите число");
string imputN = Console.ReadLine();
int N = int.Parse(imputN);
Console.WriteLine("предпоследнее число -  " + (N%100/10));