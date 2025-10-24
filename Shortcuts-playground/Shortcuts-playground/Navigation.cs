public class LetsNavigateThis
{
    // Standard Windows - In file
    // Use Ctrl+right and Ctrl+left to jump from word to word (works all-over windows)
    // Use Ctrl+Start and Ctrl+End to go to start and end of line
    // Combine with Shift to select
    // Ctrl+x or Shift+del to cut current line

    // Standard Windows - File navigation
    // Ctrl+tab to go to previous file
    // Ctrl+tab n times to go through the latest files (press shift to change direction)
    // Ctrl+F4 to close current tab

    /* Ctrl+t Go to everything */
    // 1. Look for MoveInstanceMethod, go there and come back with Ctrl+-
    // Try again, searching for "mim" (the capital letters)
    // Try again, searching for movime (a part of some words)
    // (Rider only) Try again and split this screen horizontally

    /* F12 - Go to definition */
    // 2. Go to definition of IPoint
    public class Line
    {
        public IPoint Start { get; set; }
        public IPoint End { get; set; }

        public void Draw()
        {
            Console.WriteLine($"From {Start.X} {Start.Y} to {End.X} {End.Y}");
        }
    }

    /* Ctrl+F12 - Go to implementation*/
    // 2. Go to implementation of IPoint
    public interface IPoint
    {
        int X { get; set; }
        int Y { get; set; }
    }

    /* Shift+F12 - Go to usages*/
    // 3. Find usages of IPoint (toy around with the window, lots of possibilities - read/write usages, ...)
    public class Point : IPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    // 4. Make a new implementation of IPoint and then try to Go to implementation again

    /* Ctrl+M+L Collapse all */
    /* Ctrl+M+O Expand all */
    /* Ctrl+M+M Expand/Collapse current location */
    /* Rider Only :( --> Ctrl+Shift+Numpad* (release Ctrl+Shift and then press the number of nesting level you want - Fold all methods in class with specific nesting level */
    
    // 5. Collapse all classes and then expand only the first level

    public class AClass
    {
        public int WithAMethod()
        {
            return 0;
        }

        public class NestedClass
        {
            public int InnerMethod()
            {
                return 0;
            }

            public class EvenMoreNestedClass
            {
                public int InnerInnerMethod()
                {
                    return 0;
                }
            }
        }
    }

    /* Alt+arrow up/down go to next method */
    /* Ctrl+arrow up/down window */
    // 6. Use Alt+arrow up/down to navigate between methods in this class and in the nested classes
    public class ANavigationClass
    {
        public int WithAMethod()
        {
            return 0;
        }

        public class NestedClass
        {
            public int InnerMethod()
            {
                return 0;
            }

            public class EvenMoreNestedClass
            {
                public int InnerInnerMethod()
                {
                    return 0;
                }
            }
        }
    }
}

/* Ctrl+- - Move cursor to previous position (VS Only) */
/* Ctrl+Shift+- -  Undo move cursor to previous position (VS Only)*/
// 6. Click in the places where there is an asterisk in the following 3 lines and then use Ctrl+- to go back and Ctrl+Shift+- to go forward
// The *quick brown * fox
// jumps * over the * lazy dog

/* Ctrl+, Show recent files */
/* Ctrl+Shift+, Show recent edits */
