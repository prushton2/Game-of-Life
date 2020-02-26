using System;
class Presets {
  
  Random gen = new Random();
  private Grid grid;

  public Presets(Grid grid) {
    this.grid = grid;
  }
  public void pentadecathlon(int xoffset, int yoffset) {
    int[,] posArray = new int[,] {
      {0, 1}, {1, 1}, {2, 0}, {2, 2}, {3, 1}, {4, 1},
      {5, 1}, {6, 1}, {7, 0}, {7, 2}, {8, 1}, {9, 1}
    };
    for(int i = 0; i<posArray.GetLength(0); i++) {
      grid.setCell(yoffset+posArray[i, 0], xoffset+posArray[i, 1], true);
    }

  }

  public void t(int xoffset, int yoffset) {
    int[,] posArray = new int[,] {
      {0, 0}, {0, 1}, {0, 2}, {1, 1}
    };
    for(int i = 0; i<posArray.GetLength(0); i++) {
      grid.setCell(yoffset+posArray[i, 0], xoffset+posArray[i, 1], true);
    }
  }

  public void cloverleaf(int xoffset, int yoffset) {
    int[,] posArray = new int[,] {
      {0, 4}, {0, 6}, {1, 4}, {1, 6}, {2, 5}, {4,5},
      {1,3}, {1,2}, {2,1}, {3,1}, {4,2}, {4,3}, {3,3},
      {1,7}, {1,8}, {2,9}, {3,9}, {4,8}, {4,7}, {3,7},

      {10, 4}, {10, 6}, {9, 4}, {9, 6}, {8, 5}, {6,5},
      {9,3}, {9,2}, {8,1}, {7,1}, {6,2}, {6,3}, {7,3},
      {9,7}, {9,8}, {8,9}, {7,9}, {6,8}, {6,7}, {7,7},
    };
    for(int i = 0; i<posArray.GetLength(0); i++) {
      grid.setCell(yoffset+posArray[i, 0], xoffset+posArray[i, 1], true);
    }
  }

  public void spaceship(int xoffset, int yoffset) {
    int[,] posArray = new int[,] {
      {0,0}, {1,1}, {1,2}, {2,1}, {2,0}
    };
    for(int i = 0; i<posArray.GetLength(0); i++) {
      grid.setCell(yoffset+posArray[i, 0], xoffset+posArray[i, 1], true);
    }
  }

  public void random(int xoffset, int yoffset, int xsize, int ysize) {
    for(int i = 0; i<xsize; i++) {
      for(int j = 0; j<ysize; j++) {
        grid.setCell(yoffset+j, xoffset+i, gen.Next(100) <= 40);
      }
    }
  }
}