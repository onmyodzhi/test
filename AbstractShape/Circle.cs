using Shapes;
public class Circle : Shape
{
    public override double GetArea(double circleRadius)
    {
        return Math.PI * Math.Pow(circleRadius, 2);
    }

}