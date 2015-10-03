# Unity Omnisharp symlink bug
This project works fine in Unity, but Omnisharp in Atom will double-count references to the symlinked files, giving a linter error for every method / class / property declaration.

To reproduce:

1. Clone the repo
2. Change to the Scripts directory: `cd Assets/Scripts/`
3. Recreate the symlink: `ln -Fs ../../Symlink/ Symlink/`
4. Open the Unity project and make sure it compiles in Unity
5. Open the directory in Atom and open `SymlinkTest2.cs`
6. Notice the linter errors
