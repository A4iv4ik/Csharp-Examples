int [] ar = {11, 21, 452, 5455, 331, 45,44,678,567};

int n = ar.Length;
int find = 44;

int index = 0;

while(index< n)
{
   if(ar[index] == find)
   {
       Console.WriteLine(index);
       break;
   }
    index++;
}
