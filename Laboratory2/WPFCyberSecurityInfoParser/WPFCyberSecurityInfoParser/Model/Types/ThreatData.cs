using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCyberSecurityInfoParser.Model.Types
{
    [Serializable]
    public class ThreatData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ThreatSource { get; set; }
        public string ImpactObject { get; set; }
        public string IsPrivacyViolation { get; set; }
        public string IsIntegrityViolation { get; set; }
        public string IsAvailabilityViolation { get; set; }
    }
}
