using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace OOP2

{
    // https://www.linkedin.com/pulse/adapter-pattern-c-real-world-example-santosh-singh/
    // NuGet Newtonsoft.Json indir
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }

    public static class CustomerDataProvider //JSON OLARAK GERİ DÖNDÜRÜR
    {
        public static List<Customer> GetData() =>
            new List<Customer>
        {
            new Customer { City = "Italy", Name = "Alfa Romeo", Address = "Address1" },
            new Customer { City = "UK", Name = "Aston Martin", Address = "Address1"  },
            new Customer { City = "USA", Name = "Dodge", Address = "Address1"  },
            new Customer { City = "Japan", Name = "Subaru", Address = "Address1"  },
            new Customer { City = "Germany", Name = "BMW", Address = "Address1"  }

        };
    }

    public class ThirdPartyApi
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Customers");
            var xAttributes = CustomerDataProvider.GetData()
                .Select(m => new XElement("Customer",
                                    new XAttribute("City", m.City),
                                    new XAttribute("Name", m.Name),
                                    new XAttribute("Address", m.Address)));

            xElement.Add(xAttributes);
            xDocument.Add(xElement);
            return xDocument;
        }
    }

    public interface IConvertor
    {
        string ConvertXmlToJson();
    }

    public class XmlToJsonAdapter : IConvertor
    {
        private readonly ThirdPartyApi _xmlConverter;

        public XmlToJsonAdapter(ThirdPartyApi xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public string ConvertXmlToJson()
        {

            string jsonText = JsonConvert.SerializeXNode(_xmlConverter.GetXML());
            return jsonText;
        }
    }

    //public class ThirdPartyApi
    //    {
    //        public string GetCustomer()
    //        {
    //            return JsonConvert.SerializeObject(CustomerDataProvider.getData());
    //            // getData();
    //        }
    //    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // BEFORE CHANGES
            // var result=new ThirdPartyApi().GetJSON();
            // Console.WriteLine(result.ToString());

            // AFTER CHANGES
            var adapterResult = new XmlToJsonAdapter(new ThirdPartyApi()).ConvertXmlToJson();
            Console.WriteLine(adapterResult.ToString());

        }
    }
}
