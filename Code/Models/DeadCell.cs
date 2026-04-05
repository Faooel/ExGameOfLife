namespace GameOfLife.Models {
    public class DeadCell : Cell {
        public override bool IsAlive() => false;

        public override Cell NextState(int nbVoisins) {
            // cellule morte nait avec 3 voisins 
            if (nbVoisins == 3) return new AliveCell { X = X, Y = Y };
            return new DeadCell { X = X, Y = Y };
        }
    }
}