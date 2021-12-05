class Comparison
{
    public static float FindMaxFloatNumber(float first, float second, float third)
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
        Console.WriteLine("Enter three float numbers:");
        float firstfloat = Convert.ToSingle(Console.ReadLine());

        float secondfloat = Convert.ToSingle(Console.ReadLine());
        float thirdfloat = Convert.ToSingle(Console.ReadLine());
        float maxfloat = FindMaxFloatNumber(firstfloat, secondfloat, thirdfloat);
        if (maxfloat==0)
        {
            Console.WriteLine("All three numbers are equal!!!");
        }
        else
        {
            Console.WriteLine("Maximum among three:"+maxfloat);
        }
    }
}
