using SnakeGame.ConsoleApp.UserInterface;

Console.CursorVisible = false;

var snake = new Snake();

var continuePlaying = true;

ScreenPrinter.PrintStartingScreen();

var input = Console.ReadKey();

Console.Clear();

while (continuePlaying)
{
    var inputAction = InputHandler.ReceiveInputAction(ref input);

    switch (inputAction)
    {
        case InputAction.MoveUp:
            snake.MoveBody(Direction.Up);
            break;
        case InputAction.MoveDown:
            snake.MoveBody(Direction.Down);
            break;
        case InputAction.MoveLeft:
            snake.MoveBody(Direction.Left);
            break;
        case InputAction.MoveRight:
            snake.MoveBody(Direction.Right);
            break;
        case InputAction.Quit:
            continuePlaying = false;
            break;
    }
   
    ScreenPrinter.Print(snake);

    Thread.Sleep(100);
}

ScreenPrinter.PrintExitScreen();
Console.ReadKey();
