using SudokuSolver.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuSolver.Core.Extensions
{
    public static class MatrixExtension
    {
        public static List<Cell> GetRow(this Matrix matrix, int rowIndex)
        {
            if (rowIndex > matrix.MaximumIndex || rowIndex < matrix.MinimumIndex)
            {
                throw new IndexOutOfRangeException($"Invalid row index. Index must be between {matrix.MinimumIndex}-{matrix.MaximumIndex}");
            }

            return matrix.Where(q => q.Coordinate.RowIndex == rowIndex).ToList();
        }

        public static List<Cell> GetColumn(this Matrix matrix, int columnIndex)
        {
            if (columnIndex > matrix.MaximumIndex || columnIndex < matrix.MinimumIndex)
            {
                throw new IndexOutOfRangeException($"Invalid column index. Index must be between {matrix.MinimumIndex}-{matrix.MaximumIndex}");
            }

            return matrix.Where(q => q.Coordinate.ColumnIndex == columnIndex).ToList();
        }
        
        public static List<Cell> GetSquareByCellIndex(this Matrix matrix, int rowIndex, int columnIndex)
        {
            if (rowIndex > matrix.MaximumIndex || rowIndex < matrix.MinimumIndex || columnIndex > matrix.MaximumIndex || columnIndex < matrix.MinimumIndex)
            {
                throw new IndexOutOfRangeException($"Invalid index. Index must be between {matrix.MinimumIndex}-{matrix.MaximumIndex}");
            }
            
            //TODO: Do the implementation below.
            throw new Exception("Yet to implement. Too drunk now.");
            //return matrix.Where(q => q.Coordinate.ColumnIndex == columnIndex).ToList();
        }
    }
}
