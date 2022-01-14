int [] ar = {11, 21, 452, 5455, 331, 45,44,678,567};
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result =arg3;
    return result;
}
ar[0] = 12 ;
int maxmax = Max(Max(ar[0],ar[1],ar[2]), Max(ar[3],ar[4],ar[5]),Max(ar[6],ar[7],ar[8]));
Console.Write(maxmax);