using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InterfazGrafica
{
    public class Isografo
    {
        public Point Transformar3Da2D(Point3D p)
        {
            Point punto = new Point
            {
                X = Convert.ToInt32(p.Y - p.X),
                Y = Convert.ToInt32(((p.X + p.Y - 2 * p.Z) * 0.5))
            };

            return punto;
        }

        public Point Transformar3Da2D(Point3D p, double angulo)
        {
            Point3D pAngulado = new Point3D(((Math.Cos(angulo) * p.X) - (Math.Sin(angulo) * p.Y)), ((Math.Sin(angulo) * p.X) + (Math.Cos(angulo) * p.Y)), p.Z);

            return Transformar3Da2D(pAngulado);
        }

        public Point3D PuntosPEnBaseB(Point3D p, Base3D b)
        {
            Point3D result = new Point3D();

            Double det = b.Determinante;

            if (b.EsLinearIndependiente())
            {
                result.X = (p.X * Base3D.CofactorAlpha(b.V, b.W) - p.Y * Base3D.CofactorBeta(b.V, b.W) + p.Z * Base3D.CofactorDelta(b.V, b.W)) / det;
                result.Y = -(p.X * Base3D.CofactorAlpha(b.U, b.W) - p.Y * Base3D.CofactorBeta(b.U, b.W) + p.Z * Base3D.CofactorDelta(b.U, b.W)) / det;
                result.Z = (p.X * Base3D.CofactorAlpha(b.U, b.V) - p.Y * Base3D.CofactorBeta(b.U, b.V) + p.Z * Base3D.CofactorDelta(b.U, b.V)) / det;
            }

            return result;
        }
    }
}
