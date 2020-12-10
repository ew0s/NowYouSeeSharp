using System.Collections.Generic;
using System.IO;

namespace EncryptAppBusinessLayer.Core.Abstractions
{
    internal abstract class EncryptAdapter
    {
        protected readonly FileInfo FileInfo;

        protected EncryptAdapter(FileInfo fileInfo)
        {
            FileInfo = fileInfo;
        }

        internal abstract bool TryConvertToList(out List<List<string>> outList);
    }
}