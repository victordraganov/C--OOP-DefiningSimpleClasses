namespace Cs_OOP_Homework_2
{
    class Program
    {
        static void Main()
        {
            Point3D point = new Point3D();
            point.XCoord = 1;
            point.YCoord = 2;

            Path path = new Path();

            path.AddPoint(point);
        }
    }
}
