using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlTools.Test
{
    //[Serializable]
    public class Characteristic
    {
        [XmlElement("ID")]
        public int ID { get; set; }

        [XmlElement("value")]
        public string  Value { get; set; }
    }
}
