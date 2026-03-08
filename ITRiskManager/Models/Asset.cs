using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRiskManager.Models
{
    public class Asset
    {
        public int AssetID { get; set; }
        public string AssetName { get; set; }
        public string AssetType { get; set; }
        public string AssetOwner { get; set; }
        public int CriticalityScor {  get; set; }
    }
}
