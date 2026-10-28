using Labyrinth.Items;
using Labyrinth.Tiles;

namespace Labyrinth.Crawl;

public class LabyrinthCrawler(int x, int y, Direction direction, Func<int, int, Tile> tileAt)
    : ICrawler
{
    public int X { get; } = x;
    public int Y { get; } = y;
    public Direction Direction { get; } = direction;
    public Tile FacingTile => tileAt(X + Direction.DeltaX, Y + Direction.DeltaY);

    public Inventory Walk()
    {
        throw new NotImplementedException();
    }
}