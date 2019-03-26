using System.Collections.Generic;
using System.Data.Entity;

namespace EF6CodeFirstDemo
{
    public class DBInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {


            //public int FileInfoId { get; set; }
            //public string FileName { get; set; }
            //public string FilePath { get; set; }
            //public string ContainerPath { get; set; }
            //public string Volume { get; set; }

            //public string Size { get; set; }
            //public string CTime { get; set; }
            //public string MTime { get; set; }
            //public string ATime { get; set; }
            //public string Md5 { get; set; }


        //IList<FileInfo> fileInfos = new List<FileInfo>();

        //    fileInfos.Add(new FileInfo() { FileName = "", Section = "A" });
        //    fileInfos.Add(new Grade() { GradeName = "Grade 1", Section = "B" });
        //    fileInfos.Add(new Grade() { GradeName = "Grade 1", Section = "C" });
        //    fileInfos.Add(new Grade() { GradeName = "Grade 2", Section = "A" });
        //    fileInfos.Add(new Grade() { GradeName = "Grade 3", Section = "A" });

            IList<Grade> grades = new List<Grade>();

            grades.Add(new Grade() { GradeName = "Grade 1", Section = "A" });
            grades.Add(new Grade() { GradeName = "Grade 1", Section = "B" });
            grades.Add(new Grade() { GradeName = "Grade 1", Section = "C" });
            grades.Add(new Grade() { GradeName = "Grade 2", Section = "A" });
            grades.Add(new Grade() { GradeName = "Grade 3", Section = "A" });

            context.Grades.AddRange(grades);

            base.Seed(context);
        }
    }
}