using System.IO;

namespace PDFSplitComplete {
    public class PdfOut {
        public string fileName { get; set; }
        public string extension { get; set; }
        public string path { get; set; }
        public string outFile { get; set; }
        public int startPage { get; set; }
        public int endPage { get; set; }
        public int rotate { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="file"></param>
        /// <param name="outPath"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="type"></param>
        /// <param name="turn"></param>
        public PdfOut(string file, string outPath, int start, int end, string type, int turn) {
            fileName = Path.GetFileNameWithoutExtension(file);
            extension = Path.GetExtension(file);
            path = Path.GetDirectoryName(file);
            outFile = outPath + "\\" + fileName + "_" + type + extension;
            startPage = start;
            endPage = end;
            rotate = turn;
        }

        /// <summary>
        /// Overridden ToString() for printing.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return path + "\\" + fileName + " " + outFile + " " + startPage + " " + endPage;
        }
    }
}