namespace Adas.Numeric
{
    public class Matrix<T>
    {
        private readonly T[,] _matrixElements;

        public Matrix(int rows, int cols)
        {
            _matrixElements = new T[rows, cols];
        }

        public Matrix(T[,] elements)
        {
            _matrixElements = elements;
        }

        public T[,] Elements {
            get
            {
                return _matrixElements;
            }
        }
    }
}
