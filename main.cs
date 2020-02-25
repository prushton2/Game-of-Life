using System;

class MainClass { 
  public static void Main (string[] args) {
    Grid theGrid = new Grid();
    Display display = new Display(theGrid);

    theGrid.setCell(0, 0, true);
    theGrid.setCell(0, 1, true);
    theGrid.setCell(0, 9, true);


    display.show();

  }
}