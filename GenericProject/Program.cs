class Comparison
{
    public static string FindMaxFloatNumber(string first, string second, string third)
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
        Console.WriteLine("Enter three words:");
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();
        string word3 = Console.ReadLine();


        string maxString = FindMaxFloatNumber(word1, word2, word3);

        if (maxString==null)
        {
            Console.WriteLine("All three numbers are equal!!!");
        }
        else
        {
            Console.WriteLine("Maximum among three:"+maxString);
        }
    }
}
