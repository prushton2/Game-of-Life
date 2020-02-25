using System;

class MainClass { 
  public static void Main (string[] args) {
    Grid grid = new Grid();
    Grid grid2 = new Grid(); //Stores future states of cells
    Display display = new Display(grid);

    grid.setCell(5, 4, true);
    grid.setCell(5, 5, true);
    grid.setCell(5, 6, true);
    grid.setCell(5, 7, true);



    display.show();
    for(int k = 0; k<100; k++) {
      // grid2.board = grid.board;
      Console.WriteLine("-------------------------------");
      for(int i = 0; i<grid.board.GetLength(0); i++) {
        for(int j = 0; j<grid.board.GetLength(1); j++) {
          grid2.setCell(i, j, grid.getFutureState(i, j));
        }
      }
      grid.board = grid2.board;
      display.show();
    
      Console.ReadLine();
    }

    // Console.WriteLine(grid.getAdjacent(1, 1, true));

  }
}