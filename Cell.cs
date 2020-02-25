public class Cell { //Represents a cell.
  public bool alive = false;
  public bool nextState = false;
  public Cell() {
    this.alive = false;
  }

  public void kill() {
    this.alive = false;
  }

}