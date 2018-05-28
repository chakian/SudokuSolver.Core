using System.Collections.Generic;

namespace SudokuSolver.Entities
{
    public class Cell
    {
        public CellCoordinate Coordinate { get; set; }
        public int Value { get; set; }
        public List<int> PossibleValues { get; set; }
    }
}
