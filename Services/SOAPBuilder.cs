using System.Xml.Linq;

namespace Services
{
    public class SOAPBuilder
    {
        public XElement SopaBody(XNamespace ins, XElement Body)
        {
            XNamespace soapenv = "http://schemas.xmlsoap.org/soap/envelope/";
            XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";
            XNamespace xsd = "http://www.w3.org/2001/XMLSchema";
            XNamespace Ins = ins;

            XElement root = new XElement(soapenv + "Envelope",
                new XAttribute(XNamespace.Xmlns + "xsi", "http://www.w3.org/2001/XMLSchema-instance"),
                new XAttribute(XNamespace.Xmlns + "xsd", "http://www.w3.org/2001/XMLSchema"),
                new XAttribute(XNamespace.Xmlns + "soapenv", "http://schemas.xmlsoap.org/soap/envelope/"),
                new XAttribute(XNamespace.Xmlns + "ins", Ins),
                new XElement(soapenv + "Header"),
                new XElement(soapenv + "Body", Body));
            
            return root;
        }
    }
}
