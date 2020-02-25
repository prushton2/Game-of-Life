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

  public void setCell(int xPos, int yPos, bool isAlive) { //Made as a shorthand method to set the array value
    this.board[xPos, yPos].alive = isAlive;
  }

  public int getAdjacent(int xPos, int yPos, bool isAlive) { //This method looks for all squares with the given life value in a 3x3 around the position
  int counter = 0; //Counts the cells that meet the given value
    for(int i = -1; i<=1; i++) {
      for(int j = -1; j<=1; j++) {
        if((i == 0 && j == 0)) { // Ignores the given cell
          continue;
        }
        try {
          if(board[xPos + i, yPos + j].alive == isAlive) {
            counter++;
          }
        } catch {}

      }
    }
    return counter;
  }

  public bool getFutureState(int xPos, int yPos) {
    int neighbors = this.getAdjacent(xPos, yPos, true);
    if(neighbors <= 1 || neighbors >= 4) {  
      return false;
    }
    else if(neighbors == 3) {
      return true;
    }
    return board[xPos, yPos].alive;
  }

}