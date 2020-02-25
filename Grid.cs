using System;

public class Grid {
  
  public Cell[,] board = new Cell[10,10];

  public Grid() {
    for(int i =0; i<board.GetLength(0); i++) {
      for(int j =0; j<board.GetLength(0); j++) {
        board[i, j] = new Cell();
      }
    }
  }

  public void setCell(int xPos, int yPos, bool isAlive) {
    this.board[xPos, yPos].alive = isAlive;
  }
}