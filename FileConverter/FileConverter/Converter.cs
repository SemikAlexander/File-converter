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
        public bool ConvertFile(string sourceFile, string convertFile)
        {
            try
            {
                DocumentCore documentCore = DocumentCore.Load(sourceFile);
                documentCore.Save(convertFile);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}