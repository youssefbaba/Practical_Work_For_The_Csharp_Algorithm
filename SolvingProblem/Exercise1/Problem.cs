
namespace Exercise1
{
    internal class Problem
    {
        public static void Main()
        {
            //Equation myEquation = new Equation(2, 6, 1);
            //Equation myEquation = new Equation(3, 6, 3);
            Equation myEquation = new Equation(1, 10, 169);
            //Equation myEquation = new Equation(0, 6, 1);
            myEquation.DisplayEquation();
            myEquation.CalculateRoots();
            if (myEquation.Discriminant == 0)
            {
                Console.WriteLine($"The root = {myEquation.FirstRoot} .");
            }
            else if (myEquation.Discriminant > 0)
            {
                Console.WriteLine($"First Root = {myEquation.FirstRoot} , Second Root = {myEquation.SecondRoot}");
            }
        }
    }
}
