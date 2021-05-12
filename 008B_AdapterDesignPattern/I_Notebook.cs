using System;
using System.Collections.Generic;
using System.Text;

namespace _008B_AdapterDesignPattern
{
    interface I_Notebook
    {
        void createNote(string title, string note);
        string getNote(string title);
        string removeNote(string title);
        string notesCatalog();
    }
}
