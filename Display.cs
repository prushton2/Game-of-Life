using System;

public class Display { //Displays the grid in the console.
  public Grid grid;
  public Display(Grid grid) {
    this.grid = grid;
  }
  public void show() {
    Console.Write("+");
    for(int j = 0; j<grid.board.GetLength(1); j++) {
      Console.Write("-+");
    }
    for(int i = 0; i<grid.board.GetLength(0); i++) {
      Console.Write("\n|");
      for(int j = 0; j<grid.board.GetLength(1); j++) {
        Console.Write(grid.board[i, j].alive ? "O|" : " |");
      }
      Console.Write("\n+");
      for(int j = 0; j<grid.board.GetLength(1); j++) {
        Console.Write("-+");
      }
    }
    Console.WriteLine("");
  }
}