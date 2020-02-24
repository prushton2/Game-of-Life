class Cell { //Represents a cell.
  public bool alive;
  public Cell(bool alive) {
    this.alive = alive;
  }

  public void kill() {
    this.alive = false;
  }

}