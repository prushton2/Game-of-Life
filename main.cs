using System;
using System.Threading;

class MainClass { 
  public static void Main (string[] args) {
    Grid grid = new Grid();
    Display display = new Display(grid);
    Presets prst = new Presets(grid);

    int AutoTick = 750; // Automatically advance the generation every set period of time. Setting it to 0 requires manual input.

    //Create a pattern here. Origin is top left.
    // prst.pentadecathlon(10, 10);
    prst.random(0, 0, 36, 36);


    display.show();
    while(true) {
      if(AutoTick == 0) {
        Console.ReadLine();
      } else {
        Thread.Sleep(AutoTick);
      }
      Cell[,] board2 = new Cell[36,36];

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
      display.show();
    
    }

  }
}