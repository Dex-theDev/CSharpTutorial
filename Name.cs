//namespace
using System;

//program start
class Name {
    
    
    public void print(){
        //write to console
        Console.WriteLine("enter your name");

        //read from console.
        String? name = Console.ReadLine();

        //writing the string and adding name;
        Console.WriteLine("hello, {0}", name);

        //keep program running till user clicks run
        Console.ReadLine();
    
    }
}