int num, a, sum=0;
System.Console.WriteLine("Enter a number:");
num=int.Parse(Console.ReadLine());
while (num != 0)
{
    a = num % 10 ;
    num = num / 10 ;
    sum = sum + a ;
}

System.Console.WriteLine("sum argham adad=" + sum);
 