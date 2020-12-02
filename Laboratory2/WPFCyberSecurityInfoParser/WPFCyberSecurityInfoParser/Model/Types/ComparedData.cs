using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCyberSecurityInfoParser.Model.Types
{
    public class ComparedData
    { 
        public ThreatData _oldData { get; }
        public ThreatData _newData { get; }

        public ComparedData(ThreatData newData, ThreatData oldData)
        {
            _newData = newData;
            _oldData = oldData;
        }
    }
}
