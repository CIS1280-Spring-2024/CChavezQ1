using System.Threading.Tasks;

namespace CChavezQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //  In main start a do another loop.
                //  Instantiate your class.
                GravForceCalc forceCalc = new GravForceCalc();
                //  Ask the user for the names and masses of the objects and their distance apart.
                //  Display the ToString() to the user
                //  then ask the user if they want to do another.
            } while (GravForceCalc.DoAnother());
        }
    }
}
