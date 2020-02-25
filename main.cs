using System;

class MainClass { 
  public static void Main (string[] args) {
    Grid grid = new Grid();
    Display display = new Display(grid);
//Create a pattern here. Origin is top left.

    grid.setCell(5, 4, true);
    grid.setCell(5, 5, true);
    grid.setCell(5, 6, true);
    grid.setCell(4, 5, true);

    

    display.show();
    // Console.WriteLine(grid.getAdjacent(1, 1, true));
    while(true) {
      Console.ReadLine();
      Cell[,] board2 = new Cell[10,10];

      for(int i =0; i<board2.GetLength(0); i++) {
        for(int j =0; j<board2.GetLength(0); j++) {
          board2[i, j] = new Cell();
        }
      }

      Console.WriteLine("-------------------------------");

      for(int i = 0; i<grid.board.GetLength(0); i++) {
        for(int j = 0; j<grid.board.GetLength(1); j++) {
          board2[i, j].alive = grid.getFutureState(i, j);
        }
      }
      grid.board = board2;
      Console.WriteLine("////////////////////////////////");
      display.show();
    
    }

    // Console.WriteLine(grid.getAdjacent(1, 1, true));

  }
}