using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.Entities
{
    public class Matrix : List<Cell>
    {
        private const int ROW_COUNT = 9;
        private const int COLUMN_COUNT = 9;

        private const int MINIMUM_INDEX = 0;
        private const int MAX_ROW_INDEX = ROW_COUNT - 1;
        private const int MAX_COLUMN_INDEX = COLUMN_COUNT - 1;

        public List<Cell> GetRow(int rowIndex)
        {
            if (rowIndex > MAX_ROW_INDEX || rowIndex < MINIMUM_INDEX)
            {
                throw new IndexOutOfRangeException($"Invalid row index. Index must be between {MINIMUM_INDEX}-{MAX_ROW_INDEX}");
            }

            return this.Where(q => q.Coordinate.RowIndex == rowIndex).ToList();
        }

        public List<Cell> GetColumn(int columnIndex)
        {
            if (columnIndex > MAX_COLUMN_INDEX || columnIndex < MINIMUM_INDEX)
            {
                throw new IndexOutOfRangeException($"Invalid column index. Index must be between {MINIMUM_INDEX}-{MAX_COLUMN_INDEX}");
            }

            return this.Where(q => q.Coordinate.ColumnIndex == columnIndex).ToList();
        }

        public List<Cell> GetSquare(int rowIndex, int columnIndex)
        {
            if (rowIndex > MAX_ROW_INDEX || rowIndex < MINIMUM_INDEX || columnIndex > MAX_COLUMN_INDEX || columnIndex < MINIMUM_INDEX)
            {
                throw new IndexOutOfRangeException($"Invalid index. Index numbers must be between {MINIMUM_INDEX}-{MAX_COLUMN_INDEX}");
            }


            //TODO: Do the implementation below.
            throw new Exception("Yet to implement. Too drunk now.");
            //return this.Where(q => q.Coordinate.ColumnIndex == columnIndex).ToList();
        }
    }
}
