using System;

namespace The_beggining_project
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First session Hello
            // Line 1
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is Eleonora. I started to learn coding when I was 26 years old.");
            Console.Write(Environment.NewLine);
            Console.WriteLine("My hight is approximately 160 cm and shoe size around 38");
            Console.WriteLine(@"In addition, I have a younger sister who is almost 21 years old.
Nevertheless, my dog Belmonts is adorable!") ;
            Console.ReadLine();

            #endregion

            #region My story in variables

            string helloVariable = "Hello World, my name is Eleonora. I satrted to learn coding when I was ";
            int ageVariable = 26;
            int shoeSize = 38;
            float heightVariable = 1.60f;
            int sistersAge = 21;
            string myHeight = "My height is approx ";
            string addSister = "I have a younger sister who is almost ";
            string yearsOld = " years old.";
            string belmonts = " Nevertheless, my dog Belmonts is adorable!";
            string cm = " cm";
            // Line 2
            Console.Write(Environment.NewLine);
            Console.WriteLine(helloVariable + ageVariable+ yearsOld);
            Console.Write(Environment.NewLine);
            Console.WriteLine(myHeight + heightVariable + cm + " but my shoe size is " + shoeSize);
            Console.WriteLine(addSister + sistersAge + yearsOld + belmonts);
            Console.ReadLine();
            #endregion

            #region adding lines together with $ and {}
            //Line 3
            Console.Write(Environment.NewLine);
            Console.WriteLine($"{helloVariable} {ageVariable} but my shoe size is {shoeSize}.");
            Console.ReadLine();
            #endregion


        }
    }
}
