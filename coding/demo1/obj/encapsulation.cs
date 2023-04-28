using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo1.obj
{
    public class encapsulation
    {
  
    private string name;
    private int age;

    public string Name{
        get{return name;}
        set{name=value;}
    }
    public int Age{
        get{return age;}
        set{age=value;}
    }
     public void greetings(){
        Console.WriteLine("My name is "+name+" and I am "+age+" years of old");
     }
}
class Program{
    static void Main(string[] args){
        encapsulation obj1=new encapsulation();
        obj1.Name="Sampath";
        obj1.Age=23;
        obj1.greetings();
    }
}

    }