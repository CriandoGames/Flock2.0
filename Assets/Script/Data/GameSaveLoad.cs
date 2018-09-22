using System.IO;
using System.Xml.Serialization;
using UnityEngine;

namespace _Game.Script.Data
{
    public static class GameSaveLoad
    {
        private static readonly string path = Application.persistentDataPath + "/Flock.xml";

        public static void Save(GameData data)
        {
            var serializer = new XmlSerializer(typeof(GameData));

            var stream = new FileStream(path, FileMode.Create);

            serializer.Serialize(stream, data);
            stream.Dispose();

        }

        public static void Load()
        {
            var data = new GameData();

            var initialize = new GameDataInitialize();

            var serializer = new XmlSerializer(typeof(GameData));

            //
            try
            {
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    data = serializer.Deserialize(stream) as GameData;
                }
            }
            catch (System.Exception)
            {
                data = initialize.Start();
                Save(data);
            }

            initialize.Set(data);
        }
    }
}

