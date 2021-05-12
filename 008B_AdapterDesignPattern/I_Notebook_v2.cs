using System;
using System.Collections.Generic;
using System.Text;

namespace _008B_AdapterDesignPattern
{
    interface I_Notebook_v2
    {
        void createNote(string title, string note, string recipient);
        string getNote(string title);
        string removeNote(string title);
        string notesList();
    }
}
