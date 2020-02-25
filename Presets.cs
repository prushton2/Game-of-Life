class Presets {
  private Grid grid;
  public Presets(Grid grid) {
    this.grid = grid;
  }
  public void pentadecathlon(int xoffset, int yoffset) {
    grid.setCell(yoffset+0, xoffset+1, true);
    grid.setCell(yoffset+1, xoffset+1, true);

    grid.setCell(yoffset+2, xoffset+0, true);
    grid.setCell(yoffset+2, xoffset+2, true);
    
    grid.setCell(yoffset+3, xoffset+1, true);
    grid.setCell(yoffset+4, xoffset+1, true);
    grid.setCell(yoffset+5, xoffset+1, true);
    grid.setCell(yoffset+6, xoffset+1, true);
    
    grid.setCell(yoffset+7, xoffset+0, true);
    grid.setCell(yoffset+7, xoffset+2, true);

    grid.setCell(yoffset+8, xoffset+1, true);
    grid.setCell(yoffset+9, xoffset+1, true);

  }

  public void t(int xoffset, int yoffset) {
    grid.setCell(yoffset+0, xoffset+0, true);
    grid.setCell(yoffset+0, xoffset+1, true);
    grid.setCell(yoffset+0, xoffset+2, true);
    grid.setCell(yoffset+1, xoffset+1, true);
  }
}