using GameOfLife.Logic;
using GameOfLife.Data;
using System;

namespace GameOfLife.Controllers 
{
    public class GameController 
    {
        private GameEngine _leMoteur; 
        private GameRepository _leRepo = GameRepository.Instance;

        public GameController(GameEngine engine) 
        {
            _leMoteur = engine; 
        }

        public void Step() 
        {
            _leMoteur.NextGeneration();
        }

        public void Save() 
        {
            string chaine_data = ""; 
            
            for (int x = 0; x < _leMoteur.Width; x++) 
            {
                for (int y = 0; y < _leMoteur.Height; y++) 
                {
                    // 1 vivant, 0 mort
                    if (_leMoteur.Grid[x, y].IsAlive() == true) 
                    {
                        chaine_data += "1";
                    }
                    else 
                    {
                        chaine_data += "0";
                    }
                }
                chaine_data += "|"; 
            }
            
            _leRepo.SaveState(chaine_data); 
        }
    }
}