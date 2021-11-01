using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlTools.Test
{
    public class Characteristics
    {
        [XmlElement("characteristic")]
        public Characteristic[] Characteristic { get; set; }
    }
}
