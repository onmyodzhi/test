public class Rectangle : Square
{
    public override double GetArea(double underSide)
    {
        System.Console.WriteLine("Enter Side is Rectangle");
        double leftSide = Convert.ToDouble(Console.ReadLine());

        return  underSide * leftSide;
    }
}