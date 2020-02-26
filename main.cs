using System;
using System.Threading;

class MainClass { 
  public static void Main (string[] args) {
    Grid grid = new Grid();
    Display display = new Display(grid);
    Presets prst = new Presets(grid);

    int AutoTick = 750; // Automatically advance the generation every set period of time. Setting it to 0 requires manual input.

    //Create a pattern here. Origin is top left.
    prst.pentadecathlon(17, 3);
    // prst.random(0, 18, 36, 18);
    prst.t(5, 7);
    prst.cloverleaf(20,20);
    prst.spaceship(9,13);
    display.show(); //Displays the grid 

    while(true) {
      string input = "_";
      if(AutoTick == 0) { //Decides the input for advancing generations
        input = Console.ReadLine();

        while(input != "") {
          try { //Program errors when you spam enter, this exists to stop that.
            string[] w = input.Split(",");
            int x = Int32.Parse(w[0]);
            int y = Int32.Parse(w[1]);

            grid.setCell(y, x, !grid.board[y, x].alive);
            display.show();
          } catch {}
          input = Console.ReadLine();
        }
      } else {
        Thread.Sleep(AutoTick);
      }

      //Initializes a board that holds the changed cell values as to not interfere with the current cell values.
      Cell[,] board2 = new Cell[36,36]; 
      //Fill the new board with Cell instances
      for(int i = 0; i<board2.GetLength(0); i++) {
        for(int j = 0; j<board2.GetLength(0); j++) {
          board2[i, j] = new Cell();
        }
      }

      Console.WriteLine("-------------------------------");

      //Iterate through the entire board and get each cells state in the next generation. Stores them to board2
      for(int i = 0; i<grid.board.GetLength(0); i++) {
        for(int j = 0; j<grid.board.GetLength(1); j++) {
          board2[i, j].alive = grid.getFutureState(i, j);
        }
      }

      grid.board = board2; //Copy board2 to the board
      display.show(); //Show the grid
    
    }

  }
}