namespace GameOfLife.Models {
    public abstract class Cell {
        public int X { get; set; }
        public int Y { get; set; }

        // Méthodes imposées par l'UML
        public abstract bool IsAlive();
        public abstract Cell NextState(int nbVoisins);
    }
}