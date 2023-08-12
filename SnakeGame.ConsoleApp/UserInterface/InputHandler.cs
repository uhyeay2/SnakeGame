namespace SnakeGame.ConsoleApp.UserInterface
{
    public static class InputHandler
    {
        private static ConsoleKeyInfo MonitorInput(ConsoleKeyInfo currentKey)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo breakKey = Console.ReadKey(intercept: true);

                if (breakKey != currentKey)
                {
                    return breakKey;
                }
                else
                    return currentKey;
            }
            else
                return currentKey;
        }

        public static InputAction ReceiveInputAction(ref ConsoleKeyInfo keyInfo)
        {
            keyInfo = MonitorInput(keyInfo);

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow: return InputAction.MoveUp;
                case ConsoleKey.DownArrow: return InputAction.MoveDown;
                case ConsoleKey.LeftArrow: return InputAction.MoveLeft;
                case ConsoleKey.RightArrow: return InputAction.MoveRight;
                case ConsoleKey.Q: return InputAction.Quit;
                default: return InputAction.NonRegisteredInput;
            }
        }
    }
}
