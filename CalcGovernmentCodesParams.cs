using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlTools.Test
{
    //[Serializable]
    public class CalcGovernmentCodesParams
    {
        [XmlElement("classificationID")]
        public int ClassificationID { get; set; }

        [XmlElement("characteristics")]
        public Characteristics Characteristics { get; set; }
    }
}
