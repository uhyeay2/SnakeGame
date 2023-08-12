public class Snake
{
    public Snake() : this(Console.WindowWidth / 2, Console.WindowHeight / 2) { }

    public Snake(int x, int y)
    {
        _bodyParts = new()
        {
            new(x, y),
            new(x, y - 1),
            new(x, y - 2),
        };
    }
    
    public IEnumerable<(int xPosition, int yPosition)> AllBodyPartPositions => _bodyParts.Select(_ => _.Position);

    public (int xPostion, int yPosition) LastPositionBehindTail => _lastPositionBehindTail;

    private readonly List<SnakeBodyPart> _bodyParts;

    private (int xPosition, int yPosition) _lastPositionBehindTail;

    public void MoveBody(Direction directionToMove)
    {
        _lastPositionBehindTail = _bodyParts.Last().Position;

        for (int i = _bodyParts.Count - 1; i >= 0; i--)
        {
            // if moving the first body part (head) then use input for direction
            if (i == 0)
            {
                _bodyParts[i].MoveTo(directionToMove);
            }
            // any other body part moves to the position of the body part in front of it.
            else
            {
                var nextPosition = _bodyParts[i - 1].Position;

                _bodyParts[i].MoveTo(nextPosition.xPosition, nextPosition.yPosition);
            }
        }
    }
}
