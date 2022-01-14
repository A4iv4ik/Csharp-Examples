int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result =arg3;
    return result;
}
int a = 12;
int b= 22;
int c = 34;
int d = 2;
int f = 123;
int g = 111;
int r = 12;
int p =99;
int h = 90;
//int max1 = Max(a,b,c);
//int max2 = Max(d,f,g);
//int max3 = Max(r,p,h);
//int max4 =Max(max1,max2,max3);
int max5 = Max(Max(a,b,c),Max(d,f,g),Max(r,p,h));
Console.WriteLine(max5);
