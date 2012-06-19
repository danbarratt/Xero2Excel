using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Xero2Excel.Contracts.Helpers
{
    public static class GenericSerializer<T>
    {
        private static readonly XmlSerializer SerializerOfT = new XmlSerializer(typeof(T));

        /// <summary>
        /// Serializes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static string Serialize(T item)
        {
            StringBuilder sb = new StringBuilder();

            using (StringWriter sw = new StringWriter(sb))
            {
                SerializerOfT.Serialize(sw, item);
                sw.Flush();
            }

            return sb.ToString();
        }

        /// <summary>
        /// Deserializes the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static T Deserialize(string input)
        {
            using (StringReader sr = new StringReader(input))
            {
                return (T)SerializerOfT.Deserialize(sr);
            }
        }
    }
}
