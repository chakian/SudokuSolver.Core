using SudokuSolver.Entities;
using System.Linq;

namespace SudokuSolver.Core.Extensions
{
    public static class CellExtension
    {
        public static void SetCellValue(this Cell cell, int value)
        {
            cell.Value = value;
            cell.PossibleValues.RemoveAll(q => q != value);
        }

        public static bool RemovePossibleValue(this Cell cell, int valueToRemove)
        {
            cell.PossibleValues.Remove(valueToRemove);
            if (cell.PossibleValues.Count == 1)
            {
                cell.Value = cell.PossibleValues.First();
                return true;
            }
            return false;
        }
    }
}
