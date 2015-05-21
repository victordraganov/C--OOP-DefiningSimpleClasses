namespace Cs_OOP_Homework_2
{
    using System.Text;

    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D();

        public static Point3D DefaultSystemStart
        {
            get
            {
                return pointO;
            }
        }

        public double XCoord{ get; set;}

        public double YCoord { get; set; }

        public double ZCoord { get; set; }

        public static bool operator ==(Point3D point, Point3D otherPoint)
        {
            return point.XCoord == otherPoint.XCoord && point.YCoord == otherPoint.YCoord && point.ZCoord == otherPoint.ZCoord;
        }

        public static bool operator !=(Point3D point, Point3D otherPoint)
        {
            return point == otherPoint;
        }
    
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendFormat("X coordinate: {0}\nY coordinate: {1}\nZ coordinate: {2}\n", this.XCoord, this.YCoord, this.ZCoord);

            return info.ToString();
        }
    }
}
