using System;
using System.Diagnostics;
using Xunit;

namespace XmlTools.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var oldRq = new CalcGovernmentCodesRq
            {
                CalcGovernmentCodesParams = new CalcGovernmentCodesParams()
                {
                    ClassificationID = 1,
                    Characteristics = new Characteristics()
                    {
                        Characteristic = new Characteristic[] {
                            new Characteristic() { ID = 2, Value = "B"},
                            new Characteristic() { ID = 3, Value = "C"}
                }}}};
            var xml = Model.ToXML(oldRq);
            Debug.WriteLine(xml);
            var newRq = Xml.ToModel<CalcGovernmentCodesRq>(xml);
            Assert.Equal("B", newRq.CalcGovernmentCodesParams.Characteristics.Characteristic[0].Value);
        }
    }
}
