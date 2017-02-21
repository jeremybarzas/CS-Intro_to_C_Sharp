using System;
using System.Xml.Serialization;
using System.IO;

namespace WinForms_Combat_Assessment
{
    public static class DataSerializer<T>
    {
        public static void Serialize(string fileName, T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            Directory.CreateDirectory(Environment.CurrentDirectory + "../Saves/");

            TextWriter writer = new StreamWriter(Environment.CurrentDirectory + "../Saves/" + fileName + ".xml");

            serializer.Serialize(writer, data);

            writer.Close();
        }

        public static T Deserialize(string fileName)
        {
            T data;

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            TextReader reader = new StreamReader(Environment.CurrentDirectory + "../Saves/" + fileName + ".xml");

            data = (T)serializer.Deserialize(reader);

            reader.Close();

            return data;
        }
    }
}