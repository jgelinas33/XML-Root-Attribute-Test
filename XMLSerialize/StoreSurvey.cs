using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSerialize
{
    [Serializable, XmlRoot (ElementName="Stores",IsNullable=true)]
    public class StoreSurvey
    {        
        [XmlElement("AnnualSales")]        
        public int AnnualSales { get; set; }

        [XmlElement ("AnnualRevenue")]
        public int AnnualRevenue { get; set; }

        [XmlElement("BankName")]
        public string BankName { get; set; }

        [XmlElement ("BusinessType")]
        public string BusinessType { get; set; }

        [XmlElement ("YearOpened")]
        public string YearOpened { get; set; }

        [XmlElement("Specialty")]
        public string Specialty { get; set; }

        [XmlElement("SquareFeet")]
        public string SquareFeet { get; set; }

        [XmlElement("Brands")]
        public int Brands { get; set; }

        [XmlElement("Internet")]
        public string Internet { get; set; }

        [XmlElement("NumberOfEmployees")]
        public int NumberOfEmployees { get; set; }
    }
}
