//Problem 8. Matrix
//Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

namespace DefiningClassesSecondPart.Matrix
{
    using System;
    using System.Text;

    public class Matrix<T> where T : IComparable
    {
        private T[,] matrix;
        private const int DEFAULT_ROW = 4;
        private const int DEFAULT_COL = 4;


        public Matrix()
            : this(DEFAULT_ROW, DEFAULT_COL)
        {
        }

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];

        }

        public int GetRowLength
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int GetColLength
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        //Problem 9. Matrix indexer
        //Implement an indexer this[row, col] to access the inner matrix cells.

        public T this[int indexRow, int indexCol]
        {
            get
            {
                CheckIndex(indexRow, indexCol);

                return this.matrix[indexRow, indexCol];
            }
            set
            {
                CheckIndex(indexRow, indexCol);

                this.matrix[indexRow, indexCol] = value;
            }
        }

        //Problem 10. Matrix operations

        //Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
        //Throw an exception when the operation cannot be performed.
        //Implement the true operator (check for non-zero elements).

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            CheckSameSizeMatrix(m1, m2);

            Matrix<T> addition = new Matrix<T>(m1.GetColLength, m1.GetRowLength);

            for (int i = 0; i < m1.GetRowLength; i++)
            {
                for (int j = 0; j < m1.GetColLength; j++)
                {
                    addition[i, j] = (dynamic)m1[i, j] + m2[i, j];
                }
            }

            return addition;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            CheckSameSizeMatrix(m1, m2);

            Matrix<T> subtraction = new Matrix<T>(m1.GetColLength, m1.GetRowLength);

            for (int i = 0; i < m1.GetRowLength; i++)
            {
                for (int j = 0; j < m1.GetColLength; j++)
                {
                    subtraction[i, j] = (dynamic)m1[i, j] - m2[i, j];
                }
            }

            return subtraction;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.GetColLength != m2.GetRowLength)
            {
                throw new ArgumentException("Invalid Matrices");
            }

            Matrix<T> multiplication = new Matrix<T>(m1.GetRowLength, m2.GetColLength);

            for (int i = 0; i < m1.GetRowLength; i++)
            {
                for (int j = 0; j < m2.GetColLength; j++)
                {                   
                    for (int k = 0; k < m1.GetColLength; k++)
                    {
                        multiplication[i, j] += (dynamic)m1[i, k] * m2[k, j];
                    }
                }
            }

            return multiplication;
        }

        public static bool operator true(Matrix<T> m1)
        {
            return CheckForZeroElement(m1);
            
        }

        public static bool operator false(Matrix<T> m1)
        {
            return CheckForZeroElement(m1);

        }

        private static bool CheckForZeroElement(Matrix<T> m1)
        {
            for (int i = 0; i < m1.GetRowLength; i++)
            {
                for (int j = 0; j < m1.GetColLength; j++)
                {
                    if (m1[i, j] == (dynamic)default(T))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static void CheckSameSizeMatrix(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.GetRowLength != m2.GetRowLength)
            {
                throw new ArgumentException("Invalid Matrices");
            }

            if (m1.GetColLength != m2.GetColLength)
            {
                throw new ArgumentException("Invalid Matrices");
            }
        }


        private void CheckIndex(int indexRow, int indexCol)
        {
            if (indexRow < 0 || indexCol < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (indexRow > matrix.GetLength(0) || indexCol > matrix.GetLength(1))
            {
                throw new IndexOutOfRangeException();
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    stringBuilder.AppendFormat("{0}  ",this.matrix[i, j].ToString());
                }
                stringBuilder.Append("\n");
            }

            return stringBuilder.ToString();
        }
    }
}
