using GameOfLife.Models;
using System;

namespace GameOfLife.Logic 
{
    public class CellFactory 
    {
        // crée cellule vivante/morte selon param is_v
        public Cell CreateCell(int posX, int posY, bool is_v) 
        {
            // si vivant renvoie objet AliveCell
            if (is_v == true) 
            {
                return new AliveCell { X = posX, Y = posY };
            }
            
            // par défaut cellule morte
            return new DeadCell { X = posX, Y = posY };
        }
    }
}