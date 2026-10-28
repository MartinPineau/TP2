using Labyrinth.Items;
using Labyrinth.Tiles;

namespace Labyrinth.Crawl;

public class LabyrinthCrawler(int x, int y, Direction direction, Func<int, int, Tile> tileAt)
    : ICrawler
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public Direction Direction { get; } = direction;
    public Tile FacingTile => tileAt(X + Direction.DeltaX, Y + Direction.DeltaY);
    
    
    public Inventory Walk()
    {
        if(!FacingTile.IsTraversable) throw new InvalidOperationException("Cannot walk on non-traversable tile");

        var inventory = FacingTile.Pass();
        X += Direction.DeltaX;
        Y += Direction.DeltaY;
        return inventory;
    }
}