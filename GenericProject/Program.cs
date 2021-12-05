class Comparison
{
    public static int FindMaxIntNumber(int first, int second, int third)
    {
        if ((first.CompareTo(second) >0)&&(first.CompareTo(third)>0))
        {
            return first;
        }
        else if ((second.CompareTo(first)>0)&&(second.CompareTo(third)>0))
        {
            return second;
        }
        else if ((third.CompareTo(second)>0)&&(third.CompareTo(first)>0))
        {
            return third;
        }
        else
        {

            return default;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int max = FindMaxIntNumber(a, b, c);
        if (max==0)
        {
            Console.WriteLine("All three numbers are equal!!!");
        }
        else
        {
            Console.WriteLine("Maximum among three:"+max);
        }
    }
}
