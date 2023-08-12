public class SnakeBodyPart
{
    public SnakeBodyPart(int xPosition, int yPosition)
    {
        _xPosition = xPosition;
        _yPosition = yPosition;
    }

    public (int xPosition, int yPosition) Position => (_xPosition, _yPosition);

    private int _xPosition { get; set; }
    private int _yPosition { get; set; }   

    public void MoveTo(int x, int y)
    {
        _xPosition = x;
        _yPosition = y;
    }

    public void MoveTo(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                _yPosition--;
                break;
            case Direction.Down:
                _yPosition++;
                break;
            case Direction.Left:
                _xPosition--;
                break;
            case Direction.Right:
                _xPosition++;
                break;
        }
    }
}