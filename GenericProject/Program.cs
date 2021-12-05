using GenericProject;

           int[] arr = {1, 2, 3, 4, 5};
GenericMaximum<int> obj=new GenericMaximum<int>(arr);
obj.PrintMaxValueOfArray();
string[] Stringarr = { "abc", "efg", "hij" };

GenericMaximum<string> obj1=new GenericMaximum<string>(Stringarr);
obj1.PrintMaxValueOfArray();
char[] Chararr = { 'a', 'b', 'c', };
GenericMaximum<char> obj2=new GenericMaximum<char>(Chararr);
obj2.PrintMaxValueOfArray();
float[] Floatarr = { 1.1f, 1.2f, 1.3f };
GenericMaximum<float> obj3=new GenericMaximum<float>(Floatarr);
obj3.PrintMaxValueOfArray();

            
        
    