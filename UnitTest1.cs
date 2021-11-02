using MdsMessageSchema;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using Xunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MdsRepo;
using Microsoft.Extensions.Configuration.Json;
using System.Linq;

namespace XmlTools.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<SchemaDbContext>();
            optionsBuilder.UseSqlServer(config["ConnectionStrings:SchemaConnection"]);
            SchemaDbContext db = new SchemaDbContext(optionsBuilder.Options);
            ISchemaRepo repo = new SchemaRepoEF(db);


            IEnumerable<SchemaItem> items = repo.SchemaItems.ToArray();
            var oldRq = new CalcGovernmentCodesRq
            {
                Method = new Method() { description = "46464", Value = "Go"},
                CalcGovernmentCodesParams = new CalcGovernmentCodesParams()
                {
                    ClassificationID = 1,
                    Characteristics = new Characteristics()
                    {
                        Characteristic = new Characteristic[] {
                            new Characteristic() { ID = 2, Value = "B"},
                            new Characteristic() { ID = 3, Value = "C"},
                            new Characteristic() { ID = 4}
                }
                    }}};
            var xml = Model.ToXML(oldRq);
            //Debug.WriteLine(xml);
            var newRq = Xml.ToModel<CalcGovernmentCodesRq>(xml);
            Assert.Equal("B", newRq.CalcGovernmentCodesParams.Characteristics.Characteristic[0].Value);

            //var item = items.Where(i => XPath(i.IntMessageLineID) == xpath).FirstOrDefault();

            XDocument doc = XDocument.Load(new StringReader(xml));
            //var classes = doc.ModelClasses(i => i.Name.LocalName);

            var ms = MessageSchema.Analyze(items);
            //var classes = doc.ModelClasses(xElement => ms.ItemWithXPath(xElement.XmlXPath()).Type);
            var classes = ms.ModelClasses();
            foreach (var i in classes)
            {
                Debug.WriteLine(i.Content);
            }
        }

        [Fact]
        public void Test2()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<SchemaDbContext>();
            optionsBuilder.UseSqlServer(config["ConnectionStrings:SchemaConnection"]);
            SchemaDbContext db = new SchemaDbContext(optionsBuilder.Options);
            ISchemaRepo repo = new SchemaRepoEF(db);
            foreach (var i in repo.SchemaItems)
            {
                Debug.WriteLine(i.ElementName);
            }
        }
    }

}
