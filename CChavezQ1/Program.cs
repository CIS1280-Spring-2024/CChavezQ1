namespace CChavezQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  In main start a do another loop.
            do
            {

                DisplayHeader();
                //  Instantiate your class.
                GravForceCalc forceCalc = new GravForceCalc();
                //  Ask the user for the names and masses of the objects and their distance apart.
                // variable setup 
                string obj1NameBuffer;
                string obj2NameBuffer;
                string objMassBuffer;
                string objDistanceBuffer;
                try
                {
                    Console.WriteLine("\nWhat is the name of the first stellar object in kilograms?\n");
                    obj1NameBuffer = Console.ReadLine();
                    forceCalc.SetObjName1(obj1NameBuffer);

                    Console.WriteLine($"\nWhat is the mass of the {obj1NameBuffer}?\n");
                    objMassBuffer = Console.ReadLine();
                    forceCalc.SetObjMass1(double.Parse(objMassBuffer));

                    Console.WriteLine("\nWhat is the name of the second stellar object?\n");
                    obj2NameBuffer = Console.ReadLine();
                    forceCalc.SetObjName2(obj2NameBuffer);

                    Console.WriteLine($"\nWhat is the mass of the {obj2NameBuffer} in kilograms?\n");
                    objMassBuffer = Console.ReadLine();
                    forceCalc.SetObjMass2(double.Parse(objMassBuffer));

                    Console.WriteLine($"\nWhat is the distance between {obj1NameBuffer}, and {obj2NameBuffer} in meters?\n");
                    objDistanceBuffer = Console.ReadLine();
                    forceCalc.SetObjDist(double.Parse(objDistanceBuffer));
                    //  Display the ToString() to the user
                    Console.WriteLine(forceCalc.ToString());

                }
                catch 
                {
                    Console.WriteLine($"An error occured!");
                }
                //  then ask the user if they want to do another.
            } while (GravForceCalc.DoAnother());
            Goodbye();
        }

        //TOOD: Correct! Well stated. RJG
        // basic main methods could have been build into the calulator class but this stuff isnt the job of a calulation class so i left it in main. 
        static void DisplayHeader()
        {
            Console.WriteLine(".NET I/C SHARP (U01) Class Header\nProgramed by: Colby Chavez\nEmail:cchavez572@cnm.edu\nProgram goal: CChavezQ1 is the demonstation of a class that will calulate the G force between two stellar objects. \n\n");
        }
        static void Goodbye()
        {
            Console.WriteLine("Thank you for grading CChavezQ1. Have a nice day. \n\n");
        }
    }
}
