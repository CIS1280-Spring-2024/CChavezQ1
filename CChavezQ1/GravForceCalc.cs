namespace CChavezQ1
{
    class GravForceCalc
    {
        //  Variable Declaration 
        private double force;   //force:    Output gravitaional force in newtons
        private const double GRAVCONST = 0.0000000000667404; // 6.67408 x 10-11 
        private string objName1;    // Name of object 1
        private double objMass1;    // M1:  mass of the fiirst object in kiligrams
        private string objName2;    // Name of object 2
        private double objMass2;    // M2:  mass of the second object in kilograms
        private double objDist;     // R2:  distance between objects in meeters
        

        // Constructor
        public GravForceCalc()
        {

        }

        // Setters
        public void SetObjName1(string _objName1)
        {
            objName1 = _objName1;
        }

        public void SetObjMass1(double _objMass1)
        {
            objMass1 = _objMass1;
        }
        public void SetObjName2(string _objName2)
        {
            objName2 = _objName2;
        }

        //TODO: Call calc from the set mass methods. RJG
        public void SetObjMass2(double _objMass2)
        {
            objMass2 = _objMass2;
        }
        public void SetObjDist(double _objDist)
        {
            objDist= _objDist;
        }


        // Getters
        public string GetObjName1() 
        { 
            return objName1;
        }
        public string GetObjName2()
        {
            return objName2;
        }
        public double GetObjMass1()
        {
            return objMass1;
        }
        public double GetObjMass2()
        {
            return objMass2;
        }
        public double GetObjDist()
        {
            return objDist;
        }

        //  Private Calulate methods

        private void CalulateConstant()
        {
            force = GRAVCONST * ((objMass1 * objMass2) / objDist);
        }
        //TODO: This should not be part of the GravForceCalc class. It should be in main or a utility class. RJG
        //  Do another method
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

        public override string ToString()
        {
            return "The gravitational force between " + objName1 + " and " + objName2 + " when they are " + objDist+ " meters apart is : " + force + " in Newtons";
        }


    }
}
