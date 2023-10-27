using System;
using System.Collections.Generic;
using System.Linq;

namespace TD_LifeGame
{
    public class Grid
    {
        int _size;
        Cell[,] TabCells;

        public int Size
        {
            get => _size;
            set => _size = value;
        }

        public Grid(int nbCells, List<Coords> aliveCellsCoords)
        {
            Size = nbCells;
            TabCells = new Cell[Size, Size];
            
            /* Remplissage du tableau avec à chaque emplacement une instance d’une cellule
             Cell créée vivante (true) si les coordonnées sont dans la liste AliveCellsCoords
             ou absente (false) sinon. */
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    if (aliveCellsCoords.Any(c => c.X == x && c.Y == y))
                        TabCells[x, y] = new Cell(true);
                    else 
                        TabCells[x, y] = new Cell(false);
                }
            }
        }

        public int GetNbAliveNeighbour(int x, int y)
        {
            int value = 0;
            
            for (int i = x-1; i < x+1; i++)
            {
                for (int j = y-1; j < y+1; j++)
                {
                    if (i < 0 || i > Size || j < 0 || j > Size) continue;
                    
                    if (TabCells[i, j].IsAlive 
                        && !(i == x && j == y)) 
                        value++;
                }
            }

            return value;
        }

        public List<Coords> GetCoordsNeighbour(int x, int y)
        {
            List<Coords> valideCellsCoords = new List<Coords>();
            
            for (int i = x-1; i < x+1; i++)
            {
                for (int j = y-1; j < y+1; j++)
                {
                    if (i < 0 || i > Size || j < 0 || j > Size) continue;
                    
                    valideCellsCoords.Add(new Coords(i, j));
                }
            }

            return valideCellsCoords;
        }

        public List<Coords> GetCoordsCellsAlive()
        {
            List<Coords> aliveCellsCoords = new List<Coords>();
            
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    if (TabCells[x, y].IsAlive)
                        aliveCellsCoords.Add(new Coords(x, y));
                }
            }

            return aliveCellsCoords;
        }

        public void DisplayGrid()
        {
            for (int x = 0; x < Size; x++)
            {
                for (int y = 0; y < Size; y++)
                {
                    if (TabCells[x,y].IsAlive)
                        Console.WriteLine("\u25a0");
                    else
                        Console.WriteLine(".");
                }
                Console.WriteLine("\n");
            }
        }

        public void UpdateGrid()
        {
            foreach (Cell cell in TabCells)
            {
                cell.IsAlive = cell.NextState;
            }

            foreach (Cell cell in TabCells)
            {
                if ()
            }
        }
    }
}