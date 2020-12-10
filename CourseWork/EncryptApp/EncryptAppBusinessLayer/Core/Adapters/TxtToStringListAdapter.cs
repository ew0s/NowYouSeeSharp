using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EncryptAppBusinessLayer.Core.Abstractions;

namespace EncryptAppBusinessLayer.Core.Adapters
{
    internal class TxtToStringListAdapter : EncryptAdapter
    {
        public TxtToStringListAdapter(FileInfo fileInfo) : base(fileInfo)
        {
        }

        internal override bool TryConvertToList(out List<List<string>> outList)
        {
            outList = null;
            if (FileInfo.Extension != ".txt")
            {
                return false;
            }
            var tmpList = File.ReadAllLines(FileInfo.FullName).ToList();

            var stringSeparators = new[] {' '};
            outList = tmpList.Select(line => line
                .Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries)
                .ToList()).ToList();

            return true;
        }
    }
}
