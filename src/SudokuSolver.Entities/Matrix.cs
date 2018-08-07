using System.Collections.Generic;

namespace SudokuSolver.Entities
{
    public class Matrix : List<Cell>
    {
        private readonly int SquareSize;

        public Matrix() : this(9)
        {
        }
        public Matrix(int size)
        {
            SquareSize = size;
        }

        public int MinimumIndex { get => 0; }
        public int MaximumIndex { get => SquareSize - 1; }
    }
}
