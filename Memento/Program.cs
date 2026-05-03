using Memento;

Console.WriteLine("\n--- Завдання 5: Мементо ---");
var doc = new TextDocument();
var editor = new TextEditor(doc);

editor.Type("Hello");
editor.SaveState();

editor.Type(" World!");
editor.Print();

editor.Undo();
editor.Print();