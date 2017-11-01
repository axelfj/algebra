using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class AlgoritmoBareiss
    {
        public List<double[,]> EjecutarBareiss(double[,] matrizInicial, int n)
        {
            List<double[,]> nMatrices = new List<double[,]>();

            nMatrices.Add(matrizInicial);

            int pivoteAnterior = 1;

            int signo = 1;

            for (int i = 1; i < n; i++)
            {
                double[,] matrizGenerada = new double[n, n + 1];

                double[,] matrizAnterior = nMatrices[i - 1];

                //Copia las filas generadas de la matriz anterior
                for (int k = 0; k < i; k++)
                {
                    for (int j = 0; j < n + 1; j++)
                    {
                        matrizGenerada[k, j] = matrizAnterior[k, j] * 1;
                    }
                }

                int pivoteActual = (int)matrizGenerada[i - 1, i - 1];

                //Genera la nueva matriz
                for (int k = i; k < n; k++)
                {
                    for (int j = i; j < n + 1; j++)
                    {
                        matrizGenerada[k, j] = ((pivoteActual * matrizAnterior[k, j]) - (matrizAnterior[k, i - 1] * matrizAnterior[i - 1, j])) / pivoteAnterior;
                    }
                }

                bool hayCeros = false;
                for (int k = 0; k < n && !hayCeros; k++)
                {
                    if (matrizGenerada[k, k] == 0)
                    {
                        signo = -signo;
                        hayCeros = true;
                    }
                }

                nMatrices.Add(matrizGenerada);
                pivoteAnterior = pivoteActual;
            }

            double[,] determinante = new double[1, 1];

            determinante[0, 0] = nMatrices.Last()[n - 1, n - 1] * signo;

            if ((determinante[0, 0] == 0) || (Double.IsNaN(determinante[0, 0])))
            {
                throw new System.ArithmeticException("El sistema no tiene solución única");
            }

            nMatrices.Add(determinante);

            double[,] ecuacionesSolucion = new double[1, n];

            double[,] conjuntoSolucion = new double[1, n];

            for (int k = n; k > 0; k--)
            {
                double sumatoria = 0;

                for (int j = k; j < n; j++)
                {
                    sumatoria = sumatoria + (nMatrices[k - 1][k - 1, j] * ecuacionesSolucion[0, j]);
                }

                ecuacionesSolucion[0, k - 1] = ((determinante[0, 0] * nMatrices[k - 1][k - 1, n]) - sumatoria) / nMatrices[k - 1][k - 1, k - 1];
            }

            for (int k = 0; k < n; k++)
            {
                if (Double.IsNaN(ecuacionesSolucion[0, k]))
                {
                    throw new System.ArithmeticException("El sistema no tiene solución única");
                }

                conjuntoSolucion[0, k] = ecuacionesSolucion[0, k] / determinante[0, 0];
            }

            nMatrices.Add(conjuntoSolucion);

            return nMatrices;
        }
    }
}
