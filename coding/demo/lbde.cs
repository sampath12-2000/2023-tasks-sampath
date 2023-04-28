using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication1{
    public class le
    {
        static void Main(string[] args){
            List<int> numbers=new List<int>() {36,71,12,15,29,18,27,17,9,34};
            Console.Write("The List : ");
            foreach(var value in numbers){
                Console.Write("{0}",value);
            }
            Console.WriteLine();
            //using lambda expression cal square of each val
            var square= numbers.Select(x=>x*x);
            Console.Write("Squares :");
            foreach(var value in square){
                Console.Write("{0}",value);

            }
            Console.WriteLine();
        }
    }
}




