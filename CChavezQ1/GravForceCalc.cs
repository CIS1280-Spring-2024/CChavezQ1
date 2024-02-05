using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CChavezQ1
{
    class GravForceCalc
    {
        //  Variable Declaration 
        private double force;   //force:    Output gravitaional force in newtons
        private const double GRAVCONST = 0.0000000000667404; //
        private double calulatedConstant;
        private double objMass1;    // M1:  mass of the fiirst object in kiligrams
        private double objMass2;    // M2:  mass o the second object in kilograms
        private double objDist;     // R2:  distance between objects in meeters

        // Constructor
        public GravForceCalc()
        {

        }

        public static bool DoAnother()
        {
            Console.WriteLine("Do you want do another calulation? (y/n): ");
            string? answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer))
            {
                return false;
            }
            return answer.ToLower()[0] == 'y';
        }


    }
}
