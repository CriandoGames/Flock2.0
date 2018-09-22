using System.IO;
using System.Xml.Serialization;

namespace _Game.Script.Data
{
    [XmlRoot("DataMaster")]

   public class GameData
    {
        [XmlAttribute("Sound")]
        public bool Sound;

        [XmlAttribute("HightScore")]
        public int HightScore;
    }
}
