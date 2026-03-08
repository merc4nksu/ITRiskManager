using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRiskManager.Models
{
    public class Risk
    {
        public int RiskID { get; set; }
        public int AssetID { get; set; }
        public int ThreatID { get; set; }
        public int VulID { get; set; }
        public int Probability { get; set; }
        public int Impact { get; set; }
        public int RiskScore { get; set; }
        public string RiskLevel { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
