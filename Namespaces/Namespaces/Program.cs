using System;

//PATA and PATB are namespace alliases
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

class Program
{
    static void Main(string[] args)
    {
        //now invoke print() without ambiguity
        PATA.ClassA.print();
        PATB.ClassA.print();
    }

}

//Namespaces
//They help organize and assisst avoid names clashes
