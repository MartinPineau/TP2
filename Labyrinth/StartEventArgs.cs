namespace Labyrinth;

public class StartEventArgs(int x, int y) : EventArgs
{
    public required int X { get; init; } = x;
    public required int Y { get; init; } = y;
}