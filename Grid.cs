using System;
class Grid {
  public Cell[,] gameBoard = new Cell[10,10];
  
  public Grid() {}

  public bool setCell(int xPos, int yPos, bool isAlive) {
    if(gameBoard[xPos, yPos].alive == isAlive) {
      return false;
    } else {
      gameBoard[xPos, yPos].alive = isAlive;
      return true;
    }
  }
}