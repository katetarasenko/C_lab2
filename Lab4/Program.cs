using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 class Myclass
{
    private string internal_par_1;
    public string external_par_1;
    public int class_atr_1;
    public Myclass(int class_atribute = -1)
    {
        class_atr_1 = class_atribute;
        internal_par_1 = "start value";
        external_par_1 = "start";
        Console.WriteLine($"Hello from constructor, atr1 ={class_atr_1} ");
    }
    public void change_int_par_1(string new_value) 
    {
        string internal_par_1 = new_value;
        Console.WriteLine("internal parameter changed, new value = " + internal_par_1);
    }

    public string get_par_1() 
    {
        return internal_par_1;
    }
    ~Myclass()
    {
        Console.WriteLine("Destructor");
    }
}
class Program
{

 
    static void Main()
    {
        Console.WriteLine("Hello");
        Myclass class1 = new Myclass();
        class1.external_par_1 = "hi";
        class1.change_int_par_1("NEW VALUE");
        string s = class1.get_par_1();
        Console.WriteLine(s);
        Myclass class2 = new Myclass(2);
        Console.ReadLine();
    }

 
}

