using System;
using System.Collections.Generic;
using System.Text;

namespace _008B_AdapterDesignPattern
{
    class Note
    {
        public string title { get; }
        public string note { get; }
        string recipient;
        public Note(string title, string note, string recipient)
        {
            this.title = title;
            this.note = note;
            this.recipient = recipient;
        }
    }
}
