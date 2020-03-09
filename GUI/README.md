# Jay-tux's D&D 5e Tools - GUI part
*Notice: this part is only for developers, regular users should stay on [Basic Usage](https://github.com/jay-tux/dnd.NET)*

## Description
The GUI branch/folder contains all styling/visual parts of the dnd.NET system.
This folder is not really for the logic, and most logic calls are done to the files on the ``Player`` or ``DM`` branch.
## Contents
This folder contains three kinds of files:
 * Most of the ``*.cs`` files: these contain the links between the logic and the UI design.  
 * ``*.Designer.cs`` files: these contain the organization of the ``System.Windows.Forms.Control`` controls driving the UI.  
 * Some other files:  
  * ``DefaultFonts.cs``: contains the default fonts and colors for the textual parts of the UI.  
  * ``Styled*.cs``: contains a pre-styled version of the ``System.Windows.Forms`` Controls 
  * ``RoundedRect.cs``: contains a method for creating colored borders with rounded corners for the ``StyledGroupBox.cs``