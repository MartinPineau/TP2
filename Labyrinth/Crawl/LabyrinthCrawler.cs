using Labyrinth.Items;
using Labyrinth.Tiles;

namespace Labyrinth.Crawl;

public class LabyrinthCrawler(int x, int y, Direction direction, Tile facingTile)
    : ICrawler
{
    public int X { get; } = x;
    public int Y { get; } = y;
    public Direction Direction { get; } = direction;
    public Tile FacingTile { get; } = facingTile;

    public Inventory Walk()
    {
        throw new NotImplementedException();
    }
}