# Flatpack | Architecture

## Design Goals

Contains core functionality for the Flatpack project. This includes:

- Modular shared data model (using ScriptableObjects)
- Event Channel system
- Helper behaviours, for using the event & shared data model system

These are dsigned as frameworks to assist in building the game, without directly containing any game logic itself.



Please see the design [Miro board](https://miro.com/app/board/uXjVNdVSglY=/?share_link_id=908877704591) for some high-level diagrams.

## Codegen Note

This package makes use of "CodeGen", a Python script that processes template files, and will generate source for new files.

We use `CodeGen` over C# Source Generation, as this doesn't require us to compile to a .DLL. Being able to compile straight from source allows for much greater iteration speed when working inside the Unity Editor.

If Generic types are not able to be used in the Unity Editor, please ensure you are properly making use of `CodeGen`, and, that you have recently ran `CodeGen`.

To run `CodeGen`, simply execute `python -m CodeGen` from inside the package's directory.

`CodeGen` does not require any external dependencies to run. In the future, `CodeGen` is planned to be spun off from this repository, and included via Git SubModule, so that it can be used in other parts of the `Flatpack` project.