using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XmlTools.Test
{
    public class XmlCheck
    {
        [Fact]
        public void Deserialize()
        {
            var u = Xml.ToModel<CalcGovernmentCodesRq>(@"<calcGovernmentCodesRq>
  <messageID>111</messageID>
  <messageDT>222</messageDT>
  <correlationID>333</correlationID>
  <sourceCode>444</sourceCode>
  <sourceAreaID>555</sourceAreaID>
  <destinationCode>666</destinationCode>
  <method description = ""464646"">Go</method>
    <calcGovernmentCodesParams> 
     <classificationID>255</classificationID>
      <characteristics> 
       <characteristic>
          <ID>255</ID>
          <value>34.047</value>
        </characteristic>
       <characteristic>
          <ID>64</ID>
        </characteristic>
      </characteristics>
   </calcGovernmentCodesParams>
 </calcGovernmentCodesRq>");
        }

        [Fact]
        public void Serialize()
        {
            var oldRq = new CalcGovernmentCodesRq
            {
                Method = new Method() { description = "46464", Value = "Go" },
                CalcGovernmentCodesParams = new CalcGovernmentCodesParams()
                {
                    ClassificationID = 1,
                    Characteristics = new Characteristics() {
                        Characteristic = new Characteristic[] {
                            new Characteristic() { ID = 2, Value = "B"},
                            new Characteristic() { ID = 3, Value = "C"},
                            new Characteristic() { ID = 4}
                        }
                    }
                }
            };
            var xml = Model.ToXML(oldRq);
        }
    }
}
