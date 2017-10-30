using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class AlgoritmoBareiss
    {
        public void EjecutarBareiss(int[,] matrizInicial, int n)
        {
            List<int[,]> nMatrices = new List<int[,]>();

            nMatrices.Add(matrizInicial);

            int pivoteAnterior = 1;

            for (int i = 1; i < n; i++)
            {
                int[,] matrizGenerada = new int[n,n + 1];

                int[,] matrizAnterior = nMatrices[i - 1];

                //Copia las filas generadas de la matriz anterior
                for (int k = 0; k < i; k++)
                {
                    for (int j = 0; j < n + 1; j++)
                    {
                        matrizGenerada[k, j] = matrizAnterior[k, j] * 1;
                    }
                }

                int pivoteActual = matrizGenerada[i - 1, i - 1];

                for (int k = i; k < n; k++)
                {
                    for (int j = i; j < n + 1; j++)
                    {
                        matrizGenerada[k, j] = ((pivoteActual * matrizAnterior[k, j]) - (matrizAnterior[k, i-1] * matrizAnterior[i-1, j]))/pivoteAnterior;
                    }
                }

                nMatrices.Add(matrizGenerada);

                pivoteAnterior = pivoteActual;
            }
        }
    }
}
