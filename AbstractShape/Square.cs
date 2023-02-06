using Shapes;
public class Square : Shape
{
    public override double GetArea(double sideSqare)
    {
        return Math.Pow(sideSqare, 2);
    }
}