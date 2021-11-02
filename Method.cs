using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlTools.Test
{
    //[XmlRoot("method")]
    public class Method
    {
        [XmlText]
        public string Value { get; set; }
        [XmlAttribute("description")]
        public string description { get; set; }

    }
}

