using System;

class MainClass { 
  public static void Main (string[] args) {
    Grid grid = new Grid();
    Display display = new Display(grid);

    grid.setCell(3, 3, true);
    grid.setCell(4, 4, true);
    grid.setCell(5, 5, true);
    grid.setCell(6, 6, true);


    display.show();

    Console.WriteLine(grid.getAdjacent(1, 1, true));

  }
}