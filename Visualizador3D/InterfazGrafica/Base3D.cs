using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazGrafica
{
    public class Base3D
    {
        public Point3D U { get; set; }
        public Point3D V { get; set; }
        public Point3D W { get; set; }
        public Double Determinante { get { return CalcularDeterminante(); } }

        public static Double CofactorAlpha(Point3D a, Point3D b)
        {
            return (a.Y * b.Z - a.Z * b.Y);
        }

        public static Double CofactorBeta(Point3D a, Point3D b)
        {
            return (a.X * b.Z - a.Z * b.X);
        }

        public static Double CofactorDelta(Point3D a, Point3D b)
        {
            return (a.X * b.Y - a.Y * b.X);
        }

        public Base3D(Point3D u, Point3D v, Point3D w)
        {
            this.U = u;
            this.V = v;
            this.W = w;
        }

        public Base3D()
        {
            U = new Point3D();
            V = new Point3D();
            W = new Point3D();
        }

        private Double CalcularDeterminante()
        {
            double cofactor1 = U.X * Base3D.CofactorAlpha(V, W);
            double cofactor2 = U.Y * Base3D.CofactorBeta(V, W);
            double cofactor3 = U.Z * Base3D.CofactorDelta(V, W);

            return cofactor1 - cofactor2 + cofactor3;
        }

        public bool EsLinearIndependiente()
        {
            return Determinante != 0;
        }
    }
}
