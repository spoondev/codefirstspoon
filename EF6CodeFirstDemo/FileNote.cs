using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstDemo
{
    public class FileNote
    {
        public int FileNoteId { get; set; }
        public FileInfo FileInfo { get; set; }
        public string NoteText { get; set; }
        public Employee Employee { get; set; }

        public ICollection<FileInfo> FileInfos { get; set; }
    }
}
