using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t5.Interfaces
{
    public interface INotable
    {
        Note CreateNote(int id, string body, DateTime date, bool isAlertNeeded);
        void UpdateNote(Note note);
        string ReadNote(Note note);
        bool DeleteNote(List<Note> notes, int id);
    }
}
