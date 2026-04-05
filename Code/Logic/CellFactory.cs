using GameOfLife.Models;

namespace GameOfLife.Logic {
    public class CellFactory {
        public Cell CreateCell(int x, int y, bool vivant) {
            if (vivant) return new AliveCell { X = x, Y = y };
            return new DeadCell { X = x, Y = y };
        }
    }
}