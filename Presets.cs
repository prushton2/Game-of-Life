class Presets {
  private Grid grid;
  public Presets(Grid grid) {
    this.grid = grid;
  }
  public void Clover(int xoffset, int yoffset) {
    grid.setCell(yoffset+0, xoffset+4, true);
    grid.setCell(yoffset+0, xoffset+6, true);
    grid.setCell(yoffset+1, xoffset+4, true);
    grid.setCell(yoffset+1, xoffset+6, true);
    grid.setCell(yoffset+2, xoffset+5, true);
    grid.setCell(yoffset+2, xoffset+0, true);
    grid.setCell(yoffset+0, xoffset+0, true);
    grid.setCell(yoffset+0, xoffset+0, true);
    grid.setCell(yoffset+0, xoffset+0, true);
    grid.setCell(yoffset+0, xoffset+0, true);
    grid.setCell(yoffset+0, xoffset+0, true);
    grid.setCell(yoffset+0, xoffset+0, true);
  }

  public void t(int xoffset, int yoffset) {
    grid.setCell(yoffset+0, xoffset+0, true);
    grid.setCell(yoffset+0, xoffset+1, true);
    grid.setCell(yoffset+0, xoffset+2, true);
    grid.setCell(yoffset+1, xoffset+1, true);
  }
}