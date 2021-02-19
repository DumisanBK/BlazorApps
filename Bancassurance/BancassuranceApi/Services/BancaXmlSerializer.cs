using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BancassuranceApi.Services
{
    public class BancaXmlSerializer : IBancaXmlSerializer
    {
        public string Serialize<T>(T dataToSerialize)
        {
            string serialized;

            try
            {
                using (var stringwriter = new System.IO.StringWriter())
                {
                    var serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(stringwriter, dataToSerialize);

                    serialized = stringwriter.ToString();
                }

            }
            catch
            {
                throw;
            }

            return serialized;
        }

        public T Deserialize<T>(string xmlText)
        {
            T deserialized;

            try
            {
                using (var stringReader = new System.IO.StringReader(xmlText))
                {
                    var serializer = new XmlSerializer(typeof(T));

                    deserialized = (T)serializer.Deserialize(stringReader);
                }
            }
            catch
            {
                throw;
            }

            return deserialized;
        }
    }
}
