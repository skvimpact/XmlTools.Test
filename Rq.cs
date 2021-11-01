using System;
using System.Xml.Serialization;

namespace XmlTools.Test
{
    public class Rq
    {
        [XmlElement("messageID")]
        public Guid MessageID { get; set; }
        [XmlElement("messageDT")]
        public string MessageDT { get; set; }
        [XmlElement("correlationID")]
        public Guid CorrelationID { get; set; }
        public Rq()
        {
            MessageID = Guid.NewGuid();
            MessageDT = $"{DateTime.Now:O}";
            CorrelationID = Guid.NewGuid();
        }
    }
}
