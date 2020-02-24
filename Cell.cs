class Cell { //Represents a cell.
  public bool alive;
  public Cell() {
    this.alive = false;
  }

  public void kill() {
    this.alive = false;
  }

}