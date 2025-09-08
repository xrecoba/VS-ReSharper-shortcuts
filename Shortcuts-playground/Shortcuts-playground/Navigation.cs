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
    
    // Ctrl+t Go to everything
    // Look for MoveInstanceMethod, go there and come back with Ctrl+-
    // Try again, searching for "mim" (the capital letters)
    // Try again, searching for movime (a part of some words)
    // Try again and split this screen horizontally
    
    // Ctrl+F12 - Go to definition of point
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public void Draw()
        {
            Console.WriteLine($"From {Start.X} {Start.Y} to {End.X} {End.Y}");
        }
    }

    // Shift+F12 - Find usages of X (toy around with the window, lots of possibilities - read/write usages, ...)
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    
    // Fold all methods in class with specific nesting level
    // Ctrl+Shift+Numpad*, number of nesting level
    // Ctrl+M+M Expand/Collapse current region
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
    
    // Alt+arrow up/down go to next method
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
    
    // Ctrl+- in VS (Not working on rider, Ctrl+Shift+Left but it's shrink selection)
    // Move cursor to previous position
    // Click in the places where there is an asterisk in the following 3 lines
    // The *quick brown * fox
    // jumps * over the * lazy dog
    
    // Ctrl+, Show recent files and other windows
}