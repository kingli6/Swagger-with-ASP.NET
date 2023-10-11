using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using notes_swaggerApi.Data.Models;

namespace notes_swaggerApi.Services
{
    public interface INotesServices
    {
        Note CreateNote(Note note);
        Note GetNote(int id);
        List<Note> GetNotes();
        void DeleteNote(int id);
        void EditNote(Note note);

    }
}