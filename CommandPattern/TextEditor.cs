using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TextEditor
    {
        private string _text;
        private readonly Stack<ICommand> _commands = new ();

        public void InsertText(string txt)
        {
            _text += txt;
        }

        public string DeleteText(int length)
        {
            if (length > _text.Length)
                length = _text.Length;

            string deletedText = _text.Substring(_text.Length - length);
            _text = _text.Substring(0, _text.Length - length);
            Console.WriteLine($"Текст после удаления: {_text}");
            return deletedText;
        }
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commands.Push(command);
        }

        public void Undo()
        {
            if (_commands.Count > 0)
            {
                ICommand command = _commands.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("Нет команд для отмены.");
            }
        }
    }
}
