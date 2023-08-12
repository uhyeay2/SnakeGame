namespace SnakeGame.ConsoleApp.UserInterface
{
    public static class ScreenPrinter
    {
        public static void Print(Snake snake)
        {
            foreach (var position in snake.AllBodyPartPositions)
            {
                PrintAtPosition(position, '#');
            }

            PrintAtPosition(snake.LastPositionBehindTail, ' ');
        }

        private static void PrintAtPosition((int xPosition, int yPosition) positionToPrintAt, char character)
        {
            Console.SetCursorPosition(positionToPrintAt.xPosition, positionToPrintAt.yPosition);

            Console.Write(character);
        }

        public static void PrintStartingScreen()
        {
            Console.Clear();
            Console.WriteLine("Lets play Snake! Press an arrow key to begin.");
        }

        public static void PrintExitScreen()
        {
            Console.Clear();

            Console.WriteLine("\nThanks for playing Snake!");
            Console.WriteLine("\nPress any key to close end the application.");
        }
    }
}
