using GameOfLife.Models;
using System.Collections.Generic;

namespace GameOfLife.Logic 
{
    // moteur du jeua
    public class GameEngine 
    {
        public Cell[,] Grid { get; private set; }
        public int Width { get; }
        public int Height { get; }
        
        private CellFactory _laFabrique = new CellFactory();

        public GameEngine(int w, int h) 
        {
            this.Width = w;
            this.Height = h;
            this.Grid = new Cell[w, h];
            
            for (int i = 0; i < w; i++) 
            {
                for (int j = 0; j < h; j++) 
                {
                    Grid[i, j] = _laFabrique.CreateCell(i, j, false);
                }
            }
        }

        // calcul la generation aprés
        public void NextGeneration() 
        {
            Cell[,] grilleSuivante = new Cell[Width, Height];
            
            for (int x = 0; x < Width; x++) 
            {
                for (int y = 0; y < Height; y++) 
                {
                    int nb_v = CompterVoisins(x, y);

                    grilleSuivante[x, y] = Grid[x, y].NextState(nb_v);
                }
            }
            Grid = grilleSuivante;
        }

        // verifier les 8 cases autour
        private int CompterVoisins(int posX, int posY) 
        {
            int total = 0;
            for (int i = -1; i <= 1; i++) 
            {
                for (int j = -1; j <= 1; j++) 
                {
                    if (i == 0 && j == 0) continue; 
                    int checkX = posX + i;
                    int checkY = posY + j;

                    // bordures de la map
                    if (checkX >= 0 && checkX < Width && checkY >= 0 && checkY < Height) 
                    {
                        if (Grid[checkX, checkY].IsAlive() == true) 
                        {
                            total++;
                        }
                    }
                }
            }
            return total;
        }
    }
}