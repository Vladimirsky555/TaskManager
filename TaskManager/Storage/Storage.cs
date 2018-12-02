using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaskManager.Storage
{
    class Storage: IStorage
    {
        public bool Save(Object element)
        {
            Type t = element.GetType();

            XmlSerializer formatter = new XmlSerializer(typeof(object));

            using (FileStream fs = new FileStream(t.FullName + ".xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, element);
            }

            return true;
        }

        public Object Load(Type element)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(object));

            using (FileStream fs = new FileStream(element.FullName + ".xml", FileMode.OpenOrCreate))
            {
                return formatter.Deserialize(fs);
            }
        }
    }
}
