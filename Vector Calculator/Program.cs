using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test1 = new Vector(0, 0, 0);
            Vector test2 = new Vector(0, 0, 0);

            Console.WriteLine("Welcome to vector calculator.");
            bool run = true;

            while (run)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("a) change vector 1 - " + test1);
                Console.WriteLine("b) change vector 2 - " + test2);
                Console.WriteLine("c) get the magnitude of a vector");
                Console.WriteLine("d) get direction of a vector");
                Console.WriteLine("e) add vectors");
                Console.WriteLine("f) negate a vector");
                Console.WriteLine("g) subtract vectors");
                Console.WriteLine("h) scale a vector");
                Console.WriteLine("i) normalize a vector");
                Console.WriteLine("j) find the dot product of two vectors");
                Console.WriteLine("k) find the cross product of two vectors");
                Console.WriteLine("l) find the angle between two vectors");
                Console.WriteLine("m) project a vector");
                Console.WriteLine("n) exit vector calculator");
                string input = Console.ReadLine();
                if (input == "a")
                {
                    //change the values of vector 1
                    while (input == "a")
                    {
                        Console.WriteLine("\nType an x value");
                        input = Console.ReadLine();
                        try
                        {
                            float.Parse(input);
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Invalid Input.");
                            input = "a";
                        }
                    }
                    test1.x = float.Parse(input);
                    input = "a";
                    while (input == "a")
                    {
                        Console.WriteLine("\nType a y value");
                        input = Console.ReadLine();
                        try
                        {
                            float.Parse(input);
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Invalid Input.");
                            input = "a";
                        }
                    }
                    test1.y = float.Parse(input);
                    input = "a";
                    while (input == "a")
                    {
                        Console.WriteLine("\nType a z value");
                        input = Console.ReadLine();
                        try
                        {
                            float.Parse(input);
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Invalid Input.");
                            input = "a";
                        }
                    }
                    test1.z = float.Parse(input);
                    Console.WriteLine("Here is your new vector: " + test1);
                }
                else if (input == "b")
                {
                    //change the values of vector 2
                    while (input == "b")
                    {
                        Console.WriteLine("\nType an x value");
                        input = Console.ReadLine();
                        try
                        {
                            float.Parse(input);
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Invalid Input.");
                            input = "b";
                        }
                    }
                    test2.x = float.Parse(input);
                    input = "b";
                    while (input == "b")
                    {
                        Console.WriteLine("\nType a y value");
                        input = Console.ReadLine();
                        try
                        {
                            float.Parse(input);
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Invalid Input.");
                            input = "b";
                        }
                    }
                    test2.y = float.Parse(input);
                    input = "b"; 
                    while (input == "b")
                    {
                        Console.WriteLine("\nType a z value");
                        input = Console.ReadLine();
                        try
                        {
                            float.Parse(input);
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Invalid Input.");
                            input = "b";
                        }
                    }
                    test2.z = float.Parse(input);
                    Console.WriteLine("Here is your new vector: " + test2);
                }
                else if (input == "c")
                {
                    //will calculate the magnitude of a vector
                    while ( input == "c")
                    {
                        Console.WriteLine("\nWhich vector do you want to get the magnitude of?");
                        Console.WriteLine("v1) " + test1);
                        Console.WriteLine("v2) " + test2);
                        input = Console.ReadLine();
                        if (input == "v1")
                        {
                            Console.WriteLine("The magnitude of v1 is: " + test1.GetMagnitude());
                        }
                        else if (input == "v2")
                        {
                            Console.WriteLine("The magnitude of v2 is: " + test2.GetMagnitude());
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                            input = "c";
                        }
                    }
                    
                }
                else if (input == "d")
                {
                    //gets the direction of a vector
                    while (input == "d")
                    {
                        Console.WriteLine("\nWhich vector do you want to get the direction of?");
                        Console.WriteLine("v1) " + test1);
                        Console.WriteLine("v2) " + test2);
                        input = Console.ReadLine();
                        if (input == "v1")
                        {
                            Console.WriteLine("The direction of " + test1 + " is: " + test1.GetDirection() + " deg");
                        }
                        else if (input == "v2")
                        {
                            Console.WriteLine("The direction of " + test2 + " is: " + test2.GetDirection() + " deg");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                            input = "d";
                        }
                    }
                }
                else if (input == "e")
                {
                    //adds two vectors
                    Console.WriteLine(test1 + " + " + test2 + " = " + Vector.Add(test1, test2));
                }
                else if (input == "f")
                {
                    //negates a vector
                    while (input == "f")
                    {
                        Console.WriteLine("\nWhich vector would you like to negate?");
                        Console.WriteLine("v1) " + test1);
                        Console.WriteLine("v2) " + test2);
                        input = Console.ReadLine();
                        if (input == "v1")
                        {
                            Console.WriteLine("v1 negated is: " + Vector.Negate(test1));
                        }
                        else if (input == "v2")
                        {
                            Console.WriteLine("v2 negated is: " + Vector.Negate(test2));
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                            input = "f";
                        }
                    }
                    
                }
                else if (input == "g")
                {
                    //subtracts vector 1 by vector 2
                    Console.WriteLine(test1 + " - " + test2 + " = " + Vector.Subtract(test1, test2));
                }
                else if (input == "h")
                {
                    //scales a vector
                    while (input == "h")
                    {
                        Console.WriteLine("\nWhich vector do you want to scale?");
                        Console.WriteLine("v1) " + test1);
                        Console.WriteLine("v2)" + test2);
                        input = Console.ReadLine();
                        if (input == "v1")
                        {
                            Console.WriteLine("What would you like to scale v1 by?");
                            input = Console.ReadLine();
                            Console.WriteLine(test1 + " scaled by " + input + ": " + Vector.Scale(test1, float.Parse(input)));
                        }
                        else if (input == "v2")
                        {
                            Console.WriteLine("What would you like to scale v2 by?");
                            input = Console.ReadLine();
                            Console.WriteLine(test2 + " scaled by " + input + ": " + Vector.Scale(test2, float.Parse(input)));
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                            input = "h";
                        }
                    }
                    
                }
                else if (input == "i")
                {
                    //normalizes a vector
                    while (input == "i")
                    {
                        Console.WriteLine("\nWhich vector would you like to normalize?");
                        Console.WriteLine("v1) " + test1);
                        Console.WriteLine("v2) " + test2);
                        input = Console.ReadLine();
                        if (input == "v1")
                        {
                            Console.WriteLine(test1 + " normalized is: " + Vector.Normalize(test1));
                        }
                        else if (input == "v2")
                        {
                            Console.WriteLine(test2 + " normalized is: " + Vector.Normalize(test2));
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                            input = "i";
                        }
                    }
                }
                else if (input == "j")
                {
                    //finds dot product of vectors
                    Console.WriteLine("\nThe dot product of " + test1 + " and " + test2 + " is: " + Vector.DotProduct(test1, test2));
                }
                else if (input == "k")
                {
                    //finds cross product of vectors
                    Console.WriteLine("\nThe cross product of " + test1 + " and " + test2 + " is: " + Vector.CrossProduct(test1, test2));
                }
                else if (input == "l")
                {
                    //finds angle between two vectors
                    Console.WriteLine("\nThe angle between " + test1 + " and " + test2 + " is: " + Vector.AngleBetween(test1, test2) + " rad");

                }
                else if (input == "m")
                {
                    // vector projection
                    while (input == "m")
                    {
                        Console.WriteLine("\nWhich vector would you like to project on the other?");
                        Console.WriteLine("v1) " + test1 + " onto " + test2);
                        Console.WriteLine("v2) " + test2 + " onto " + test1);
                        input = Console.ReadLine();
                        if (input == "v1")
                        {
                            Console.WriteLine("\n" + test1 + " projected onto " + test2 + " is: " + Vector.ProjectOnto(test1, test2));
                        }
                        else if (input == "v2")
                        {
                            Console.WriteLine("\n" + test2 + "projected onto " + test1 + " is: " + Vector.ProjectOnto(test2, test1));
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Input.");
                        }
                    }
                }
                else if (input == "n")
                {
                    //exit
                    Console.WriteLine("\nGoodbye.");
                    run = false;
                }
                else
                {
                    //if an invalid input is given
                    Console.WriteLine("\nInvalid input. Try again.");
                }
            }
        }
    }
}
