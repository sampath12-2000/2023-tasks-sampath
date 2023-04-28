using System;
using System.Collections.Generic;

class dictionary{
static void Main(string[] args){
    Dictionary<string,int> ages=new Dictionary<string, int>();

    ages.Add("Siva",53);
    ages.Add("Babita",43);
    ages.Add("Sampath",23);
    ages.Add("Saranya",26);
    ages.Add("Sabarish",30);

   // Console.WriteLine(ages["Babita"]);

    if(ages.ContainsKey("Saranya")){
        Console.WriteLine("Saranya's age is "+ages["Saranya"]);
    }

    foreach(KeyValuePair<string,int> kvp in ages){
        Console.WriteLine(kvp.Key + " is "+ kvp.Value+" years old");
    }
}
}