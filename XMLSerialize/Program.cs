using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace XMLSerialize
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlRootAttribute theRoot = new XmlRootAttribute();
            theRoot.ElementName = "Stores";
            theRoot.IsNullable = true;

            // even though the StoreSurvey class is decorated with the xmlroot attribute, seems the only
            // way this will work is if the xmlroot attribute is added directly to the serializer
            var serializer = new XmlSerializer(typeof(List<StoreSurvey>),theRoot);

            using (FileStream stream = File.OpenRead("E:\\GitProjects\\XMLSerialize\\XMLFile.txt"))
            {
                 List<StoreSurvey> storeSurvey = (List<StoreSurvey>)serializer.Deserialize(stream);
            }
            
        }
    }
}

// this is the xml
//<Stores>
//<StoreSurvey>
//<AnnualSales>800000</AnnualSales>
//<AnnualRevenue>80000</AnnualRevenue>
//<BankName>United Security</BankName>
//<BusinessType>BM</BusinessType>
//<YearOpened>1996</YearOpened>
//<Specialty>Mountain</Specialty>
//<SquareFeet>21000</SquareFeet>
//<Brands>2</Brands>
//<Internet>ISDN</Internet>
//<NumberEmployees>13</NumberEmployees>
//</StoreSurvey>
//<StoreSurvey>
//<AnnualSales>800000</AnnualSales>
//<AnnualRevenue>80000</AnnualRevenue>
//<BankName>United Security</BankName>
//<BusinessType>BM</BusinessType>
//<YearOpened>1996</YearOpened>
//<Specialty>Mountain</Specialty>
//<SquareFeet>21000</SquareFeet>
//<Brands>2</Brands>
//<Internet>ISDN</Internet>
//<NumberEmployees>13</NumberEmployees>
//</StoreSurvey>
//</Stores>
