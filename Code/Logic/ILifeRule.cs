using System;
using System.Text;

namespace GameOfLife.Logic 
{
    // interface pour les differentes variantes
    public interface ILifeRule 
    {
        // methode qui renvoie si survit ou pas
        bool WillBeAlive(bool b_v, int nb_v);
    }
}