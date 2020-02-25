using System;

class MainClass { 
  public static void Main (string[] args) {
    Grid grid = new Grid();
    Grid grid2 = new Grid(); //Stores future states of cells
    Display display = new Display(grid);

    grid.setCell(3, 3, true);
    grid.setCell(3, 4, true);
    grid.setCell(3, 5, true);
    grid.setCell(3, 6, true);


    display.show();

    grid2.setCell(4, 5, grid.getFutureState(4, 5));

    display.show();

    // Console.WriteLine(grid.getAdjacent(1, 1, true));

  }
}