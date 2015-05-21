namespace Cs_OOP_Homework_2
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pointsPath;

        public Path()
        {
            this.pointsPath = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            if (this.pointsPath.Count > 0 && this.pointsPath[this.pointsPath.Count-1] == point)
            {
                throw new ArgumentException("Cannot successively add a same point!");
            }

            this.pointsPath.Add(point);
        }

        public List<Point3D> GetPoints { get; private set; }

        
    }
}
