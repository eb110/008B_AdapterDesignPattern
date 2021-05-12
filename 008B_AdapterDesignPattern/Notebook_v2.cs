using System;
using System.Collections.Generic;
using System.Text;

namespace _008B_AdapterDesignPattern
{
    public class Notebook_v2 : I_Notebook_v2
    {
        private List<Note> noteList = new List<Note>();

        public void createNote(string title, string note, string recipient)
        {
            noteList.Add(new Note(title, note, recipient));
        }

        public string getNote(string title)
        {
            string res = noteList.Find(x => x.title.Equals(title)).note;
            return String.IsNullOrEmpty(res) ? null : res;
        }

        public string notesList()
        {
            return "lista";
        }

        public string removeNote(string title)
        {
            for(var i = 0; i < noteList.Count; i++)
            {
                if(noteList[i].title.Equals(title))
                {
                    string note = noteList[i].note;
                    noteList.RemoveAt(i);
                    return note;
                }
            }
            return null;
        }
    }
}
