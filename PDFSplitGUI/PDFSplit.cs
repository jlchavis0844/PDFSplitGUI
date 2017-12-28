using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PDFSplitComplete {
    public class PDFSplit {
        public List<PdfOut> outs;
        
        /// <summary>
        /// Processes the main logic that splits the PDF file.
        /// </summary>
        /// <param name="myParams"></param>
        public PDFSplit(string[] myParams) {
            outs = new List<PdfOut>();

            for (int i = 2; i < myParams.Length; i += 4) {
                string tFile = myParams[0];
                string tOutPath = myParams[1];
                int tStart = Convert.ToInt32(myParams[i]);
                int tEnd = Convert.ToInt32(myParams[i + 1]);
                string tType = myParams[i + 2];
                int tTurn = Convert.ToInt32(myParams[i + 3]);


                outs.Add(new PdfOut(tFile, tOutPath, tStart, tEnd, tType, tTurn));
            }

            for (int i = 0; i < outs.Count; i++) {
                PdfReader reader = new PdfReader(myParams[0]);
                Document document = new Document(reader.GetPageSizeWithRotation(outs[i].endPage));
                PdfCopy copy = null;
                try {
                    copy = new PdfCopy(document, new System.IO.FileStream(outs[i].outFile, System.IO.FileMode.Create));
                } catch (Exception eOpen) {
                    string msg = "Error opening save file, is the file you are saving to already open?\n";
                    System.Windows.Forms.MessageBox.Show(msg + eOpen.ToString());
                    return;
                }
                document.Open();
                
                PdfDictionary page;
                PdfNumber rotate;
                for (int j = outs[i].startPage; j <= outs[i].endPage; j++) {
                    page = reader.GetPageN(j);
                    rotate = page.GetAsNumber(PdfName.ROTATE);
                    page.Put(PdfName.ROTATE, new PdfNumber(outs[i].rotate));
                    copy.AddPage(copy.GetImportedPage(reader, j));
                }
                document.Close();
                reader.Close();
            }
        }

        /// <summary>
        /// Returns all the created files
        /// </summary>
        /// <returns></returns>
        public List<string> GetOutFiles() {
            return outs.Select(o => o.outFile).ToList();
        }
    }
}