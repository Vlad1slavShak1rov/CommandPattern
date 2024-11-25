using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DeleteTextCommand:ICommand
    {
        private readonly TextEditor _textEditor;
        private readonly int _length;
        private string _deletedText;

        public DeleteTextCommand(TextEditor textEditor, int length)
        {
            _textEditor = textEditor;
            _length = length;
        }
        public void Execute()
        {
            _deletedText = _textEditor.DeleteText(_length);
        }
        public void Undo()
        {
            if (_deletedText != null)
            {
                _textEditor.InsertText(_deletedText);
            }
        }
    }
}
