using System;
using System.Collections.Generic;
using System.Text;

namespace _008B_AdapterDesignPattern
{
    class NotebookAdapter : I_Notebook, I_Notebook_v2
    {
        Notebook_v2 notebook = new Notebook_v2();

        public void createNote(string title, string note)
        {
            notebook.createNote(title, note, null);
        }

        public void createNote(string title, string note, string recipient)
        {
            notebook.createNote(title, note, recipient);
        }

        public string getNote(string title)
        {
            return notebook.getNote(title);
        }

        public string notesCatalog()
        {
            return notebook.notesList();
        }

        public string notesList()
        {
            return notebook.notesList();
        }

        public string removeNote(string title)
        {
            return notebook.removeNote(title);
        }
    }
}
