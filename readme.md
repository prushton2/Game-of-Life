# Game Of Life

### Rules

See also: [wiki page](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life)

* Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
* Any live cell with two or three live neighbours lives on to the next generation.
* Any live cell with more than three live neighbours dies, as if by overpopulation.
* Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

### Running:

Runs on vanilla C#

You can set custom starting points with grid.setCell(xPos, yPos, true);