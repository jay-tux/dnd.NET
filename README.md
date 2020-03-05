# Jay-tux's D&D 5e Tools
## A full software suite for D&D, cross-platform using Mono/C#

# Building
Building dnd.NET differs from OS to OS:
## Windows
Open the ``./dnd.NET.csproj`` in your favorite C# editor (such as MS Visual Studio), and click the run button. 
This action will create a ``*.exe`` file which you can run easily
## Linux/Mac OS
Building dnd.NET on Unix-based systems requires the ``mono`` package (more specifically, the ``mcs`` and ``mono`` commands).
The ``mcs`` command compiles a [list of] C# file[s], creating a native C# executable.
The ``mono`` command runs a Mono/C# executable.  
For user convenience, there is the ``./compileRun.sh`` bash-executable.
### Manjaro/Arch Linux
This project was developed on Manjaro Linux, and ships with a default build for those OS's. 
This executable is located under ``bin/dnd.NET.exe``.
### ./compileRun.sh
This file can compile and run the dnd.NET software. 
Command-line arguments:
 * ``-c``: Compile dnd.NET (executable is named ``bin/dnd.NET.exe``),  
 * ``-r``: Run dnd.NET (requires ``bin/dnd.NET.exe``),  
 * ``-h``: Shows the help.
