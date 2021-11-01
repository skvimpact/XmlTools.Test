using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlTools.Test
{
    //[Serializable]
    [XmlRoot(ElementName = "calcGovernmentCodesRq")]
    public class CalcGovernmentCodesRq : Rq
    {
        [XmlElement("calcGovernmentCodesParams")]
        public CalcGovernmentCodesParams CalcGovernmentCodesParams { get; set; }
    }
}
