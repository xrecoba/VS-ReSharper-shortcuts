namespace ShortcutsPlayground;

/* Ctrl+Shift+number Adds or remove bookmark */
/* Ctrl+number goes to the bookmark */
/* Ctrl+` to see all bookmarks */

// 1. Put bookmarks 1, 4 and 5, one for each class 
// 2. Use Ctrl+number to navigate between them
// 3. Put a bookmark in another file and navigate between them.
// 4. Remove bookmark 4 using the keyboard
// 5. Open the bookmarks window
public class Bookmarking
{
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
}