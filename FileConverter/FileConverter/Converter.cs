using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SautinSoft.Document;

namespace FileConverter
{
    class Converter
    {
        public void StartConvert(string FormatOriginalFile, string ConvertFormatFile, string filePathToConvert, string saveConvertPathFile)
        {
            switch (FormatOriginalFile)
            {
                case ".txt":
                    switch (ConvertFormatFile)
                    {
                        case ".txt":

                            break;
                        case ".doc":

                            break;
                        case ".docx":

                            break;
                        case ".pdf":

                            break;
                        case ".html":

                            break;
                        case ".odt":

                            break;
                    }
                    break;
                case ".doc":
                    switch (ConvertFormatFile)
                    {
                        case ".txt":

                            break;
                        case ".doc":

                            break;
                        case ".docx":

                            break;
                        case ".pdf":
                            ConvertDocxinPDF(filePathToConvert, saveConvertPathFile);
                            break;
                        case ".html":
                            ConvertDocxInHTML(filePathToConvert, saveConvertPathFile);
                            break;
                        case ".odt":

                            break;
                    }
                    break;
                case ".docx":
                    switch (ConvertFormatFile)
                    {
                        case ".txt":

                            break;
                        case ".doc":

                            break;
                        case ".docx":

                            break;
                        case ".pdf":
                            ConvertDocxinPDF(filePathToConvert, saveConvertPathFile);
                            break;
                        case ".html":
                            ConvertDocxInHTML(filePathToConvert, saveConvertPathFile);
                            break;
                        case ".odt":

                            break;
                    }
                    break;
                case ".pdf":
                    switch (ConvertFormatFile)
                    {
                        case ".txt":

                            break;
                        case ".doc":
                            ConvertPDFinWord(filePathToConvert, saveConvertPathFile);
                            break;
                        case ".docx":
                            ConvertPDFinWord(filePathToConvert, saveConvertPathFile);
                            break;
                        case ".pdf":

                            break;
                        case ".html":

                            break;
                        case ".odt":

                            break;
                    }
                    break;
                case ".html":
                    switch (ConvertFormatFile)
                    {
                        case ".txt":

                            break;
                        case ".doc":

                            break;
                        case ".docx":

                            break;
                        case ".pdf":

                            break;
                        case ".html":

                            break;
                        case ".odt":

                            break;
                    }
                    break;
                case ".odt":
                    switch (ConvertFormatFile)
                    {
                        case ".txt":

                            break;
                        case ".doc":

                            break;
                        case ".docx":

                            break;
                        case ".pdf":

                            break;
                        case ".html":

                            break;
                        case ".odt":

                            break;
                    }
                    break;
            }
        }

        public bool ConvertPDFinWord(string PathToPDFFile, string PathToDOCXFile)
        {
            try
            {
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void ConvertDocxInHTML(string PathToDOCXFile, string PathToHTMLFile)
        {
            byte[] inpData = File.ReadAllBytes(PathToDOCXFile);
            byte[] outData = null;

            using (MemoryStream msInp = new MemoryStream(inpData))
            {

                // Load a document.
                DocumentCore dc = DocumentCore.Load(msInp, new PdfLoadOptions()
                {
                    PreserveGraphics = true,
                    DetectTables = true
                });

                // Save the document to HTML-fixed format.
                using (MemoryStream outMs = new MemoryStream())
                {
                    dc.Save(outMs, new HtmlFixedSaveOptions()
                    {
                        CssExportMode = CssExportMode.Inline,
                        EmbedImages = true
                    });
                    outData = outMs.ToArray();
                }
                // Show the result for demonstration purposes.
                if (outData != null)
                {
                    File.WriteAllBytes(PathToHTMLFile, outData);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(PathToHTMLFile) { UseShellExecute = true });
                }
            }
        }
        public bool ConvertDocxinPDF(string PathToDOCXFile, string PathToPDFFile)
        {
            try
            {
                DocumentCore documentCore = DocumentCore.Load(PathToDOCXFile);
                documentCore.Save(PathToPDFFile);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
