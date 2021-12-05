using GenericProject;

           int[] arr = {1, 2, 3, 4, 5};
GenericMaximum<int> obj=new GenericMaximum<int>(arr);
obj.PrintMaxValue();
string[] Stringarr = { "abc", "efg", "hij" };

GenericMaximum<string> obj1=new GenericMaximum<string>(Stringarr);
obj1.PrintMaxValue();
char[] Chararr = { 'a', 'b', 'c', };
GenericMaximum<char> obj2=new GenericMaximum<char>(Chararr);
obj2.PrintMaxValue();

            
        
    