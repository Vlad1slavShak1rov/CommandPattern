using CommandPattern;

TextEditor editor = new TextEditor();

ICommand insertHello = new InsertTextCommand(editor, "Hello");
editor.ExecuteCommand(insertHello);

ICommand insertWorld = new InsertTextCommand(editor, " World");
editor.ExecuteCommand(insertWorld);

ICommand deleteCommand = new DeleteTextCommand(editor, 6); 
editor.ExecuteCommand(deleteCommand);

editor.Undo();
editor.Undo();
editor.Undo();
editor.Undo();