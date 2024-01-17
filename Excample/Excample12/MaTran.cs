using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample12
{
    internal class MaTran
    {
        private int m { get; set; }
        private int n { get; set; }
        public double[,] matrix { get;  set; }

        public MaTran() { }

        public MaTran(int m, int n)
        {
            this.m = m;
            this.n = n;
            this.matrix = new double[m, n];
        }

        public void Input()
        {
            if (m == default(int) || n == default(int))
            {
                Console.Write("Nhap so hang: ");
                this.m = int.Parse(Console.ReadLine());
                Console.Write("Nhap so cot: ");
                this.n = int.Parse(Console.ReadLine());
                this.matrix = new double[m, n];
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhap gia tri o (" + (i + 1) + ", " + (j + 1) + "): ");
                    this.matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Ouput()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Output(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static double[,] sumMatrix(MaTran matrixA, MaTran matrixB)
        {
            double[,] tempMatrixA = matrixA.matrix;
            double[,] tempMatrixB = matrixB.matrix;

            if (tempMatrixA.GetLength(0) != tempMatrixB.GetLength(0) || tempMatrixA.GetLength(1) != tempMatrixB.GetLength(1))
            {
                Console.WriteLine("Hai ma tran khong cung kich thuoc");
                return null;
            }

            double[,] result = new double[tempMatrixA.GetLength(0), tempMatrixB.GetLength(1)];
            for (int i = 0; i < tempMatrixA.GetLength(0);  i++)
            {
                for (int j = 0; j < tempMatrixA.GetLength(1); j++)
                {
                    result[i, j] = (tempMatrixA[i, j] + tempMatrixB[i, j]);
                }
            }
            
            return result;
        }

        public static double[,] diffMatrix(MaTran matrixA, MaTran matrixB)
        {
            double[,] tempMatrixA = matrixA.matrix;
            double[,] tempMatrixB = matrixB.matrix;

            if (tempMatrixA.GetLength(0) != tempMatrixB.GetLength(0) || tempMatrixA.GetLength(1) != tempMatrixB.GetLength(1))
            {
                Console.WriteLine("Hai ma tran khong cung kich thuoc");
                return null;
            }

            double[,] result = new double[tempMatrixA.GetLength(0), tempMatrixB.GetLength(1)];
            for (int i = 0; i < tempMatrixA.GetLength(0); i++)
            {
                for (int j = 0; j < tempMatrixA.GetLength(1); j++)
                {
                    result[i, j] = (tempMatrixA[i, j] - tempMatrixB[i, j]);
                }
            }

            return result;
        }

        public static double[,] proMatrix(MaTran matrixA, MaTran matrixB)
        {
            double[,] tempMatrixA = matrixA.matrix;
            double[,] tempMatrixB = matrixB.matrix;

            if (tempMatrixA.GetLength(1) != tempMatrixB.GetLength(0))
            {
                Console.WriteLine("Hai ma tran khong cung kich thuoc");
                return null;
            }

            double[,] result = new double[tempMatrixA.GetLength(0), tempMatrixB.GetLength(1)];
            for (int i = 0; i < tempMatrixA.GetLength(0); i++)
            {
                for (int j = 0; j < tempMatrixB.GetLength(1); j++)
                {
                    for (int k = 0;  k < tempMatrixA.GetLength(1); k++)
                    {
                        result[i, j] += (tempMatrixA[i, k] * tempMatrixB[k, j]);
                    }
                }
            }

            return result;
        }

        public static double[,] proMatrix(MaTran matrixA, double[,] matrixB)
        {
            double[,] tempMatrixA = matrixA.matrix;

            if (tempMatrixA.GetLength(1) != matrixB.GetLength(0))
            {
                Console.WriteLine("Hai ma tran khong cung kich thuoc");
                return null;
            }

            double[,] result = new double[tempMatrixA.GetLength(0), matrixB.GetLength(1)];
            for (int i = 0; i < tempMatrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int k = 0; k < tempMatrixA.GetLength(1); k++)
                    {
                        result[i, j] += (tempMatrixA[i, k] * matrixB[k, j]);
                    }
                }
            }

            return result;
        }

        public static double[,] InverseMatrix(MaTran matrix)
        {
            double[,] tempMatrix = matrix.matrix;
            int n = tempMatrix.GetLength(0);

            double[,] augmentedMatrix = new double[n, 2 * n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmentedMatrix[i, j] = tempMatrix[i, j];
                }

                augmentedMatrix[i, i + n] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                double divisor = augmentedMatrix[i, i];
                for (int j = 0; j < 2 * n; j++)
                {
                    augmentedMatrix[i, j] /= divisor;
                }

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = augmentedMatrix[k, i];
                        for (int j = 0; j < 2 * n; j++)
                        {
                            augmentedMatrix[k, j] -= factor * augmentedMatrix[i, j];
                        }
                    }
                }
            }

            double[,] inverseMatrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inverseMatrix[i, j] = augmentedMatrix[i, j + n];
                }
            }

            return inverseMatrix;
        }

        public static double[,] quoMatrix(MaTran matrixA, MaTran matrixB)
        {
            double[,] tempMatrixA = matrixA.matrix;
            double[,] tempMatrixB = matrixB.matrix;

            if (tempMatrixA.GetLength(1) != tempMatrixA.GetLength(0) || tempMatrixB.GetLength(0) != tempMatrixB.GetLength(1))
            {
                Console.WriteLine("Khong the chia ma tran khong vuong");
                return null;
            }

            double[,] inverseMatrix = InverseMatrix(matrixB);

            double[,] result = proMatrix(matrixA, inverseMatrix);

            return result;
        }
    }
}
