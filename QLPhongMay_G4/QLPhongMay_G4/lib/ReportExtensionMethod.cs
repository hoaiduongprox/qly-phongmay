using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words.Tables;
using Aspose.Words;

namespace QLPhongMay_G4
{
    internal static class ReportExtensionMethod
    {
        public static void PutValue(this Table table, int row, int column, string text)
        {
            Row r = table.Rows[row];
            if (r == null || text == null)
                return;

            Cell cell = r.Cells[column];
            if (cell == null)
                return;

            var paragraph = cell.Paragraphs[0];
            if (paragraph == null)
                cell.Paragraphs.Add(new Paragraph(cell.Document));
            paragraph = cell.Paragraphs[0];

            var run = paragraph.Runs[0];
            if (run == null)
                paragraph.Runs.Add(new Run(paragraph.Document));
            run = paragraph.Runs[0];

            run.Text = text;
        }

        public static void PutValue(this Row r, int column, string text)
        {
            if (r == null)
                return;
            Cell cell = r.Cells[column];
            if (cell == null)
                return;

            var paragraph = cell.Paragraphs[0];
            if (paragraph == null)
                cell.Paragraphs.Add(new Paragraph(cell.Document));
            paragraph = cell.Paragraphs[0];

            var run = paragraph.Runs[0];
            if (run == null)
                paragraph.Runs.Add(new Run(paragraph.Document));
            run = paragraph.Runs[0];

            run.Text = text != null ? text : "";
        }

        //public static void ChangeFont(this Row r, int column, string font_name = "Time New Roman", float font_size = 14f)
        //{
        //    if (r.Cells[column] != null
        //        && r.Cells[column].FirstParagraph != null
        //        && r.Cells[column].FirstParagraph.Runs[0] != null
        //        && r.Cells[column].FirstParagraph.Runs[0].Font != null)
        //    {
        //        r.Cells[column].FirstParagraph.Runs[0].Font.Name = font_name;
        //        r.Cells[column].FirstParagraph.Runs[0].Font.Size = font_size;
        //    }
        //}

        //public static void ChangeFont(this Row r, string font_name = "Time New Roman", float font_size = 14f)
        //{
        //    if (r == null)
        //        return;
        //    for (int i = 0; i < r.Cells.Count; i++)
        //        r.ChangeFont(i, font_name, font_size);
        //}

        
    }

    internal static class Ex
    {
        public static void SaveAndOpenFile(this Document doc, string filename = "tmp.doc")
        {
            string thuMuc = "temp";
            if (!Directory.Exists(thuMuc))
                Directory.CreateDirectory(thuMuc);

            while (true)
            {
                string tenTep = $"{thuMuc}\\{filename}";
                try
                {
                    doc.Save(tenTep);
                    Process.Start(tenTep);
                    break;
                }
                catch
                {
                }
            }
        }
    }
}
