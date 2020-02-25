using System;

class MainClass { 
  public static void Main (string[] args) {

    // int[,] aliveCells = new int[,] {{0,0},{1,1},{2,2}};
    Grid theGrid = new Grid();

    theGrid.setCell(0, 0, true);
    theGrid.setCell(1, 1, true);

  }
}