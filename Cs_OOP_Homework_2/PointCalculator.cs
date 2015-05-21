namespace Cs_OOP_Homework_2
{
    using System;

    public static class PointCalculator
    {
        public static double CalculateDistance(Point3D p1, Point3D p2)
        {
            return Math.Sqrt(Math.Pow(p1.XCoord - p2.XCoord, 2) + 
                Math.Pow(p1.YCoord - p2.YCoord, 2) + Math.Pow(p1.ZCoord - p2.ZCoord, 2));
        }
    }
}
