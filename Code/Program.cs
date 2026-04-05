using System;
using System.Windows;
using GameOfLife.Views;
using GameOfLife.Controllers;
using GameOfLife.Logic;
using GameOfLife.Models;

namespace GameOfLife
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            // lancement de l'app 
            Application monApp = new Application();
            
            var leMoteur = new GameEngine(20, 20);
            var leControl = new GameController(leMoteur);
            
            CellFactory fab = new CellFactory();

            // setup 'dun petit blinker pour test
            leMoteur.Grid[5, 5] = fab.CreateCell(5, 5, true);
            leMoteur.Grid[5, 6] = fab.CreateCell(5, 6, true);
            leMoteur.Grid[5, 7] = fab.CreateCell(5, 7, true);
            
            MainWindow fenetrePrincipale = new MainWindow(leControl, leMoteur);
            
            monApp.Run(fenetrePrincipale);
        }
    }
}