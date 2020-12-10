using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    class l33tvalues{                       //Class for storing l33t values
        public string a="4";
        public string b="6";
        public string e = "3";
        public string i="|";
        public string l = "1";
        public string m = "(V)";
        public string n = @"(\)";
        public string o = "0";
        public string s = "5";
        public string t = "7";
        public string v = @"\/";
        public string w = "`//";            //All l33t values
    }
    class Temp{                             //Class for storing variables
        public string input;
        public bool is_it_l33t;

    }
    static void Main(string[] args)            // Main program
    {
        Temp temp=new Temp();
        l33tvalues l33TVal=new l33tvalues();            //Class declarations
        temp.input  =Console.ReadLine().ToLower();        //Takes user input
        temp.is_it_l33t =l33tcheck(temp.input);       //Checks whether its ASCII or L33T
        if(temp.is_it_l33t ==true){                   //If its L33T then it gets converted to ASCII
            Console.WriteLine(ascii(temp.input));
        }
        else{                                           // If its ASCII it gets converted into L33T
            Console.WriteLine(l33t(temp.input));    
        }

        
        Console.ReadKey();
    }
    static public bool l33tcheck(string x){         //Returns true or false to check whether the user input is ASCII or L33T
        l33tvalues l33TVal = new l33tvalues();
        Temp temp = new Temp();

        if(x.Contains(l33TVal.a) ||x.Contains(l33TVal.b) ||x.Contains(l33TVal.e) ||
        x.Contains(l33TVal.i) ||x.Contains(l33TVal.l) ||x.Contains(l33TVal.m) ||
        x.Contains(l33TVal.n) ||x.Contains(l33TVal.o) ||x.Contains(l33TVal.s) ||
        x.Contains(l33TVal.t) ||x.Contains(l33TVal.v) ||x.Contains(l33TVal.w)){
            return true;
        }
        else{
            return false;
        }
    }

    static public string l33t(string x){               // Converts ASCII input into L33T
        l33tvalues l33TVal=new l33tvalues();
        Temp temp = new Temp();

        x=x.Replace("a", l33TVal.a);
        x =x.Replace("b", l33TVal.b);
        x =x.Replace("e", l33TVal.e);
        x=x.Replace("i", l33TVal.i);
        x=x.Replace("l", l33TVal.l);
        x = x.Replace("m", l33TVal.m);
        x = x.Replace("n", l33TVal.n);
        x = x.Replace("o", l33TVal.o);
        x = x.Replace("s", l33TVal.s);
        x = x.Replace("t", l33TVal.t);
        x = x.Replace("v", l33TVal.v);
        x = x.Replace("w", l33TVal.w);

        return x;
    }
    static public string ascii(string x)                //Converts L33T input into ASCII
    {
        l33tvalues l33TVal=new l33tvalues();
        Temp temp = new Temp();

        x = x.Replace(l33TVal.a, "a");
        x = x.Replace(l33TVal.b,"b");
        x = x.Replace(l33TVal.e,"e");
        x = x.Replace(l33TVal.i, "i");
        x = x.Replace(l33TVal.l,"l");
        x = x.Replace(l33TVal.m,"m");
        x = x.Replace( l33TVal.n,"n");
        x = x.Replace( l33TVal.o,"o");
        x = x.Replace(l33TVal.s,"s");
        x = x.Replace(l33TVal.t,"t");
        x = x.Replace(l33TVal.v, "v" );
        x = x.Replace(l33TVal.w, "w" );

        return x;
    }
}
//Q26 of Basic
//Q6 of Basic Algorithm
