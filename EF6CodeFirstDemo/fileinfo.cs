using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstDemo
{
    public class FileInfo
    {
        public int FileInfoId { get; set; }
        public string FileName { get; set; }
        public string  FilePath { get; set; }
        public string ContainerPath { get; set; }
        public string Volume { get; set; }
        
        public string Size { get; set; }
        public string CTime { get; set; }
        public string MTime { get; set; }
        public string ATime { get; set; }
        public string Md5 { get; set; }

        public Employee Employee { get; set; }

        //public decimal Height { get; set; }
        //public float Weight { get; set; }
        //public byte[] RowVersion { get; set; }
        //DateTime?

        //fully defined relationship
        //public int? GradeId { get; set; }

        //public virtual Grade Grade { get; set; }

        //public virtual StudentAddress Address { get; set; }
        //public virtual ICollection<Course> Courses { get; set; }
    }
}
