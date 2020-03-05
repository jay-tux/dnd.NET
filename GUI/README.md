#Jay-tux's D&D 5e Tools - GUI part
*Notice: this part is only for developers, regular users should stay on [Basic Usage](https://github.com/jay-tux/dnd.NET)*

## Description
The GUI branch/folder contains all styling/visual parts of the dnd.NET system.
This folder is not really for the logic, and most logic calls are done to the files on the ``Player`` or ``DM`` branch.
## Contents
This folder contains three kinds of files:
 * ``*.cs`` files: these contain the links between the logic and the UI design.  
 * ``*.Designer.cs`` files: these contain the organization of the ``System.Windows.Forms.Control`` controls driving the UI.  
 * Some other files:  
  * ``DefaultFonts.cs``: contains the default fonts and colors for the textual parts of the UI.  
  * ``StyledLabel.cs``: contains prepared ``System.Windows.Forms.Label`` labels for quick access.  
  * ``StyledGroupBox.cs``: contains a prepared ``System.Windows.Forms.GroupBox`` groupbox for quick access; requires ``RoundedRect.cs``.
  * ``RoundedRect.cs``: contains a method for creating colored borders with rounded corners for the ``StyledGroupBox.cs``
