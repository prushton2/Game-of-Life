using System;

public class Grid {
  
  public Cell[,] board = new Cell[36,36];

  public Grid() {
    //Fill the array with Cell instances. Must be a better way to do this.
    for(int i =0; i<board.GetLength(0); i++) {
      for(int j =0; j<board.GetLength(0); j++) {
        board[i, j] = new Cell();
      }
    }
  }

  public void setCell(int xPos, int yPos, bool isAlive) { //Made as a shorthand method to set the array value
    board[xPos, yPos].alive = isAlive;
  }

  //This method looks for all squares with the given life state in a 3x3 square around the position
  public int getAdjacent(int xPos, int yPos, bool isAlive) { 
  int counter = 0; //Counts the cells that meet the given value

    for(int i = -1; i<=1; i++) {
      for(int j = -1; j<=1; j++) {
        // Ignores the given cell
        if((i == 0 && j == 0)) { 
          continue;
        }

        try { 
          //Try statement prevents an error from trying to find a cell that isn't on the board
          if(board[xPos + i, yPos + j].alive == isAlive) { 
            counter++;
          }
        } catch {}

      }
    }
    return counter;
  }

  //Implements the rules of the game of life to decide the fate of the selected cell. Returns the value of the cell as a boolean, true being alive

  public bool getFutureState(int xPos, int yPos) { 
    int neighbors = this.getAdjacent(xPos, yPos, true);
    bool isAlive = board[xPos, yPos].alive;
    if(neighbors == 3 && !isAlive) {
      return true;
    } else if(neighbors < 2 || neighbors > 3) {
      return false;
    } else {
      return isAlive;
    }
  }
}