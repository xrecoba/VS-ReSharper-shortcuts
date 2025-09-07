public class LetsNavigateThis
{
    // Standard Windows
    // Use Ctrl+right and Ctrl+left to jump from word to word (works all-over windows)
    // Use Ctrl+Start and Ctrl+End to go to start and end of line
    // Combine with Shift to select
    
    // Ctrl+t Go to everything
    // Look for MoveInstanceMethod, go there and come back with Ctrl+-
    // Try again, searching for "mim" (the capital letters)
    // Try again, searching for movime (a part of some words)
    
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
    
    // Ctrl+- in VS (Not working on rider, Ctrl+Shift+Left but it's shrink selection)
    // Move cursor to previous position
    // Click in the places where there is an asterisk in the following 3 lines
    // The *quick brown * fox
    // jumps * over the * lazy dog
    
    // Ctrl+, Show recent files and other windows
}