//find the radius of an input
using System;

class Radius 
{
    double pi = 3.14159;
   
  
    double area;

    double radius;

    
    public void CalulateArea()
    {
       Console.Write("Please enter a value of a radius: ");

         
         String input = Console.ReadLine();

        if(!double.TryParse(input, out radius))
        {
            Console.WriteLine("please enter a valid number");
            return;
        }
        area = pi * radius * radius;


        Console.WriteLine("the area of a circle with " + radius + " is: " + area);
    }
}