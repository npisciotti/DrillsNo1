using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Serialize
    {
        Stream stream = null;
        BinaryFormatter bformatter = null;
        string txtFileName = "";
        public Serialize(string filename)
        {
            txtFileName = filename;
            stream = File.Open(txtFileName, FileMode.Create);
            bformatter = new BinaryFormatter();
        }

        public void SerializeObject(Object objectToSerialize)
        {
            bformatter.Serialize(stream, objectToSerialize);
        }

        public void DeserializeObjects()
        {
            Object objectToDeserialize = null;
            stream = File.Open(txtFileName, FileMode.Open);
            try
            {
                while (stream.CanSeek)
                {
                    objectToDeserialize = (Object)bformatter.Deserialize(stream);

                    if(objectToDeserialize is ComputerObject)
                    {
                        ComputerObject co = (ComputerObject)objectToDeserialize;
                        Console.WriteLine(co.printContent());
                    }
                    else if (objectToDeserialize is HomeObject)
                    {
                        HomeObject ho = (HomeObject)objectToDeserialize;
                        Console.WriteLine(ho.printContent());
                    }
                }
            }
            catch(SerializationException ex )
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("End Of File");
            }
        }

        public void closeStream()
        {
            stream.Close();
        }
    }
}
