namespace GameOfLife.Models {
    public class AliveCell : Cell {
        public override bool IsAlive() => true;

        public override Cell NextState(int nbVoisins) {
            // cellule survit avec 2 ou 3 voisins
            if (nbVoisins == 2 || nbVoisins == 3) return new AliveCell { X = X, Y = Y };
            return new DeadCell { X = X, Y = Y };
        }
    }
}