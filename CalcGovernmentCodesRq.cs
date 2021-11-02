using System.Xml.Serialization;
namespace XmlTools.Test
{
	[XmlRoot(ElementName = "calcGovernmentCodesRq")]
	public class CalcGovernmentCodesRq //: Rq
	{
        [XmlElement("messageID")]
        public string MessageID { get; set; }
        [XmlElement("messageDT")]
        public string MessageDT { get; set; }
        [XmlElement("correlationID")]
        public string CorrelationID { get; set; }
        [XmlElement("sourceCode")]
		public string SourceCode { get; set; }
		[XmlElement("sourceAreaID")]
		public string SourceAreaID { get; set; }
		[XmlElement("destinationCode")]
		public string DestinationCode { get; set; }
		[XmlElement("method")]
		public Method Method { get; set; }
		[XmlElement("calcGovernmentCodesParams")]
		public CalcGovernmentCodesParams CalcGovernmentCodesParams { get; set; }
	}
}
