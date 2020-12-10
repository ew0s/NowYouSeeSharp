using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncryptAppBusinessLayer.Core.Abstractions;

namespace EncryptAppBusinessLayer.Core.Adapters
{
    internal class DocxToStringListAdapter : EncryptAdapter
    {
        public DocxToStringListAdapter(FileInfo fileInfo) : base(fileInfo)
        {
        }

        internal override bool TryConvertToList(out List<List<string>> outList)
        {
            outList = null;
            if (FileInfo.Extension != ".docx" && FileInfo.Extension != ".doc")
            {
                return false;
            }

            return false;
        }
    }
}
